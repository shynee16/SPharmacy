namespace SPharmacy
{
    partial class frmMain
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFileMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpiration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVats = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivePurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileMaintenance,
            this.transactionsToolStripMenuItem,
            this.securityToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 6);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(498, 37);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // tsmFileMaintenance
            // 
            this.tsmFileMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCategories,
            this.tsmExpiration,
            this.tsmProducts,
            this.tsmSuppliers,
            this.toolStripSeparator1,
            this.tsmDiscount,
            this.receiptNumberToolStripMenuItem,
            this.tsmUnit,
            this.tsmVats});
            this.tsmFileMaintenance.Name = "tsmFileMaintenance";
            this.tsmFileMaintenance.Size = new System.Drawing.Size(192, 33);
            this.tsmFileMaintenance.Text = "File Maintenance";
            this.tsmFileMaintenance.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.tsmFileMaintenance.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // tsmCategories
            // 
            this.tsmCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.subCategoriesToolStripMenuItem});
            this.tsmCategories.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCategories.Name = "tsmCategories";
            this.tsmCategories.Size = new System.Drawing.Size(208, 28);
            this.tsmCategories.Text = "Categories";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // subCategoriesToolStripMenuItem
            // 
            this.subCategoriesToolStripMenuItem.Name = "subCategoriesToolStripMenuItem";
            this.subCategoriesToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.subCategoriesToolStripMenuItem.Text = "SubCategories";
            this.subCategoriesToolStripMenuItem.Click += new System.EventHandler(this.subCategoriesToolStripMenuItem_Click);
            // 
            // tsmExpiration
            // 
            this.tsmExpiration.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmExpiration.Name = "tsmExpiration";
            this.tsmExpiration.Size = new System.Drawing.Size(208, 28);
            this.tsmExpiration.Text = "Expirations";
            this.tsmExpiration.Click += new System.EventHandler(this.tsmExpiration_Click_1);
            // 
            // tsmProducts
            // 
            this.tsmProducts.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmProducts.Name = "tsmProducts";
            this.tsmProducts.Size = new System.Drawing.Size(208, 28);
            this.tsmProducts.Text = "Products";
            this.tsmProducts.Click += new System.EventHandler(this.tsmProducts_Click);
            // 
            // tsmSuppliers
            // 
            this.tsmSuppliers.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSuppliers.Name = "tsmSuppliers";
            this.tsmSuppliers.Size = new System.Drawing.Size(208, 28);
            this.tsmSuppliers.Text = "Suppliers";
            this.tsmSuppliers.Click += new System.EventHandler(this.tsmSuppliers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmDiscount
            // 
            this.tsmDiscount.AccessibleDescription = "";
            this.tsmDiscount.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDiscount.Name = "tsmDiscount";
            this.tsmDiscount.Size = new System.Drawing.Size(208, 28);
            this.tsmDiscount.Text = "Discounts";
            this.tsmDiscount.Click += new System.EventHandler(this.tsmDiscount_Click);
            // 
            // receiptNumberToolStripMenuItem
            // 
            this.receiptNumberToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptNumberToolStripMenuItem.Name = "receiptNumberToolStripMenuItem";
            this.receiptNumberToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.receiptNumberToolStripMenuItem.Text = "Receipt Number";
            this.receiptNumberToolStripMenuItem.Click += new System.EventHandler(this.receiptNumberToolStripMenuItem_Click);
            // 
            // tsmUnit
            // 
            this.tsmUnit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUnit.Name = "tsmUnit";
            this.tsmUnit.Size = new System.Drawing.Size(208, 28);
            this.tsmUnit.Text = "Units";
            this.tsmUnit.Click += new System.EventHandler(this.tsmUnit_Click_1);
            // 
            // tsmVats
            // 
            this.tsmVats.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmVats.Name = "tsmVats";
            this.tsmVats.Size = new System.Drawing.Size(208, 28);
            this.tsmVats.Text = "VAT";
            this.tsmVats.Click += new System.EventHandler(this.tsmVats_Click_1);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.receivePurchaseOrderToolStripMenuItem,
            this.pOSToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(154, 33);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.transactionsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.purchaseToolStripMenuItem.Text = "Purchase Order";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // receivePurchaseOrderToolStripMenuItem
            // 
            this.receivePurchaseOrderToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivePurchaseOrderToolStripMenuItem.Name = "receivePurchaseOrderToolStripMenuItem";
            this.receivePurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.receivePurchaseOrderToolStripMenuItem.Text = "Receive Purchase Order";
            this.receivePurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.receivePurchaseOrderToolStripMenuItem_Click);
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.userTypeToolStripMenuItem});
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.securityToolStripMenuItem.Text = "Security";
            this.securityToolStripMenuItem.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.securityToolStripMenuItem.DropDownOpened += new System.EventHandler(this.DropDownOpened);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // userTypeToolStripMenuItem
            // 
            this.userTypeToolStripMenuItem.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeToolStripMenuItem.Name = "userTypeToolStripMenuItem";
            this.userTypeToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.userTypeToolStripMenuItem.Text = "User Type";
            this.userTypeToolStripMenuItem.Click += new System.EventHandler(this.userTypeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.MenuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDateTime, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(888, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(105, 29);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsertype, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogOut, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 446);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(996, 55);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblUsertype
            // 
            this.lblUsertype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsertype.ForeColor = System.Drawing.Color.White;
            this.lblUsertype.Location = new System.Drawing.Point(88, 14);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(89, 26);
            this.lblUsertype.TabIndex = 19;
            this.lblUsertype.Text = "Usertype";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(3, 14);
            this.lblUser.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 26);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "User";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Indigo;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::SPharmacy.Properties.Resources.logout1;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(849, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(144, 44);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(996, 501);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThisWillBeMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivePurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmFileMaintenance;
        private System.Windows.Forms.ToolStripMenuItem tsmCategories;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExpiration;
        private System.Windows.Forms.ToolStripMenuItem tsmProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmSuppliers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmDiscount;
        private System.Windows.Forms.ToolStripMenuItem receiptNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmVats;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblUsertype;
    }
}