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
using System.IO;
using System.Globalization;

namespace InventoryManager
{

    public partial class InventoryTab : UserControl
    {
        private string myConString = "SERVER=127.0.0.1;" +
                    "DATABASE=storemanager;" +
                    "UID=root;" +
                    "PASSWORD=root;";
        private Entities context = new Entities();
        private inventory currentInventory = null;
        private int currentCategoryIdx = 0;
        private string currentImageUrl;
        private string serverImageUrl = "\\\\dd-svr\\Users\\ASC\\test\\";
        //private Bitmap noImage = null;// new Bitmap("noImage.png");
        private CultureInfo cultureInfo = new CultureInfo("en-US");




        public InventoryTab()
        {
            InitializeComponent();
            CategoryListRefresh();
            //cboCategory.SelectedIndex = 0;
        }

        private void CategoryListRefresh()
        {
            cboCategory.Items.Clear();
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

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            var newDlg = new InputBox("Category Name", "Category Name", "");
            newDlg.StartPosition = FormStartPosition.CenterParent;
            var result = newDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                var category = new category()
                {
                    name = newDlg.value,
                };
                context.categories.Add(category);
                context.SaveChanges();
            }
            CategoryListRefresh();
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
                var query = "SELECT id, name, modelnumber FROM inventories where category=" + currentCategoryIdx;
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
            

            /*
            var inventories = context.inventories.SqlQuery("select * from inventory where category=" + (cboCategory.SelectedItem as category).id).ToList();
            foreach (var _inventory in inventories)
            {
                lstInventory.Rows.Add(_inventory.name, _inventory.modelNumber);
            }
            */
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            currentInventory = new inventory();
            setInventory();
            lblAction.Text = "Add New Inventory";
            makeEditable();
        }

        private void makeEditable()
        {
            txtName.ReadOnly = false;
            txtModelNumber.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtWidth.ReadOnly = false;
            txtHeight.ReadOnly = false;
            txtDepth.ReadOnly = false;
            txtDescription.ReadOnly = false;
            btnChangeImage.Visible = true;
            btnAddNew.Visible = false;
            btnEdit.Visible = false;
            btnAddInventoryCount.Visible = false;
            btnDelete.Visible = false;
            btnAddInventoryCount.Text = "Apply Changes";
            lblAction.Visible = true;
            btnAplyChanges.Visible = true;
            btnCancel.Visible = true;
            lstInventory.Enabled = false;
        }

        private void lstInventory_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (lstInventory.CurrentRow == null || e.StateChanged != DataGridViewElementStates.Selected)
                return;
            var id = int.Parse(lstInventory.CurrentRow.Cells[0].Value.ToString());
            currentInventory = context.inventories.Single(x => x.id == id);
            setInventory();
        }

        private void setInventory()
        {
            txtName.Text = currentInventory.name;
            txtModelNumber.Text = currentInventory.modelNumber;
            txtPrice.Text = Convert.ToDouble(currentInventory.price).ToString("C", cultureInfo);
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

        private void lstInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(lstInventory.CurrentRow.Cells[0].Value.ToString());
            currentInventory = context.inventories.Single(x => x.id == id);
            setInventory();
        }

        private void BtnEditCategory_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex < 0)
            {
                System.Windows.Forms.MessageBox.Show("You can edit selected category. Select category in Combobox, and try again.");
                return;
            }

            var newDlg = new InputBox("Category Name", "Category Name", cboCategory.SelectedText);
            newDlg.StartPosition = FormStartPosition.CenterParent;
            var result = newDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                var category = context.categories.SingleOrDefault(x => x.id == currentCategoryIdx);
                category.name = newDlg.value;
                context.SaveChanges();
            }
            CategoryListRefresh();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            makeEditable();
            lblAction.Text = "Edit Inventory";
        }

        private void btnAddInventoryCount_Click(object sender, EventArgs e)
        {
           

        }

        private string uploadImage(string path)
        {
            if (currentImageUrl == currentInventory.image)
                return currentImageUrl;
            string toFileName = serverImageUrl + path + Path.GetFileName(currentImageUrl);

            if (!Directory.Exists(Path.GetDirectoryName(toFileName)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(toFileName));
            }

            File.Copy(currentImageUrl, toFileName, true); //for test
            return toFileName;

        }

        private void makeReadOnly()
        {
            txtName.ReadOnly = true;
            txtModelNumber.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtWidth.ReadOnly = true;
            txtHeight.ReadOnly = true;
            txtDepth.ReadOnly = true;
            txtDescription.ReadOnly = true;
            btnChangeImage.Visible = false;
            btnAddNew.Visible = true;
            btnEdit.Visible = true;
            btnAddInventoryCount.Visible = true;
            btnDelete.Visible = true;

            btnAddInventoryCount.Text = "Add Inventory Count";
            lblAction.Visible = false;
            btnAplyChanges.Visible = false;
            btnCancel.Visible = false;
            lstInventory.Enabled = true;
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlg.Title = "Select Inventory Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                picInventory.Image = new Bitmap(dlg.FileName);
                currentImageUrl = dlg.FileName;
            }
        }

        private void lstInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (lstInventory.CurrentRow == null)
                return;
            var id = int.Parse(lstInventory.CurrentRow.Cells[0].Value.ToString());
            currentInventory = context.inventories.Single(x => x.id == id);
            setInventory();
        }

        private void btnAplyChanges_Click(object sender, EventArgs e)
        {
            if (currentInventory == null)
            {
                return;
            }
            currentInventory.name = txtName.Text;
            currentInventory.modelNumber = txtModelNumber.Text;
            currentInventory.price = Decimal.Parse(txtPrice.Text, NumberStyles.Currency);
            currentInventory.width = double.Parse(txtWidth.Text, NumberStyles.Currency);
            currentInventory.height = double.Parse(txtHeight.Text, NumberStyles.Currency);
            currentInventory.depth = double.Parse(txtDepth.Text, NumberStyles.Currency);
            currentInventory.description = txtDescription.Text;
            currentInventory.category = currentCategoryIdx;
            currentInventory.image = uploadImage(txtName.Text + "\\" + txtModelNumber.Text + "\\");

            if (currentInventory.id == 0)
            {
                context.inventories.Add(currentInventory);
            }
            context.SaveChanges();
            InventoryListRefresh();
            makeReadOnly();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lstInventory.CurrentRow == null)
                return;
            var id = int.Parse(lstInventory.CurrentRow.Cells[0].Value.ToString());
            currentInventory = context.inventories.Single(x => x.id == id);
            setInventory();
            makeReadOnly();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentInventory == null)
                return;
            var result = System.Windows.Forms.MessageBox.Show("Do you want to delete this inventory?", "Confirm", MessageBoxButtons.OKCancel);
            if(result == DialogResult.Cancel)
                return;
            context.inventories.Remove(currentInventory);
            context.SaveChanges();
            InventoryListRefresh();
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex < 0)
            {
                System.Windows.Forms.MessageBox.Show("You can delete selected category. Select category in Combobox, and try again.");
                return;
            }
            var result = System.Windows.Forms.MessageBox.Show("Do you want to delete this category?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;

            var category = context.categories.SingleOrDefault(x => x.id == currentCategoryIdx);
            if(category != null)
                context.categories.Remove(category);
            context.SaveChanges();
            CategoryListRefresh();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
