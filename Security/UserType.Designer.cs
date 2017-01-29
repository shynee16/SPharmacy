namespace SPharmacy.File_Maintenance
{
    partial class UserType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserType));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvUserType = new System.Windows.Forms.DataGridView();
            this.UsersType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFileMaintenance = new System.Windows.Forms.GroupBox();
            this.chkExpirations = new System.Windows.Forms.CheckBox();
            this.chkReceiptNumber = new System.Windows.Forms.CheckBox();
            this.chkVAT = new System.Windows.Forms.CheckBox();
            this.chkUnits = new System.Windows.Forms.CheckBox();
            this.chkDiscounts = new System.Windows.Forms.CheckBox();
            this.chkSuppliers = new System.Windows.Forms.CheckBox();
            this.chkProducts = new System.Windows.Forms.CheckBox();
            this.chkCategories = new System.Windows.Forms.CheckBox();
            this.grpTransactions = new System.Windows.Forms.GroupBox();
            this.chkReceiveProducts = new System.Windows.Forms.CheckBox();
            this.chkPurchaseOrders = new System.Windows.Forms.CheckBox();
            this.chkPointOfSales = new System.Windows.Forms.CheckBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSecurity = new System.Windows.Forms.GroupBox();
            this.chkUserTypes = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).BeginInit();
            this.grpFileMaintenance.SuspendLayout();
            this.grpTransactions.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvUserType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpFileMaintenance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpTransactions, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUserType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.grpSecurity, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserType, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 5);
            this.lblTitle.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(537, 57);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "U S E R  T Y P E";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUserType
            // 
            this.dgvUserType.AllowUserToAddRows = false;
            this.dgvUserType.AllowUserToDeleteRows = false;
            this.dgvUserType.AllowUserToResizeColumns = false;
            this.dgvUserType.AllowUserToResizeRows = false;
            this.dgvUserType.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsersType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserType.GridColor = System.Drawing.Color.Black;
            this.dgvUserType.Location = new System.Drawing.Point(3, 66);
            this.dgvUserType.MultiSelect = false;
            this.dgvUserType.Name = "dgvUserType";
            this.dgvUserType.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserType.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvUserType, 4);
            this.dgvUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserType.Size = new System.Drawing.Size(129, 354);
            this.dgvUserType.TabIndex = 2;
            this.dgvUserType.SelectionChanged += new System.EventHandler(this.dgvUserType_SelectionChanged);
            // 
            // UsersType
            // 
            this.UsersType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsersType.HeaderText = "USER TYPE";
            this.UsersType.Name = "UsersType";
            this.UsersType.ReadOnly = true;
            // 
            // grpFileMaintenance
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpFileMaintenance, 2);
            this.grpFileMaintenance.Controls.Add(this.chkExpirations);
            this.grpFileMaintenance.Controls.Add(this.chkReceiptNumber);
            this.grpFileMaintenance.Controls.Add(this.chkVAT);
            this.grpFileMaintenance.Controls.Add(this.chkUnits);
            this.grpFileMaintenance.Controls.Add(this.chkDiscounts);
            this.grpFileMaintenance.Controls.Add(this.chkSuppliers);
            this.grpFileMaintenance.Controls.Add(this.chkProducts);
            this.grpFileMaintenance.Controls.Add(this.chkCategories);
            this.grpFileMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFileMaintenance.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFileMaintenance.ForeColor = System.Drawing.Color.White;
            this.grpFileMaintenance.Location = new System.Drawing.Point(138, 108);
            this.grpFileMaintenance.Name = "grpFileMaintenance";
            this.tableLayoutPanel1.SetRowSpan(this.grpFileMaintenance, 2);
            this.grpFileMaintenance.Size = new System.Drawing.Size(196, 246);
            this.grpFileMaintenance.TabIndex = 3;
            this.grpFileMaintenance.TabStop = false;
            this.grpFileMaintenance.Text = "File Maintenance";
            // 
            // chkExpirations
            // 
            this.chkExpirations.AutoSize = true;
            this.chkExpirations.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExpirations.Location = new System.Drawing.Point(26, 206);
            this.chkExpirations.Name = "chkExpirations";
            this.chkExpirations.Size = new System.Drawing.Size(94, 19);
            this.chkExpirations.TabIndex = 7;
            this.chkExpirations.Text = "Expirations";
            this.chkExpirations.UseVisualStyleBackColor = true;
            // 
            // chkReceiptNumber
            // 
            this.chkReceiptNumber.AutoSize = true;
            this.chkReceiptNumber.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReceiptNumber.Location = new System.Drawing.Point(26, 181);
            this.chkReceiptNumber.Name = "chkReceiptNumber";
            this.chkReceiptNumber.Size = new System.Drawing.Size(85, 19);
            this.chkReceiptNumber.TabIndex = 6;
            this.chkReceiptNumber.Text = "Receipt #";
            this.chkReceiptNumber.UseVisualStyleBackColor = true;
            // 
            // chkVAT
            // 
            this.chkVAT.AutoSize = true;
            this.chkVAT.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVAT.Location = new System.Drawing.Point(26, 156);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Size = new System.Drawing.Size(52, 19);
            this.chkVAT.TabIndex = 5;
            this.chkVAT.Text = "VAT";
            this.chkVAT.UseVisualStyleBackColor = true;
            // 
            // chkUnits
            // 
            this.chkUnits.AutoSize = true;
            this.chkUnits.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnits.Location = new System.Drawing.Point(26, 131);
            this.chkUnits.Name = "chkUnits";
            this.chkUnits.Size = new System.Drawing.Size(58, 19);
            this.chkUnits.TabIndex = 4;
            this.chkUnits.Text = "Units";
            this.chkUnits.UseVisualStyleBackColor = true;
            // 
            // chkDiscounts
            // 
            this.chkDiscounts.AutoSize = true;
            this.chkDiscounts.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiscounts.Location = new System.Drawing.Point(26, 106);
            this.chkDiscounts.Name = "chkDiscounts";
            this.chkDiscounts.Size = new System.Drawing.Size(85, 19);
            this.chkDiscounts.TabIndex = 3;
            this.chkDiscounts.Text = "Discounts";
            this.chkDiscounts.UseVisualStyleBackColor = true;
            // 
            // chkSuppliers
            // 
            this.chkSuppliers.AutoSize = true;
            this.chkSuppliers.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuppliers.Location = new System.Drawing.Point(26, 81);
            this.chkSuppliers.Name = "chkSuppliers";
            this.chkSuppliers.Size = new System.Drawing.Size(81, 19);
            this.chkSuppliers.TabIndex = 2;
            this.chkSuppliers.Text = "Suppliers";
            this.chkSuppliers.UseVisualStyleBackColor = true;
            // 
            // chkProducts
            // 
            this.chkProducts.AutoSize = true;
            this.chkProducts.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProducts.Location = new System.Drawing.Point(26, 56);
            this.chkProducts.Name = "chkProducts";
            this.chkProducts.Size = new System.Drawing.Size(79, 19);
            this.chkProducts.TabIndex = 1;
            this.chkProducts.Text = "Products";
            this.chkProducts.UseVisualStyleBackColor = true;
            // 
            // chkCategories
            // 
            this.chkCategories.AutoSize = true;
            this.chkCategories.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCategories.Location = new System.Drawing.Point(26, 31);
            this.chkCategories.Name = "chkCategories";
            this.chkCategories.Size = new System.Drawing.Size(90, 19);
            this.chkCategories.TabIndex = 0;
            this.chkCategories.Text = "Categories";
            this.chkCategories.UseVisualStyleBackColor = true;
            // 
            // grpTransactions
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpTransactions, 2);
            this.grpTransactions.Controls.Add(this.chkReceiveProducts);
            this.grpTransactions.Controls.Add(this.chkPurchaseOrders);
            this.grpTransactions.Controls.Add(this.chkPointOfSales);
            this.grpTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTransactions.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransactions.ForeColor = System.Drawing.Color.White;
            this.grpTransactions.Location = new System.Drawing.Point(340, 108);
            this.grpTransactions.Name = "grpTransactions";
            this.grpTransactions.Size = new System.Drawing.Size(200, 120);
            this.grpTransactions.TabIndex = 4;
            this.grpTransactions.TabStop = false;
            this.grpTransactions.Text = "Transactions";
            // 
            // chkReceiveProducts
            // 
            this.chkReceiveProducts.AutoSize = true;
            this.chkReceiveProducts.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReceiveProducts.Location = new System.Drawing.Point(31, 83);
            this.chkReceiveProducts.Name = "chkReceiveProducts";
            this.chkReceiveProducts.Size = new System.Drawing.Size(131, 19);
            this.chkReceiveProducts.TabIndex = 6;
            this.chkReceiveProducts.Text = "Receive Products";
            this.chkReceiveProducts.UseVisualStyleBackColor = true;
            // 
            // chkPurchaseOrders
            // 
            this.chkPurchaseOrders.AutoSize = true;
            this.chkPurchaseOrders.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPurchaseOrders.Location = new System.Drawing.Point(31, 58);
            this.chkPurchaseOrders.Name = "chkPurchaseOrders";
            this.chkPurchaseOrders.Size = new System.Drawing.Size(126, 19);
            this.chkPurchaseOrders.TabIndex = 5;
            this.chkPurchaseOrders.Text = "Purchase Orders";
            this.chkPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // chkPointOfSales
            // 
            this.chkPointOfSales.AutoSize = true;
            this.chkPointOfSales.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPointOfSales.Location = new System.Drawing.Point(31, 33);
            this.chkPointOfSales.Name = "chkPointOfSales";
            this.chkPointOfSales.Size = new System.Drawing.Size(111, 19);
            this.chkPointOfSales.TabIndex = 4;
            this.chkPointOfSales.Text = "Point of Sales";
            this.chkPointOfSales.UseVisualStyleBackColor = true;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.lblUserType, 2);
            this.lblUserType.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(138, 66);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(199, 36);
            this.lblUserType.TabIndex = 10;
            this.lblUserType.Text = "USER TYPE";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(239, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 60);
            this.btnEdit.TabIndex = 7;
            this.ttp.SetToolTip(this.btnEdit, "EDIT");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::SPharmacy.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(138, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 60);
            this.btnAdd.TabIndex = 6;
            this.ttp.SetToolTip(this.btnAdd, "ADD");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(340, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 60);
            this.btnSave.TabIndex = 8;
            this.ttp.SetToolTip(this.btnSave, "SAVE");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(441, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 60);
            this.btnClose.TabIndex = 9;
            this.ttp.SetToolTip(this.btnClose, "CLOSE");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSecurity
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpSecurity, 2);
            this.grpSecurity.Controls.Add(this.chkUserTypes);
            this.grpSecurity.Controls.Add(this.chkUsers);
            this.grpSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSecurity.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurity.ForeColor = System.Drawing.Color.White;
            this.grpSecurity.Location = new System.Drawing.Point(340, 234);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new System.Drawing.Size(200, 120);
            this.grpSecurity.TabIndex = 5;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security";
            // 
            // chkUserTypes
            // 
            this.chkUserTypes.AutoSize = true;
            this.chkUserTypes.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserTypes.Location = new System.Drawing.Point(31, 61);
            this.chkUserTypes.Name = "chkUserTypes";
            this.chkUserTypes.Size = new System.Drawing.Size(88, 19);
            this.chkUserTypes.TabIndex = 5;
            this.chkUserTypes.Text = "User Type";
            this.chkUserTypes.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsers.Location = new System.Drawing.Point(31, 36);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(58, 19);
            this.chkUsers.TabIndex = 4;
            this.chkUsers.Text = "Users";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // txtUserType
            // 
            this.txtUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtUserType, 2);
            this.txtUserType.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserType.Location = new System.Drawing.Point(337, 70);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(203, 27);
            this.txtUserType.TabIndex = 11;
            // 
            // ttp
            // 
            this.ttp.BackColor = System.Drawing.Color.Black;
            this.ttp.ForeColor = System.Drawing.Color.White;
            this.ttp.ShowAlways = true;
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(553, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserType";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserType";
            this.Load += new System.EventHandler(this.UserType_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserType)).EndInit();
            this.grpFileMaintenance.ResumeLayout(false);
            this.grpFileMaintenance.PerformLayout();
            this.grpTransactions.ResumeLayout(false);
            this.grpTransactions.PerformLayout();
            this.grpSecurity.ResumeLayout(false);
            this.grpSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersType;
        private System.Windows.Forms.GroupBox grpSecurity;
        private System.Windows.Forms.GroupBox grpTransactions;
        private System.Windows.Forms.GroupBox grpFileMaintenance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkReceiveProducts;
        private System.Windows.Forms.CheckBox chkPurchaseOrders;
        private System.Windows.Forms.CheckBox chkPointOfSales;
        private System.Windows.Forms.CheckBox chkDiscounts;
        private System.Windows.Forms.CheckBox chkSuppliers;
        private System.Windows.Forms.CheckBox chkProducts;
        private System.Windows.Forms.CheckBox chkCategories;
        private System.Windows.Forms.CheckBox chkExpirations;
        private System.Windows.Forms.CheckBox chkReceiptNumber;
        private System.Windows.Forms.CheckBox chkVAT;
        private System.Windows.Forms.CheckBox chkUnits;
        private System.Windows.Forms.CheckBox chkUserTypes;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.ToolTip ttp;
    }
}