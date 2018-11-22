using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using iTextSharp.text.pdf;
using System.IO;

namespace InventoryManager
{
    public partial class OrdersTab : UserControl
    {
        private order currentOrder = null;
        private Entities context = new Entities();
        private string myConString = "SERVER=127.0.0.1;" +
            "DATABASE=storemanager;" +
            "UID=root;" +
            "PASSWORD=root;";
        private CultureInfo cultureInfo = new CultureInfo("en-US");


        public OrdersTab()
        {
            InitializeComponent();
            
            dt = new DataTable();
            lstItem.DataSource = dt;
        }


        DataTable dt = null;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            currentOrder = new order();
            currentOrder.subtotal = 0;
            currentOrder.tax = 0;
            currentOrder.delivery = 0;
            currentOrder.orderProcessing = 0;
            currentOrder.fee = 0;
            currentOrder.total = 0;
            currentOrder.delivery = 150;

            setOrder();
            lblAction.Text = "Add New Bid/Order";
            cboTerm.Text = Convert.ToString(30);
            makeEditable();
           
        }

        private void makeEditable()
        {
            BtnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            txtAddress.ReadOnly = false;
            txtStagerName.ReadOnly = false;
            txtStagerCell.ReadOnly = false;
            txtSellerName.ReadOnly = false;
            txtSellerCell.ReadOnly = false;
            txtAgentName.ReadOnly = false;
            txtAgentCell.ReadOnly = false;
            txtPickUp.ReadOnly = false;
            txtPayee.ReadOnly = false;
            txtLockbox.ReadOnly = false;
            txtOrderInvoice.ReadOnly = false;
            

            dtpDelivery.Enabled = true;
            dtpPickUp.Enabled = true;
            dtpStage.Enabled = true;
            cboTerm.Enabled = true;
            cboType.Enabled = true;
            switchBid.Enabled = true;

            btnApplyChanges.Visible = true;
            btnCancel.Visible = true;
            btnAddItem.Visible = true;
            btnDeleteItem.Visible = true;
            lblAction.Visible = true;
            lstOrder.Enabled = false;
            txtSearch.ReadOnly = true;

            BtnDelivery.Visible = false;
            BtnOrderPDF.Visible = false;
                
        }

