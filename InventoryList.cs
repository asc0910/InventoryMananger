using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryList : Form
    {
        private string myConString = "SERVER=127.0.0.1;" +
                    "DATABASE=storemanager;" +
                    "UID=root;" +
                    "PASSWORD=root;";
        private Entities context = new Entities();
        private inventory currentInventory = null;
        private int currentCategoryIdx = 0;
        private string currentImageUrl;
        private CultureInfo cultureInfo = new CultureInfo("en-US");

        public inventory Inventory
        {
            get
            {
                return currentInventory;
            }
        }

        public int count
        {
            get
            {
                return int.Parse(txtCount.Text);
            }
        }

        public string categoryName => cboCategory.SelectedText;

        public InventoryList()
        {
            InitializeComponent();
            categoryListRefresh();
        }

        private void categoryListRefresh()
        {
            using (var connection = new MySqlConnection(myConString))
            {
                connection.Open();
                var query = "SELECT id, name FROM categories";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = reader.GetString("name");
                            item.Value = reader.GetInt32("id");
                            cboCategory.Items.Add(item);
                            //cboCategory.SelectedIndex = currentCategoryIdx;
                        }
                    }
                }

            }

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategoryIdx = int.Parse((cboCategory.SelectedItem as ComboboxItem).Value.ToString());
            InventoryListRefresh();
        }
        private void InventoryListRefresh()
        {

            using (var connection = new MySqlConnection(myConString))
            {
                connection.Open();

                string query = "SELECT id, name, modelnumber FROM inventories where category=" + currentCategoryIdx; ;
                if (txtSearch.Text.Length > 2)
                    query = query + string.Format(" and name like '%{0}%'", txtSearch.Text);
                using (var da = new MySqlDataAdapter(query, connection))
                {
                    var data = new System.Data.DataSet();
                    da.Fill(data, "inventory_list");
                    lstInventory.DataSource = data.Tables[0];
                    lstInventory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    lstInventory.Columns[2].Width = 100;
                    lstInventory.Columns[0].Visible = false;
                    lstInventory.Columns[1].HeaderText = "Model Name";
                    lstInventory.Columns[2].HeaderText = "Model Number";
                }
            }
        }

        private void setInventory()
        {
            txtName.Text = currentInventory.name;
            txtModelNumber.Text = currentInventory.modelNumber;
            txtPrice.Text = (currentInventory.price ?? 0).ToString("C", cultureInfo);
            txtWidth.Text = doFormat(currentInventory.width);
            txtHeight.Text = doFormat(currentInventory.height);
            txtDepth.Text = doFormat(currentInventory.depth);
            txtDescription.Text = currentInventory.description;
            if (currentInventory.image != null && File.Exists(currentInventory.image))
                picInventory.Image = new Bitmap(currentImageUrl = currentInventory.image);
            else
                picInventory.Image = imglist.Images[0];
        }

        private string doFormat(double? myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }

        private void lstInventory_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (lstInventory.SelectedRows.Count == 0)
                return;
            var id = int.Parse(lstInventory.SelectedRows[0].Cells[0].Value.ToString());
            currentInventory = context.inventories.Single(x => x.id == id);
            setInventory();
        }

        private void lstInventory_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            InventoryListRefresh();
        }
    }
}
