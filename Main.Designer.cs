namespace InventoryManager
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OrderInventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storemanagerDataSet = new InventoryManager.storemanagerDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TabStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TabReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TabOrders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TabItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.OrderInventoriesTableAdapter = new InventoryManager.storemanagerDataSetTableAdapters.OrderInventoriesTableAdapter();
            this.ordersTableAdapter = new InventoryManager.storemanagerDataSetTableAdapters.ordersTableAdapter();
            this.inventoryTab1 = new InventoryManager.InventoryTab();
            this.ordersTab1 = new InventoryManager.OrdersTab();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storemanagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderInventoriesBindingSource
            // 
            this.OrderInventoriesBindingSource.DataMember = "OrderInventories";
            this.OrderInventoriesBindingSource.DataSource = this.storemanagerDataSet;
            // 
            // storemanagerDataSet
            // 
            this.storemanagerDataSet.DataSetName = "storemanagerDataSet";
            this.storemanagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.storemanagerDataSet;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.TabStore);
            this.bunifuGradientPanel1.Controls.Add(this.TabReports);
            this.bunifuGradientPanel1.Controls.Add(this.TabOrders);
            this.bunifuGradientPanel1.Controls.Add(this.TabItems);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(201)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(216, 658);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // TabStore
            // 
            this.TabStore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.TabStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabStore.BorderRadius = 0;
            this.TabStore.ButtonText = "    Store";
            this.TabStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabStore.DisabledColor = System.Drawing.Color.Gray;
            this.TabStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabStore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabStore.Iconcolor = System.Drawing.Color.Transparent;
            this.TabStore.Iconimage = ((System.Drawing.Image)(resources.GetObject("TabStore.Iconimage")));
            this.TabStore.Iconimage_right = null;
            this.TabStore.Iconimage_right_Selected = null;
            this.TabStore.Iconimage_Selected = null;
            this.TabStore.IconMarginLeft = 0;
            this.TabStore.IconMarginRight = 0;
            this.TabStore.IconRightVisible = true;
            this.TabStore.IconRightZoom = 0D;
            this.TabStore.IconVisible = true;
            this.TabStore.IconZoom = 70D;
            this.TabStore.IsTab = true;
            this.TabStore.Location = new System.Drawing.Point(0, 284);
            this.TabStore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TabStore.Name = "TabStore";
            this.TabStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.TabStore.OnHoverTextColor = System.Drawing.Color.White;
            this.TabStore.selected = false;
            this.TabStore.Size = new System.Drawing.Size(216, 68);
            this.TabStore.TabIndex = 4;
            this.TabStore.Text = "    Store";
            this.TabStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabStore.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabStore.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabStore.Visible = false;
            // 
            // TabReports
            // 
            this.TabReports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.TabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabReports.BorderRadius = 0;
            this.TabReports.ButtonText = "    Reports";
            this.TabReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabReports.DisabledColor = System.Drawing.Color.Gray;
            this.TabReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabReports.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabReports.Iconcolor = System.Drawing.Color.Transparent;
            this.TabReports.Iconimage = ((System.Drawing.Image)(resources.GetObject("TabReports.Iconimage")));
            this.TabReports.Iconimage_right = null;
            this.TabReports.Iconimage_right_Selected = null;
            this.TabReports.Iconimage_Selected = null;
            this.TabReports.IconMarginLeft = 0;
            this.TabReports.IconMarginRight = 0;
            this.TabReports.IconRightVisible = true;
            this.TabReports.IconRightZoom = 0D;
            this.TabReports.IconVisible = true;
            this.TabReports.IconZoom = 70D;
            this.TabReports.IsTab = true;
            this.TabReports.Location = new System.Drawing.Point(0, 216);
            this.TabReports.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TabReports.Name = "TabReports";
            this.TabReports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabReports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.TabReports.OnHoverTextColor = System.Drawing.Color.White;
            this.TabReports.selected = false;
            this.TabReports.Size = new System.Drawing.Size(216, 68);
            this.TabReports.TabIndex = 2;
            this.TabReports.Text = "    Reports";
            this.TabReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabReports.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabReports.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TabOrders
            // 
            this.TabOrders.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.TabOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabOrders.BorderRadius = 0;
            this.TabOrders.ButtonText = "    Orders";
            this.TabOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabOrders.DisabledColor = System.Drawing.Color.Gray;
            this.TabOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabOrders.Iconcolor = System.Drawing.Color.Transparent;
            this.TabOrders.Iconimage = ((System.Drawing.Image)(resources.GetObject("TabOrders.Iconimage")));
            this.TabOrders.Iconimage_right = null;
            this.TabOrders.Iconimage_right_Selected = null;
            this.TabOrders.Iconimage_Selected = null;
            this.TabOrders.IconMarginLeft = 0;
            this.TabOrders.IconMarginRight = 0;
            this.TabOrders.IconRightVisible = true;
            this.TabOrders.IconRightZoom = 0D;
            this.TabOrders.IconVisible = true;
            this.TabOrders.IconZoom = 80D;
            this.TabOrders.IsTab = true;
            this.TabOrders.Location = new System.Drawing.Point(0, 148);
            this.TabOrders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TabOrders.Name = "TabOrders";
            this.TabOrders.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabOrders.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.TabOrders.OnHoverTextColor = System.Drawing.Color.White;
            this.TabOrders.selected = false;
            this.TabOrders.Size = new System.Drawing.Size(216, 68);
            this.TabOrders.TabIndex = 1;
            this.TabOrders.Text = "    Orders";
            this.TabOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabOrders.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabOrders.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabOrders.Click += new System.EventHandler(this.TabOrders_Click);
            // 
            // TabItems
            // 
            this.TabItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.TabItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.TabItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabItems.BorderRadius = 0;
            this.TabItems.ButtonText = "     Inventory";
            this.TabItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabItems.DisabledColor = System.Drawing.Color.Gray;
            this.TabItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabItems.Iconcolor = System.Drawing.Color.Transparent;
            this.TabItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("TabItems.Iconimage")));
            this.TabItems.Iconimage_right = null;
            this.TabItems.Iconimage_right_Selected = null;
            this.TabItems.Iconimage_Selected = null;
            this.TabItems.IconMarginLeft = 0;
            this.TabItems.IconMarginRight = 0;
            this.TabItems.IconRightVisible = true;
            this.TabItems.IconRightZoom = 0D;
            this.TabItems.IconVisible = true;
            this.TabItems.IconZoom = 70D;
            this.TabItems.IsTab = true;
            this.TabItems.Location = new System.Drawing.Point(0, 80);
            this.TabItems.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TabItems.Name = "TabItems";
            this.TabItems.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(60)))));
            this.TabItems.OnHoverTextColor = System.Drawing.Color.White;
            this.TabItems.selected = true;
            this.TabItems.Size = new System.Drawing.Size(216, 68);
            this.TabItems.TabIndex = 0;
            this.TabItems.Text = "     Inventory";
            this.TabItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabItems.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabItems.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabItems.Click += new System.EventHandler(this.TabItems_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(30);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Padding = new System.Windows.Forms.Padding(20);
            this.bunifuImageButton1.Size = new System.Drawing.Size(216, 80);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // OrderInventoriesTableAdapter
            // 
            this.OrderInventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTab1
            // 
            this.inventoryTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryTab1.Location = new System.Drawing.Point(216, 0);
            this.inventoryTab1.Name = "inventoryTab1";
            this.inventoryTab1.Size = new System.Drawing.Size(1022, 658);
            this.inventoryTab1.TabIndex = 2;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(216, 0);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(1022, 658);
            this.ordersTab1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 658);
            this.Controls.Add(this.inventoryTab1);
            this.Controls.Add(this.ordersTab1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderInventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storemanagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton TabStore;
        private Bunifu.Framework.UI.BunifuFlatButton TabReports;
        private Bunifu.Framework.UI.BunifuFlatButton TabOrders;
        private Bunifu.Framework.UI.BunifuFlatButton TabItems;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private InventoryTab inventoryTab1;
        private OrdersTab ordersTab1;
        private System.Windows.Forms.BindingSource OrderInventoriesBindingSource;
        private storemanagerDataSet storemanagerDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private storemanagerDataSetTableAdapters.OrderInventoriesTableAdapter OrderInventoriesTableAdapter;
        private storemanagerDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        //private OrdersTab ordersTab1;
    }
}