        private void setOrder()
        {
            txtAddress.Text = currentOrder.address;
            txtStagerName.Text = currentOrder.stagerName;
            txtStagerCell.Text = currentOrder.stagerCell;
            txtAgentName.Text = currentOrder.agentName;
            txtAgentCell.Text = currentOrder.agentCell;
            txtSellerName.Text = currentOrder.sellerName;
            txtSellerCell.Text = currentOrder.sellerCell;
            cboTerm.SelectedText = currentOrder.term;
            dtpDelivery.Value  =  currentOrder.deliveryDate ?? DateTime.Now;
            dtpStage.Value = currentOrder.stageDate ?? DateTime.Now;
            dtpPickUp.Value = currentOrder.pickupDate ?? DateTime.Now;
            txtPayee.Text = currentOrder.payfee;
            txtLockbox.Text = currentOrder.lockbox;
            txtOrderInvoice.Text = currentOrder.orderInvoice;
            txtSubTotal.Text = (currentOrder.subtotal ?? 0).ToString("C", cultureInfo);
            txtTax.Text = (currentOrder.tax ?? 0).ToString("C", cultureInfo);
            txtUsageFee.Text = (currentOrder.fee ?? 0).ToString("C", cultureInfo);
            txtOrderProcessing.Text = (currentOrder.orderProcessing ?? 0).ToString("C", cultureInfo);
            txtPickUp.Text = (currentOrder.delivery ?? 0).ToString("C", cultureInfo);
            txtTotal.Text = (currentOrder.total ?? 0).ToString("C", cultureInfo);
            cboType.selectedIndex = currentOrder.orderType ?? 0 ;
            switchBid.Value = currentOrder.bidFlag;

            using (var connection = new MySqlConnection(myConString))
            {
                connection.Open();
                string query = string.Format("SELECT " + 
                                            "orderInventories.id as oiid, " + 
                                            "inventories.id as id, " + 
                                            "orderInventories.qty as qty, " +
                                            "categories.name as item, " +
                                            "inventories.name as ModelName, " +
                                            "inventories.modelnumber as ModelNumber, "+
                                            "inventories.description as Description, " +
                                            "inventories.price as Price, " +
                                            "inventories.price*orderInventories.qty as TotalPrice "+
                                          "FROM orderInventories " +
                                            "inner join inventories on inventories.id=orderInventories.inventory "+
                                            "inner join categories on categories.id=inventories.category " +
                                          "where " +
                                             "orderInventories.order={0}", currentOrder.id);
                using (var da = new MySqlDataAdapter(query, connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    lstItem.DataSource = dt;
                    lstItem.Columns[0].Visible = lstItem.Columns[1].Visible = false;
                    lstItem.Columns["qty"].HeaderText = "Qty";
                    lstItem.Columns["qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    lstItem.Columns["qty"].Width = 40;
                    
                    lstItem.Columns["ModelName"].HeaderText = "Model Name";
                    lstItem.Columns["ModelName"].Width = 140;

                    lstItem.Columns["ModelNumber"].HeaderText = "Model #";
                    lstItem.Columns["ModelNumber"].Width = 80;
                    lstItem.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    lstItem.Columns["Price"].Width = 50;
                    lstItem.Columns["Price"].HeaderText = "Unit Price";
                    lstItem.Columns["TotalPrice"].HeaderText = "Total Price";
                    lstItem.Columns["TotalPrice"].Width = 50;
                }
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            makeEditable();
            lblAction.Text = "Edit Bid/Order";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
                return;
            var result = System.Windows.Forms.MessageBox.Show("Do you want to delete this Bid/Order?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            context.orders.Remove(currentOrder);
            context.SaveChanges();
            orderListRefresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            makeReadOnly();
            if (lstOrder.CurrentRow == null)
                return;
            var id = int.Parse(lstOrder.CurrentRow.Cells[0].Value.ToString());
            currentOrder = context.orders.Single(x => x.id == id);
            setOrder();
        }

        private void makeReadOnly()
        {
            BtnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            txtAddress.ReadOnly = true;
            txtStagerName.ReadOnly = true;
            txtStagerCell.ReadOnly = true;
            txtSellerName.ReadOnly = true;
            txtSellerCell.ReadOnly = true;
            txtAgentName.ReadOnly = true;
            txtAgentCell.ReadOnly = true;

            txtPayee.ReadOnly = true;
            txtLockbox.ReadOnly = true;
            txtOrderInvoice.ReadOnly = true;



            dtpDelivery.Enabled = false;
            dtpPickUp.Enabled = false;
            dtpStage.Enabled = false;
            cboTerm.Enabled = false;
            cboType.Enabled = false;
            switchBid.Enabled = false;

            btnApplyChanges.Visible = false;
            btnCancel.Visible = false;
            btnAddItem.Visible = false;
            btnDeleteItem.Visible = false;
            lblAction.Visible = false;
            lstOrder.Enabled = true;
            txtPickUp.ReadOnly = true;
            txtSearch.ReadOnly = false;

            BtnDelivery.Visible = true;
            BtnOrderPDF.Visible = true;

        }

        private void cboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpStage.Value = dtpDelivery.Value.AddDays(1);
            dtpPickUp.Value = dtpStage.Value.AddDays(int.Parse(cboTerm.Text));
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            try
            {
                currentOrder.address = txtAddress.Text;
                currentOrder.stagerName = txtStagerName.Text;
                currentOrder.stagerCell = txtStagerCell.Text;
                currentOrder.agentName = txtAgentName.Text;
                currentOrder.agentCell = txtAgentCell.Text;
                currentOrder.sellerName = txtSellerName.Text;
                currentOrder.sellerCell = txtSellerCell.Text;
                currentOrder.term = cboTerm.SelectedText;
                currentOrder.deliveryDate = dtpDelivery.Value;
                currentOrder.stageDate = dtpStage.Value;
                currentOrder.pickupDate = dtpPickUp.Value;
                currentOrder.payfee = txtPayee.Text;
                currentOrder.lockbox = txtLockbox.Text;
                currentOrder.orderInvoice = txtOrderInvoice.Text;
                currentOrder.subtotal = double.Parse(txtSubTotal.Text, NumberStyles.Currency);
                currentOrder.tax = double.Parse(txtTax.Text, NumberStyles.Currency);
                currentOrder.fee = double.Parse(txtUsageFee.Text, NumberStyles.Currency);
                currentOrder.orderProcessing = double.Parse(txtOrderProcessing.Text, NumberStyles.Currency);
                currentOrder.delivery = double.Parse(txtPickUp.Text, NumberStyles.Currency);
                currentOrder.total = double.Parse(txtTotal.Text, NumberStyles.Currency);
                currentOrder.orderType = cboType.selectedIndex;
                currentOrder.bidFlag = switchBid.Value;
                if (currentOrder.id == 0)
                    context.orders.Add(currentOrder);
                context.SaveChanges();

                foreach (DataRow _row in dt.Rows)
                {
                    var _oi = new orderinventory();
                    _oi.id = int.Parse(_row["oiid"].ToString());
                    _oi.inventory = int.Parse(_row["id"].ToString());
                    _oi.order = currentOrder.id;
                    _oi.qty = int.Parse(_row["qty"].ToString());
                    if(_oi.id == 0)
                        context.orderinventories.Add(_oi);
                }
                context.SaveChanges();
            }
            catch (FormatException myException)
            {
                System.Windows.Forms.MessageBox.Show("Some field is incorrect.");
                return;
            }
            
            orderListRefresh();
            makeReadOnly();
            setOrder();
        }

        public void orderListRefresh()
        {
            using (var connection = new MySqlConnection(myConString))
            {
                connection.Open();
                string query;

                if(txtSearch.Text.Length > 2)
                    query = string.Format("SELECT id, stagerName, address FROM orders where address like '%{0}%'", txtSearch.Text);
                else
                    query = string.Format("SELECT id, stagerName, address FROM orders where address");
                using (var da = new MySqlDataAdapter(query, connection))
                {
                    var data = new System.Data.DataSet();
                    da.Fill(data, "order_list");
                    lstOrder.DataSource = data.Tables[0];
                    lstOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    lstOrder.Columns[1].Width = 100;
                    lstOrder.Columns[0].Visible = false;
                    lstOrder.Columns[1].HeaderText = "Stager Name";
                    lstOrder.Columns[2].HeaderText = "Address";
                }
            }

        }

        private void cboTerm_TextChanged(object sender, EventArgs e)
        {
            dtpStage.Value = dtpDelivery.Value.AddDays(1);
            dtpPickUp.Value = dtpStage.Value.AddDays(int.Parse(cboTerm.Text));
        }

        private void dtpDelivery_ValueChanged(object sender, EventArgs e)
        {
            dtpStage.Value = dtpDelivery.Value.AddDays(1);
            dtpPickUp.Value = dtpStage.Value.AddDays(int.Parse(cboTerm.Text));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            orderListRefresh();
        }

        private void lstOrder_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectDlg = new InventoryList();
            var result = selectDlg.ShowDialog();
            /*
                                            orderInventories.id as oiid,
                                            orderInventories.order as oid,
                                            inventories.id as id,
                                            orderInventories.qty as qty,
                                            inventories.name as ModelName,
                                            inventories.modelnumber as ModelNumber,
                                            inventories.price as Price,
                                            inventories.price* orderInventories.qty as TotalPrice*/
            if (result == DialogResult.OK)
            {
                inventory inv = selectDlg.Inventory;
                int qty = selectDlg.count;
                DataRow dr = dt.Rows.Add(0, inv.id, qty, selectDlg.categoryName, inv.name, inv.modelNumber, inv.description, string.Format("{0:0.00}", inv.price), string.Format("{0:0.00}", inv.price * qty));
            }
            autoCalcPrice();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstItem.CurrentRow == null)
                return;
            string str = lstItem.CurrentRow.Cells[0].Value.ToString();
            int idx = int.Parse(str);

            var result = System.Windows.Forms.MessageBox.Show("Do you want to delete this Item from the list?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            var item = context.orderinventories.SingleOrDefault(x => x.id == idx);
            var dtrows = dt.Select(string.Format("oiid = {0}", idx));
            if(item != null) context.orderinventories.Remove(item);
            if(dtrows[0] != null) dt.Rows.Remove(dtrows[0]);
            lstItem.Refresh();

            autoCalcPrice();
        }

        private void autoCalcPrice()
        {
            double subTotal = 0;
            foreach (DataRow row in dt.Rows)
            {
                subTotal += double.Parse(row["TotalPrice"].ToString());
            }
            txtSubTotal.Text = subTotal.ToString("C", cultureInfo);
            txtTax.Text = (subTotal * 0.0975).ToString("C", cultureInfo);
            txtUsageFee.Text = (subTotal * 0.05).ToString("C", cultureInfo);
            txtOrderProcessing.Text = "$150.00";
        }

        private void calcTotalPrice(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (double.Parse(txtSubTotal.Text, NumberStyles.Currency) + 
                    double.Parse(txtTax.Text, NumberStyles.Currency) + 
                    double.Parse(txtUsageFee.Text, NumberStyles.Currency) + 
                    double.Parse(txtOrderProcessing.Text, NumberStyles.Currency) + 
                    double.Parse(txtPickUp.Text, NumberStyles.Currency)).ToString("C", cultureInfo);
            }
            catch (FormatException myException)
            {

            }
            
        }

        private void filterNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnPullTicket_Click(object sender, EventArgs e)
        {
            CreateOrderPDF printer = new CreateOrderPDF();           
        }

        private void lstOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstOrder.SelectedRows.Count == 0)
                return;
            var id = int.Parse(lstOrder.SelectedRows[0].Cells[0].Value.ToString());
            currentOrder = context.orders.Single(x => x.id == id);
            setOrder();
        }
    }
}
