namespace InventoryManager
{
    partial class OrdersTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersTab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOrder = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblOrderList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOrderPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDelivery = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lstItem = new System.Windows.Forms.DataGridView();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnApplyChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPickUp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOrderProcessing = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUsageFee = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboType = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupSeller = new System.Windows.Forms.GroupBox();
            this.txtSellerCell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupStager = new System.Windows.Forms.GroupBox();
            this.txtStagerCell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStagerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAgent = new System.Windows.Forms.GroupBox();
            this.txtAgentCell = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOrderInvoice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTerm = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpPickUp = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpStage = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLockbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.switchBid = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAction = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrder)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstItem)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupSeller.SuspendLayout();
            this.groupStager.SuspendLayout();
            this.groupAgent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstOrder);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblOrderList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(331, 660);
            this.panel1.TabIndex = 0;
            // 
            // lstOrder
            // 
            this.lstOrder.AllowUserToAddRows = false;
            this.lstOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lstOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.lstOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrder.Location = new System.Drawing.Point(10, 75);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.ReadOnly = true;
            this.lstOrder.RowHeadersVisible = false;
            this.lstOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstOrder.Size = new System.Drawing.Size(311, 575);
            this.lstOrder.TabIndex = 3;
            this.lstOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstOrder_CellClick);
            this.lstOrder.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.lstOrder_RowStateChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(311, 37);
            this.panel6.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txtSearch.Location = new System.Drawing.Point(57, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 23);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.Location = new System.Drawing.Point(10, 10);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(311, 28);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Order List";
            this.lblOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnOrderPDF);
            this.panel2.Controls.Add(this.BtnDelivery);
            this.panel2.Controls.Add(this.lstItem);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.btnApplyChanges);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtPickUp);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtOrderProcessing);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtUsageFee);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(658, 652);
            this.panel2.TabIndex = 1;
            // 
            // BtnOrderPDF
            // 
            this.BtnOrderPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnOrderPDF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnOrderPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnOrderPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOrderPDF.BorderRadius = 7;
            this.BtnOrderPDF.ButtonText = "Order PDF";
            this.BtnOrderPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrderPDF.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOrderPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOrderPDF.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnOrderPDF.Iconimage")));
            this.BtnOrderPDF.Iconimage_right = null;
            this.BtnOrderPDF.Iconimage_right_Selected = null;
            this.BtnOrderPDF.Iconimage_Selected = null;
            this.BtnOrderPDF.IconMarginLeft = 0;
            this.BtnOrderPDF.IconMarginRight = 0;
            this.BtnOrderPDF.IconRightVisible = true;
            this.BtnOrderPDF.IconRightZoom = 0D;
            this.BtnOrderPDF.IconVisible = false;
            this.BtnOrderPDF.IconZoom = 90D;
            this.BtnOrderPDF.IsTab = false;
            this.BtnOrderPDF.Location = new System.Drawing.Point(509, 622);
            this.BtnOrderPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrderPDF.Name = "BtnOrderPDF";
            this.BtnOrderPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnOrderPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnOrderPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOrderPDF.selected = false;
            this.BtnOrderPDF.Size = new System.Drawing.Size(136, 30);
            this.BtnOrderPDF.TabIndex = 42;
            this.BtnOrderPDF.Text = "Order PDF";
            this.BtnOrderPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOrderPDF.Textcolor = System.Drawing.Color.White;
            this.BtnOrderPDF.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnDelivery
            // 
            this.BtnDelivery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelivery.BorderRadius = 7;
            this.BtnDelivery.ButtonText = "Delivery PDF";
            this.BtnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelivery.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDelivery.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelivery.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDelivery.Iconimage")));
            this.BtnDelivery.Iconimage_right = null;
            this.BtnDelivery.Iconimage_right_Selected = null;
            this.BtnDelivery.Iconimage_Selected = null;
            this.BtnDelivery.IconMarginLeft = 0;
            this.BtnDelivery.IconMarginRight = 0;
            this.BtnDelivery.IconRightVisible = true;
            this.BtnDelivery.IconRightZoom = 0D;
            this.BtnDelivery.IconVisible = false;
            this.BtnDelivery.IconZoom = 90D;
            this.BtnDelivery.IsTab = false;
            this.BtnDelivery.Location = new System.Drawing.Point(366, 622);
            this.BtnDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelivery.Name = "BtnDelivery";
            this.BtnDelivery.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDelivery.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDelivery.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDelivery.selected = false;
            this.BtnDelivery.Size = new System.Drawing.Size(136, 30);
            this.BtnDelivery.TabIndex = 41;
            this.BtnDelivery.Text = "Delivery PDF";
            this.BtnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDelivery.Textcolor = System.Drawing.Color.White;
            this.BtnDelivery.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelivery.Click += new System.EventHandler(this.BtnPullTicket_Click);
            // 
            // lstItem
            // 
            this.lstItem.AllowUserToAddRows = false;
            this.lstItem.AllowUserToDeleteRows = false;
            this.lstItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstItem.Location = new System.Drawing.Point(10, 271);
            this.lstItem.Name = "lstItem";
            this.lstItem.ReadOnly = true;
            this.lstItem.RowHeadersVisible = false;
            this.lstItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstItem.Size = new System.Drawing.Size(638, 225);
            this.lstItem.TabIndex = 39;
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
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = false;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(164, 622);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(559, 599);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 17);
            this.txtTotal.TabIndex = 38;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnApplyChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnApplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnApplyChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplyChanges.BorderRadius = 7;
            this.btnApplyChanges.ButtonText = "Apply Changes";
            this.btnApplyChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyChanges.DisabledColor = System.Drawing.Color.Gray;
            this.btnApplyChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.btnApplyChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnApplyChanges.Iconimage")));
            this.btnApplyChanges.Iconimage_right = null;
            this.btnApplyChanges.Iconimage_right_Selected = null;
            this.btnApplyChanges.Iconimage_Selected = null;
            this.btnApplyChanges.IconMarginLeft = 0;
            this.btnApplyChanges.IconMarginRight = 0;
            this.btnApplyChanges.IconRightVisible = true;
            this.btnApplyChanges.IconRightZoom = 0D;
            this.btnApplyChanges.IconVisible = false;
            this.btnApplyChanges.IconZoom = 90D;
            this.btnApplyChanges.IsTab = false;
            this.btnApplyChanges.Location = new System.Drawing.Point(14, 620);
            this.btnApplyChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnApplyChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnApplyChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.btnApplyChanges.selected = false;
            this.btnApplyChanges.Size = new System.Drawing.Size(142, 30);
            this.btnApplyChanges.TabIndex = 3;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplyChanges.Textcolor = System.Drawing.Color.White;
            this.btnApplyChanges.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyChanges.Visible = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(415, 598);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 17);
            this.label21.TabIndex = 37;
            this.label21.Text = "Total:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPickUp
            // 
            this.txtPickUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPickUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPickUp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickUp.Location = new System.Drawing.Point(558, 576);
            this.txtPickUp.Name = "txtPickUp";
            this.txtPickUp.ReadOnly = true;
            this.txtPickUp.Size = new System.Drawing.Size(92, 16);
            this.txtPickUp.TabIndex = 36;
            this.txtPickUp.TextChanged += new System.EventHandler(this.calcTotalPrice);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(414, 575);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 17);
            this.label20.TabIndex = 35;
            this.label20.Text = "Delivery+Pick-Up:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderProcessing
            // 
            this.txtOrderProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderProcessing.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderProcessing.Location = new System.Drawing.Point(558, 557);
            this.txtOrderProcessing.Name = "txtOrderProcessing";
            this.txtOrderProcessing.ReadOnly = true;
            this.txtOrderProcessing.Size = new System.Drawing.Size(92, 16);
            this.txtOrderProcessing.TabIndex = 34;
            this.txtOrderProcessing.TextChanged += new System.EventHandler(this.calcTotalPrice);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(414, 556);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "Order Processing:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsageFee
            // 
            this.txtUsageFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsageFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsageFee.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsageFee.Location = new System.Drawing.Point(558, 538);
            this.txtUsageFee.Name = "txtUsageFee";
            this.txtUsageFee.ReadOnly = true;
            this.txtUsageFee.Size = new System.Drawing.Size(92, 16);
            this.txtUsageFee.TabIndex = 32;
            this.txtUsageFee.TextChanged += new System.EventHandler(this.calcTotalPrice);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(443, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "5% Usage Fee:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTax.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(558, 519);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(92, 16);
            this.txtTax.TabIndex = 30;
            this.txtTax.TextChanged += new System.EventHandler(this.calcTotalPrice);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(443, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "9.75% tax:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(558, 500);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(92, 16);
            this.txtSubTotal.TabIndex = 28;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.calcTotalPrice);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(443, 499);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Subtotal:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteItem);
            this.panel5.Controls.Add(this.btnAddItem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 33);
            this.panel5.TabIndex = 2;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteItem.BorderRadius = 7;
            this.btnDeleteItem.ButtonText = "Delete Item";
            this.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Iconimage")));
            this.btnDeleteItem.Iconimage_right = null;
            this.btnDeleteItem.Iconimage_right_Selected = null;
            this.btnDeleteItem.Iconimage_Selected = null;
            this.btnDeleteItem.IconMarginLeft = 0;
            this.btnDeleteItem.IconMarginRight = 0;
            this.btnDeleteItem.IconRightVisible = true;
            this.btnDeleteItem.IconRightZoom = 0D;
            this.btnDeleteItem.IconVisible = false;
            this.btnDeleteItem.IconZoom = 90D;
            this.btnDeleteItem.IsTab = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(117, 6);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteItem.selected = false;
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteItem.Textcolor = System.Drawing.Color.White;
            this.btnDeleteItem.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Visible = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddItem.BorderRadius = 7;
            this.btnAddItem.ButtonText = "Add Item";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Iconimage")));
            this.btnAddItem.Iconimage_right = null;
            this.btnAddItem.Iconimage_right_Selected = null;
            this.btnAddItem.Iconimage_Selected = null;
            this.btnAddItem.IconMarginLeft = 0;
            this.btnAddItem.IconMarginRight = 0;
            this.btnAddItem.IconRightVisible = true;
            this.btnAddItem.IconRightZoom = 0D;
            this.btnAddItem.IconVisible = false;
            this.btnAddItem.IconZoom = 90D;
            this.btnAddItem.IsTab = false;
            this.btnAddItem.Location = new System.Drawing.Point(9, 6);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddItem.selected = false;
            this.btnAddItem.Size = new System.Drawing.Size(100, 25);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.Textcolor = System.Drawing.Color.White;
            this.btnAddItem.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboType);
            this.panel4.Controls.Add(this.groupSeller);
            this.panel4.Controls.Add(this.groupStager);
            this.panel4.Controls.Add(this.groupAgent);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtOrderInvoice);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.cboTerm);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dtpPickUp);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.dtpStage);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.dtpDelivery);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtLockbox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtPayee);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.switchBid);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 184);
            this.panel4.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 3;
            this.cboType.DisabledColor = System.Drawing.Color.Gray;
            this.cboType.Enabled = false;
            this.cboType.ForeColor = System.Drawing.Color.White;
            this.cboType.Items = new string[] {
        "Staging",
        "Sales"};
            this.cboType.Location = new System.Drawing.Point(54, 3);
            this.cboType.Name = "cboType";
            this.cboType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cboType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cboType.selectedIndex = 0;
            this.cboType.Size = new System.Drawing.Size(99, 21);
            this.cboType.TabIndex = 45;
            // 
            // groupSeller
            // 
            this.groupSeller.Controls.Add(this.txtSellerCell);
            this.groupSeller.Controls.Add(this.label6);
            this.groupSeller.Controls.Add(this.txtSellerName);
            this.groupSeller.Controls.Add(this.label9);
            this.groupSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupSeller.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSeller.Location = new System.Drawing.Point(214, 96);
            this.groupSeller.Name = "groupSeller";
            this.groupSeller.Size = new System.Drawing.Size(185, 62);
            this.groupSeller.TabIndex = 40;
            this.groupSeller.TabStop = false;
            this.groupSeller.Text = "Seller";
            // 
            // txtSellerCell
            // 
            this.txtSellerCell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerCell.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerCell.Location = new System.Drawing.Point(56, 41);
            this.txtSellerCell.Name = "txtSellerCell";
            this.txtSellerCell.ReadOnly = true;
            this.txtSellerCell.Size = new System.Drawing.Size(122, 16);
            this.txtSellerCell.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cell:";
            // 
            // txtSellerName
            // 
            this.txtSellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerName.Location = new System.Drawing.Point(56, 19);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.ReadOnly = true;
            this.txtSellerName.Size = new System.Drawing.Size(122, 16);
            this.txtSellerName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name:";
            // 
            // groupStager
            // 
            this.groupStager.Controls.Add(this.txtStagerCell);
            this.groupStager.Controls.Add(this.label4);
            this.groupStager.Controls.Add(this.txtStagerName);
            this.groupStager.Controls.Add(this.label3);
            this.groupStager.Controls.Add(this.txtAddress);
            this.groupStager.Controls.Add(this.label2);
            this.groupStager.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStager.Location = new System.Drawing.Point(10, 32);
            this.groupStager.Name = "groupStager";
            this.groupStager.Size = new System.Drawing.Size(355, 65);
            this.groupStager.TabIndex = 44;
            this.groupStager.TabStop = false;
            this.groupStager.Text = "Stager";
            // 
            // txtStagerCell
            // 
            this.txtStagerCell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStagerCell.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStagerCell.Location = new System.Drawing.Point(226, 44);
            this.txtStagerCell.Name = "txtStagerCell";
            this.txtStagerCell.ReadOnly = true;
            this.txtStagerCell.Size = new System.Drawing.Size(122, 16);
            this.txtStagerCell.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cell:";
            // 
            // txtStagerName
            // 
            this.txtStagerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStagerName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStagerName.Location = new System.Drawing.Point(57, 44);
            this.txtStagerName.Name = "txtStagerName";
            this.txtStagerName.ReadOnly = true;
            this.txtStagerName.Size = new System.Drawing.Size(128, 16);
            this.txtStagerName.TabIndex = 22;
            this.txtStagerName.Text = "Sam Smith";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(57, 22);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(291, 16);
            this.txtAddress.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Address:";
            // 
            // groupAgent
            // 
            this.groupAgent.Controls.Add(this.txtAgentCell);
            this.groupAgent.Controls.Add(this.label8);
            this.groupAgent.Controls.Add(this.txtAgentName);
            this.groupAgent.Controls.Add(this.label5);
            this.groupAgent.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAgent.Location = new System.Drawing.Point(10, 95);
            this.groupAgent.Name = "groupAgent";
            this.groupAgent.Size = new System.Drawing.Size(195, 63);
            this.groupAgent.TabIndex = 39;
            this.groupAgent.TabStop = false;
            this.groupAgent.Text = "Agent";
            // 
            // txtAgentCell
            // 
            this.txtAgentCell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentCell.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentCell.Location = new System.Drawing.Point(56, 42);
            this.txtAgentCell.Name = "txtAgentCell";
            this.txtAgentCell.ReadOnly = true;
            this.txtAgentCell.Size = new System.Drawing.Size(129, 16);
            this.txtAgentCell.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cell:";
            // 
            // txtAgentName
            // 
            this.txtAgentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgentName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentName.Location = new System.Drawing.Point(56, 19);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.ReadOnly = true;
            this.txtAgentName.Size = new System.Drawing.Size(129, 16);
            this.txtAgentName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(218, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "Bid/Order:";
            // 
            // txtOrderInvoice
            // 
            this.txtOrderInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderInvoice.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderInvoice.Location = new System.Drawing.Point(515, 163);
            this.txtOrderInvoice.Name = "txtOrderInvoice";
            this.txtOrderInvoice.ReadOnly = true;
            this.txtOrderInvoice.Size = new System.Drawing.Size(105, 16);
            this.txtOrderInvoice.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Order/Invoice:";
            // 
            // cboTerm
            // 
            this.cboTerm.Enabled = false;
            this.cboTerm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.cboTerm.FormattingEnabled = true;
            this.cboTerm.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.cboTerm.Location = new System.Drawing.Point(569, 71);
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(51, 25);
            this.cboTerm.TabIndex = 40;
            this.cboTerm.Text = "30";
            this.cboTerm.SelectedIndexChanged += new System.EventHandler(this.cboTerm_SelectedIndexChanged);
            this.cboTerm.TextChanged += new System.EventHandler(this.cboTerm_TextChanged);
            this.cboTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterNumeric);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(512, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Term:";
            // 
            // dtpPickUp
            // 
            this.dtpPickUp.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUp.CustomFormat = "dd/MM/yyyy";
            this.dtpPickUp.Enabled = false;
            this.dtpPickUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickUp.Location = new System.Drawing.Point(515, 135);
            this.dtpPickUp.Name = "dtpPickUp";
            this.dtpPickUp.Size = new System.Drawing.Size(105, 23);
            this.dtpPickUp.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Pick-Up Date:";
            // 
            // dtpStage
            // 
            this.dtpStage.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStage.CustomFormat = "dd/MM/yyyy";
            this.dtpStage.Enabled = false;
            this.dtpStage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStage.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStage.Location = new System.Drawing.Point(515, 102);
            this.dtpStage.Name = "dtpStage";
            this.dtpStage.Size = new System.Drawing.Size(105, 23);
            this.dtpStage.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(427, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Stage Date:";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelivery.CustomFormat = "dd/MM/yyyy";
            this.dtpDelivery.Enabled = false;
            this.dtpDelivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDelivery.Location = new System.Drawing.Point(515, 45);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(105, 23);
            this.dtpDelivery.TabIndex = 34;
            this.dtpDelivery.ValueChanged += new System.EventHandler(this.dtpDelivery_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(427, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Delivery Date:";
            // 
            // txtLockbox
            // 
            this.txtLockbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLockbox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLockbox.Location = new System.Drawing.Point(274, 163);
            this.txtLockbox.Name = "txtLockbox";
            this.txtLockbox.ReadOnly = true;
            this.txtLockbox.Size = new System.Drawing.Size(125, 16);
            this.txtLockbox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Lockbox:";
            // 
            // txtPayee
            // 
            this.txtPayee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayee.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayee.Location = new System.Drawing.Point(59, 163);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.ReadOnly = true;
            this.txtPayee.Size = new System.Drawing.Size(136, 16);
            this.txtPayee.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Payee:";
            // 
            // switchBid
            // 
            this.switchBid.BackColor = System.Drawing.Color.Transparent;
            this.switchBid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchBid.BackgroundImage")));
            this.switchBid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchBid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchBid.Enabled = false;
            this.switchBid.Location = new System.Drawing.Point(286, 2);
            this.switchBid.Name = "switchBid";
            this.switchBid.OffColor = System.Drawing.Color.Gray;
            this.switchBid.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchBid.Size = new System.Drawing.Size(35, 20);
            this.switchBid.TabIndex = 13;
            this.switchBid.Value = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAction);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 38);
            this.panel3.TabIndex = 0;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(15, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(115, 28);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "Order List";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAction.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = false;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(533, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 7;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = false;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(425, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.BorderRadius = 7;
            this.BtnAdd.ButtonText = "Add New Bid/Order";
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Iconimage")));
            this.BtnAdd.Iconimage_right = null;
            this.BtnAdd.Iconimage_right_Selected = null;
            this.BtnAdd.Iconimage_Selected = null;
            this.BtnAdd.IconMarginLeft = 0;
            this.BtnAdd.IconMarginRight = 0;
            this.BtnAdd.IconRightVisible = true;
            this.BtnAdd.IconRightZoom = 0D;
            this.BtnAdd.IconVisible = false;
            this.BtnAdd.IconZoom = 90D;
            this.BtnAdd.IsTab = false;
            this.BtnAdd.Location = new System.Drawing.Point(218, 3);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAdd.selected = false;
            this.BtnAdd.Size = new System.Drawing.Size(199, 30);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add New Bid/Order";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdd.Textcolor = System.Drawing.Color.White;
            this.BtnAdd.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1000, 660);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstOrder)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstItem)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupSeller.ResumeLayout(false);
            this.groupSeller.PerformLayout();
            this.groupStager.ResumeLayout(false);
            this.groupStager.PerformLayout();
            this.groupAgent.ResumeLayout(false);
            this.groupAgent.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrderList;
        private System.Windows.Forms.DataGridView lstOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchBid;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLockbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.DateTimePicker dtpStage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpPickUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTerm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOrderInvoice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnApplyChanges;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUsageFee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOrderProcessing;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPickUp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupStager;
        private System.Windows.Forms.TextBox txtStagerCell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStagerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupAgent;
        private System.Windows.Forms.TextBox txtAgentCell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupSeller;
        private System.Windows.Forms.TextBox txtSellerCell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAction;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuDropdown cboType;
        private System.Windows.Forms.DataGridView lstItem;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDelivery;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOrderPDF;
    }
}
