namespace InventoryManager
{
    partial class InventoryTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstInventory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDeleteCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEditCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAddCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAplyChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddInventoryCount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChangeImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picInventory = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstInventory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeleteCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddCategory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstInventory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 660);
            this.panel1.TabIndex = 2;
            // 
            // lstInventory
            // 
            this.lstInventory.AllowUserToAddRows = false;
            this.lstInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.lstInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lstInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInventory.Location = new System.Drawing.Point(0, 55);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.ReadOnly = true;
            this.lstInventory.RowHeadersVisible = false;
            this.lstInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstInventory.Size = new System.Drawing.Size(314, 605);
            this.lstInventory.TabIndex = 1;
            this.lstInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstInventory_CellClick);
            this.lstInventory.SelectionChanged += new System.EventHandler(this.lstInventory_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnDeleteCategory);
            this.panel2.Controls.Add(this.BtnEditCategory);
            this.panel2.Controls.Add(this.BtnAddCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 55);
            this.panel2.TabIndex = 0;
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCategory.Image")));
            this.BtnDeleteCategory.ImageActive = null;
            this.BtnDeleteCategory.Location = new System.Drawing.Point(282, 18);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(25, 25);
            this.BtnDeleteCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnDeleteCategory.TabIndex = 7;
            this.BtnDeleteCategory.TabStop = false;
            this.BtnDeleteCategory.Zoom = 20;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnEditCategory
            // 
            this.BtnEditCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditCategory.Image")));
            this.BtnEditCategory.ImageActive = null;
            this.BtnEditCategory.Location = new System.Drawing.Point(249, 18);
            this.BtnEditCategory.Name = "BtnEditCategory";
            this.BtnEditCategory.Size = new System.Drawing.Size(25, 25);
            this.BtnEditCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditCategory.TabIndex = 6;
            this.BtnEditCategory.TabStop = false;
            this.BtnEditCategory.Zoom = 20;
            this.BtnEditCategory.Click += new System.EventHandler(this.BtnEditCategory_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCategory.Image")));
            this.BtnAddCategory.ImageActive = null;
            this.BtnAddCategory.Location = new System.Drawing.Point(216, 18);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(25, 25);
            this.BtnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddCategory.TabIndex = 5;
            this.BtnAddCategory.TabStop = false;
            this.BtnAddCategory.Zoom = 20;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(83, 18);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(127, 26);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnAplyChanges);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.lblAction);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAddInventoryCount);
            this.panel3.Controls.Add(this.btnAddNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(314, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 35);
            this.panel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = false;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(594, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAplyChanges
            // 
            this.btnAplyChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAplyChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAplyChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplyChanges.BorderRadius = 7;
            this.btnAplyChanges.ButtonText = "Apply Changes";
            this.btnAplyChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplyChanges.DisabledColor = System.Drawing.Color.Gray;
            this.btnAplyChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAplyChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAplyChanges.Iconimage")));
            this.btnAplyChanges.Iconimage_right = null;
            this.btnAplyChanges.Iconimage_right_Selected = null;
            this.btnAplyChanges.Iconimage_Selected = null;
            this.btnAplyChanges.IconMarginLeft = 0;
            this.btnAplyChanges.IconMarginRight = 0;
            this.btnAplyChanges.IconRightVisible = false;
            this.btnAplyChanges.IconRightZoom = 0D;
            this.btnAplyChanges.IconVisible = false;
            this.btnAplyChanges.IconZoom = 90D;
            this.btnAplyChanges.IsTab = false;
            this.btnAplyChanges.Location = new System.Drawing.Point(469, 3);
            this.btnAplyChanges.Name = "btnAplyChanges";
            this.btnAplyChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAplyChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAplyChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAplyChanges.selected = false;
            this.btnAplyChanges.Size = new System.Drawing.Size(119, 29);
            this.btnAplyChanges.TabIndex = 5;
            this.btnAplyChanges.Text = "Apply Changes";
            this.btnAplyChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAplyChanges.Textcolor = System.Drawing.Color.White;
            this.btnAplyChanges.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplyChanges.Visible = false;
            this.btnAplyChanges.Click += new System.EventHandler(this.btnAplyChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.ButtonText = "Delete Item";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = false;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = false;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(391, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(134, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(6, 8);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 20);
            this.lblAction.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 7;
            this.btnEdit.ButtonText = "Edit Item";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = false;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = false;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(275, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(113, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Item";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddInventoryCount
            // 
            this.btnAddInventoryCount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddInventoryCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddInventoryCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddInventoryCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddInventoryCount.BorderRadius = 7;
            this.btnAddInventoryCount.ButtonText = "Add to Inventory";
            this.btnAddInventoryCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInventoryCount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddInventoryCount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddInventoryCount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddInventoryCount.Iconimage")));
            this.btnAddInventoryCount.Iconimage_right = null;
            this.btnAddInventoryCount.Iconimage_right_Selected = null;
            this.btnAddInventoryCount.Iconimage_Selected = null;
            this.btnAddInventoryCount.IconMarginLeft = 0;
            this.btnAddInventoryCount.IconMarginRight = 0;
            this.btnAddInventoryCount.IconRightVisible = false;
            this.btnAddInventoryCount.IconRightZoom = 0D;
            this.btnAddInventoryCount.IconVisible = false;
            this.btnAddInventoryCount.IconZoom = 90D;
            this.btnAddInventoryCount.IsTab = false;
            this.btnAddInventoryCount.Location = new System.Drawing.Point(528, 3);
            this.btnAddInventoryCount.Name = "btnAddInventoryCount";
            this.btnAddInventoryCount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddInventoryCount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddInventoryCount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddInventoryCount.selected = false;
            this.btnAddInventoryCount.Size = new System.Drawing.Size(159, 29);
            this.btnAddInventoryCount.TabIndex = 1;
            this.btnAddInventoryCount.Text = "Add to Inventory";
            this.btnAddInventoryCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddInventoryCount.Textcolor = System.Drawing.Color.White;
            this.btnAddInventoryCount.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventoryCount.Click += new System.EventHandler(this.btnAddInventoryCount_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.BorderRadius = 7;
            this.btnAddNew.ButtonText = "Add New Item";
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Iconimage")));
            this.btnAddNew.Iconimage_right = null;
            this.btnAddNew.Iconimage_right_Selected = null;
            this.btnAddNew.Iconimage_Selected = null;
            this.btnAddNew.IconMarginLeft = 0;
            this.btnAddNew.IconMarginRight = 0;
            this.btnAddNew.IconRightVisible = false;
            this.btnAddNew.IconRightZoom = 0D;
            this.btnAddNew.IconVisible = false;
            this.btnAddNew.IconZoom = 90D;
            this.btnAddNew.IsTab = false;
            this.btnAddNew.Location = new System.Drawing.Point(119, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNew.selected = false;
            this.btnAddNew.Size = new System.Drawing.Size(153, 29);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New Item";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNew.Textcolor = System.Drawing.Color.White;
            this.btnAddNew.TextFont = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(314, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 36);
            this.panel4.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(7, 7);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(676, 25);
            this.txtName.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.txtDepth);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtHeight);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnChangeImage);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtWidth);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtPrice);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtModelNumber);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.picInventory);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(314, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 586);
            this.panel5.TabIndex = 19;
            // 
            // txtDepth
            // 
            this.txtDepth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepth.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtDepth.Location = new System.Drawing.Point(585, 173);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.ReadOnly = true;
            this.txtDepth.Size = new System.Drawing.Size(33, 20);
            this.txtDepth.TabIndex = 37;
            this.txtDepth.Text = "23.5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "X";
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtHeight.Location = new System.Drawing.Point(525, 173);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(33, 20);
            this.txtHeight.TabIndex = 34;
            this.txtHeight.Text = "23.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "X";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangeImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeImage.BorderRadius = 5;
            this.btnChangeImage.ButtonText = "Change Image";
            this.btnChangeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeImage.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangeImage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangeImage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.Iconimage")));
            this.btnChangeImage.Iconimage_right = null;
            this.btnChangeImage.Iconimage_right_Selected = null;
            this.btnChangeImage.Iconimage_Selected = null;
            this.btnChangeImage.IconMarginLeft = 0;
            this.btnChangeImage.IconMarginRight = 0;
            this.btnChangeImage.IconRightVisible = true;
            this.btnChangeImage.IconRightZoom = 0D;
            this.btnChangeImage.IconVisible = false;
            this.btnChangeImage.IconZoom = 90D;
            this.btnChangeImage.IsTab = false;
            this.btnChangeImage.Location = new System.Drawing.Point(412, 386);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangeImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChangeImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangeImage.selected = false;
            this.btnChangeImage.Size = new System.Drawing.Size(103, 29);
            this.btnChangeImage.TabIndex = 32;
            this.btnChangeImage.Text = "Change Image";
            this.btnChangeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeImage.Textcolor = System.Drawing.Color.White;
            this.btnChangeImage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.Visible = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dimention:";
            // 
            // txtWidth
            // 
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtWidth.Location = new System.Drawing.Point(469, 173);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(33, 20);
            this.txtWidth.TabIndex = 25;
            this.txtWidth.Text = "23.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtPrice.Location = new System.Drawing.Point(550, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(115, 20);
            this.txtPrice.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Model Number:";
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtModelNumber.Location = new System.Drawing.Point(550, 31);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.ReadOnly = true;
            this.txtModelNumber.Size = new System.Drawing.Size(115, 20);
            this.txtModelNumber.TabIndex = 21;
            this.txtModelNumber.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // picInventory
            // 
            this.picInventory.Location = new System.Drawing.Point(7, 15);
            this.picInventory.Name = "picInventory";
            this.picInventory.Size = new System.Drawing.Size(400, 400);
            this.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInventory.TabIndex = 19;
            this.picInventory.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.25F);
            this.label12.Location = new System.Drawing.Point(570, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.25F);
            this.label10.Location = new System.Drawing.Point(514, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.25F);
            this.label6.Location = new System.Drawing.Point(461, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "L";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(321, 521);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(676, 133);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "";
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "noImage.png");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(226, 417);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 24);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Print On Delivery Order";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(InventoryManager.order);
            // 
            // InventoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryTab";
            this.Size = new System.Drawing.Size(1009, 660);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeleteCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddCategory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private Bunifu.Framework.UI.BunifuImageButton BtnDeleteCategory;
        private Bunifu.Framework.UI.BunifuImageButton BtnEditCategory;
        private Bunifu.Framework.UI.BunifuImageButton BtnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picInventory;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnChangeImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddInventoryCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.DataGridView lstInventory;
        private System.Windows.Forms.Label lblAction;
        private Bunifu.Framework.UI.BunifuFlatButton btnAplyChanges;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
