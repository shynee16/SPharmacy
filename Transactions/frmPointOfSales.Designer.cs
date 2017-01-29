namespace SPharmacy.Transactions
{
    partial class frmPointOfSales
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductInput = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbxDiscount = new System.Windows.Forms.ComboBox();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtInputCash = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            this.txtVatPercent = new System.Windows.Forms.TextBox();
            this.txtVatValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtOrNumber = new System.Windows.Forms.TextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 758F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 758);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 748);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::SPharmacy.Properties.Resources.Looogooo;
            this.pbLogo.Location = new System.Drawing.Point(10, 12);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(10, 12, 10, 10);
            this.pbLogo.Name = "pbLogo";
            this.tableLayoutPanel2.SetRowSpan(this.pbLogo, 3);
            this.pbLogo.Size = new System.Drawing.Size(149, 163);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(172, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "SJ PHARMACY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "SJDV, SAN JOSE, TARLAC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "+63930 - 573 - 6946";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.lblProductInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblQuantity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDiscount, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCash, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtProductCode, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudQuantity, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxDiscount, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCashierName, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblName, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtName, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblPosition, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.txtPosition, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.btnPrint, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnLogOut, 4, 9);
            this.tableLayoutPanel3.Controls.Add(this.txtInputCash, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNew, 3, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 190);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.030303F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060606F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 553);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblProductInput
            // 
            this.lblProductInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductInput.AutoSize = true;
            this.lblProductInput.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblProductInput, 2);
            this.lblProductInput.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInput.ForeColor = System.Drawing.Color.White;
            this.lblProductInput.Location = new System.Drawing.Point(3, 3);
            this.lblProductInput.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblProductInput.Name = "lblProductInput";
            this.lblProductInput.Size = new System.Drawing.Size(186, 49);
            this.lblProductInput.TabIndex = 0;
            this.lblProductInput.Text = "PRODUCT CODE";
            this.lblProductInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblQuantity, 2);
            this.lblQuantity.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(3, 58);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(186, 49);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "QUANTITY";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblDiscount, 2);
            this.lblDiscount.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(3, 113);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(186, 49);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "DISCOUNT";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCash
            // 
            this.lblCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblCash, 2);
            this.lblCash.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(3, 168);
            this.lblCash.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(186, 49);
            this.lblCash.TabIndex = 6;
            this.lblCash.Text = "CASH";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtProductCode, 3);
            this.txtProductCode.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(189, 4);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(282, 47);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp.SetToolTip(this.txtProductCode, "Input Product Code");
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.SetColumnSpan(this.nudQuantity, 3);
            this.nudQuantity.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(189, 59);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(282, 47);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp.SetToolTip(this.nudQuantity, "Input Quantity");
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDiscount.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.SetColumnSpan(this.cbxDiscount, 3);
            this.cbxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiscount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDiscount.FormattingEnabled = true;
            this.cbxDiscount.Location = new System.Drawing.Point(189, 114);
            this.cbxDiscount.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(282, 47);
            this.cbxDiscount.TabIndex = 5;
            this.ttp.SetToolTip(this.cbxDiscount, "Select Discount");
            this.cbxDiscount.SelectedIndexChanged += new System.EventHandler(this.cbxDiscount_SelectedIndexChanged);
            // 
            // lblCashierName
            // 
            this.lblCashierName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblCashierName, 5);
            this.lblCashierName.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(3, 339);
            this.lblCashierName.Margin = new System.Windows.Forms.Padding(3);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(468, 27);
            this.lblCashierName.TabIndex = 11;
            this.lblCashierName.Text = "Cashier\'s Information";
            this.lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblName, 2);
            this.lblName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 372);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 38);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.SetColumnSpan(this.txtName, 3);
            this.txtName.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(189, 373);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(282, 36);
            this.txtName.TabIndex = 13;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.SetColumnSpan(this.lblPosition, 2);
            this.lblPosition.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(3, 416);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(186, 38);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "POSITION";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.SetColumnSpan(this.txtPosition, 3);
            this.txtPosition.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(189, 417);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(282, 36);
            this.txtPosition.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::SPharmacy.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(357, 223);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 94);
            this.btnPrint.TabIndex = 9;
            this.ttp.SetToolTip(this.btnPrint, "SAVE TRANSACTION");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::SPharmacy.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(357, 460);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 90);
            this.btnLogOut.TabIndex = 16;
            this.ttp.SetToolTip(this.btnLogOut, "CLOSE POS");
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtInputCash
            // 
            this.txtInputCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtInputCash, 3);
            this.txtInputCash.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputCash.Location = new System.Drawing.Point(189, 169);
            this.txtInputCash.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtInputCash.Name = "txtInputCash";
            this.txtInputCash.Size = new System.Drawing.Size(282, 47);
            this.txtInputCash.TabIndex = 17;
            this.txtInputCash.Text = "0.00";
            this.txtInputCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttp.SetToolTip(this.txtInputCash, "Input Cash");
            this.txtInputCash.TextChanged += new System.EventHandler(this.txtInputCash_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::SPharmacy.Properties.Resources.POSnew;
            this.btnNew.Location = new System.Drawing.Point(239, 223);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 94);
            this.btnNew.TabIndex = 18;
            this.ttp.SetToolTip(this.btnNew, "CLEAR TRANSACTION");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(505, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 758F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(856, 758);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 748F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(846, 748);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.dgvProducts, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.txtCash, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.label11, 3, 8);
            this.tableLayoutPanel6.Controls.Add(this.txtChange, 5, 8);
            this.tableLayoutPanel6.Controls.Add(this.lblDateTime, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.txtSubtotal, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label5, 3, 6);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtDiscountPercent, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtDiscountName, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtVatPercent, 5, 6);
            this.tableLayoutPanel6.Controls.Add(this.txtVatValue, 6, 6);
            this.tableLayoutPanel6.Controls.Add(this.label6, 4, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtDiscountValue, 6, 5);
            this.tableLayoutPanel6.Controls.Add(this.label8, 6, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtTotalItems, 7, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblReceiptNumber, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtTotalDue, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtDateTime, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtOrNumber, 2, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(836, 738);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Black;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCode,
            this.dgvProductName,
            this.dgvUnitPrice,
            this.dgvQuantity,
            this.dgvTotalPrice});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvProducts, 16);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.GridColor = System.Drawing.Color.Black;
            this.dgvProducts.Location = new System.Drawing.Point(3, 252);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(830, 303);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.Click += new System.EventHandler(this.gotFocus);
            this.dgvProducts.DoubleClick += new System.EventHandler(this.gotFocus);
            // 
            // dgvCode
            // 
            this.dgvCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCode.FillWeight = 15F;
            this.dgvCode.HeaderText = "CODE";
            this.dgvCode.Name = "dgvCode";
            this.dgvCode.ReadOnly = true;
            this.dgvCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvProductName
            // 
            this.dgvProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductName.FillWeight = 30F;
            this.dgvProductName.HeaderText = "PRODUCT NAME";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            // 
            // dgvUnitPrice
            // 
            this.dgvUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUnitPrice.FillWeight = 15F;
            this.dgvUnitPrice.HeaderText = "UNIT PRICE";
            this.dgvUnitPrice.Name = "dgvUnitPrice";
            this.dgvUnitPrice.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvQuantity.FillWeight = 10F;
            this.dgvQuantity.HeaderText = "QTY";
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            // 
            // dgvTotalPrice
            // 
            this.dgvTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTotalPrice.FillWeight = 20F;
            this.dgvTotalPrice.HeaderText = "TOTAL PRICE";
            this.dgvTotalPrice.Name = "dgvTotalPrice";
            this.dgvTotalPrice.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 644);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 89);
            this.label10.TabIndex = 24;
            this.label10.Text = "CASH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCash
            // 
            this.txtCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtCash, 2);
            this.txtCash.Font = new System.Drawing.Font("Impact", 47.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(167, 646);
            this.txtCash.Margin = new System.Windows.Forms.Padding(0, 2, 3, 3);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(247, 84);
            this.txtCash.TabIndex = 25;
            this.txtCash.Text = "0.00";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.Click += new System.EventHandler(this.gotFocus);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.SetColumnSpan(this.label11, 2);
            this.label11.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(420, 644);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 89);
            this.label11.TabIndex = 26;
            this.label11.Text = "CHANGE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChange
            // 
            this.txtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtChange, 3);
            this.txtChange.Font = new System.Drawing.Font("Impact", 47.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(583, 646);
            this.txtChange.Margin = new System.Windows.Forms.Padding(0, 2, 3, 3);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(250, 84);
            this.txtChange.TabIndex = 27;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.Click += new System.EventHandler(this.gotFocus);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.SetColumnSpan(this.lblDateTime, 2);
            this.lblDateTime.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(5, 126);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(5, 8, 0, 3);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(245, 62);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DATE / TIME";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 597);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "SUB TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtSubtotal, 2);
            this.txtSubtotal.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.Location = new System.Drawing.Point(167, 597);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(247, 33);
            this.txtSubtotal.TabIndex = 19;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.Click += new System.EventHandler(this.gotFocus);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 597);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "VAT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 561);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountPercent.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountPercent.Location = new System.Drawing.Point(167, 562);
            this.txtDiscountPercent.Margin = new System.Windows.Forms.Padding(0, 4, 2, 3);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(81, 33);
            this.txtDiscountPercent.TabIndex = 12;
            this.txtDiscountPercent.Text = "0 %";
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.Click += new System.EventHandler(this.gotFocus);
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtDiscountName, 2);
            this.txtDiscountName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountName.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountName.Location = new System.Drawing.Point(250, 562);
            this.txtDiscountName.Margin = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.ReadOnly = true;
            this.txtDiscountName.Size = new System.Drawing.Size(292, 33);
            this.txtDiscountName.TabIndex = 11;
            this.txtDiscountName.Click += new System.EventHandler(this.gotFocus);
            // 
            // txtVatPercent
            // 
            this.txtVatPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVatPercent.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatPercent.ForeColor = System.Drawing.Color.Black;
            this.txtVatPercent.Location = new System.Drawing.Point(583, 598);
            this.txtVatPercent.Margin = new System.Windows.Forms.Padding(0, 4, 2, 3);
            this.txtVatPercent.Name = "txtVatPercent";
            this.txtVatPercent.ReadOnly = true;
            this.txtVatPercent.Size = new System.Drawing.Size(81, 33);
            this.txtVatPercent.TabIndex = 15;
            this.txtVatPercent.Text = "0 %";
            this.txtVatPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVatPercent.Click += new System.EventHandler(this.gotFocus);
            // 
            // txtVatValue
            // 
            this.txtVatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtVatValue, 2);
            this.txtVatValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatValue.ForeColor = System.Drawing.Color.Black;
            this.txtVatValue.Location = new System.Drawing.Point(666, 598);
            this.txtVatValue.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtVatValue.Name = "txtVatValue";
            this.txtVatValue.ReadOnly = true;
            this.txtVatValue.Size = new System.Drawing.Size(167, 33);
            this.txtVatValue.TabIndex = 16;
            this.txtVatValue.Text = "0.00";
            this.txtVatValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVatValue.Click += new System.EventHandler(this.gotFocus);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(547, 561);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtDiscountValue, 2);
            this.txtDiscountValue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountValue.Location = new System.Drawing.Point(666, 562);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.ReadOnly = true;
            this.txtDiscountValue.Size = new System.Drawing.Size(167, 33);
            this.txtDiscountValue.TabIndex = 13;
            this.txtDiscountValue.Text = "0.00";
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountValue.Click += new System.EventHandler(this.gotFocus);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(669, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 45);
            this.label8.TabIndex = 20;
            this.label8.Text = "ITEMS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalItems.Font = new System.Drawing.Font("Impact", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItems.Location = new System.Drawing.Point(749, 203);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(84, 45);
            this.txtTotalItems.TabIndex = 21;
            this.txtTotalItems.Text = "1";
            this.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalItems.Click += new System.EventHandler(this.gotFocus);
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel6.SetColumnSpan(this.lblReceiptNumber, 2);
            this.lblReceiptNumber.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumber.ForeColor = System.Drawing.Color.White;
            this.lblReceiptNumber.Location = new System.Drawing.Point(3, 201);
            this.lblReceiptNumber.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(247, 45);
            this.lblReceiptNumber.TabIndex = 3;
            this.lblReceiptNumber.Text = "OFFICIAL RECEIPT #";
            this.lblReceiptNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtTotalDue, 8);
            this.txtTotalDue.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDue.Location = new System.Drawing.Point(5, 6);
            this.txtTotalDue.Margin = new System.Windows.Forms.Padding(5, 6, 3, 5);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.Size = new System.Drawing.Size(828, 105);
            this.txtTotalDue.TabIndex = 23;
            this.txtTotalDue.Text = "0.00";
            this.txtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDue.Click += new System.EventHandler(this.gotFocus);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtDateTime, 6);
            this.txtDateTime.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Location = new System.Drawing.Point(250, 129);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(0, 11, 3, 3);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Size = new System.Drawing.Size(583, 56);
            this.txtDateTime.TabIndex = 2;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDateTime.Click += new System.EventHandler(this.gotFocus);
            // 
            // txtOrNumber
            // 
            this.txtOrNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtOrNumber, 2);
            this.txtOrNumber.Font = new System.Drawing.Font("Impact", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrNumber.Location = new System.Drawing.Point(250, 202);
            this.txtOrNumber.Margin = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.txtOrNumber.Name = "txtOrNumber";
            this.txtOrNumber.ReadOnly = true;
            this.txtOrNumber.Size = new System.Drawing.Size(292, 45);
            this.txtOrNumber.TabIndex = 4;
            this.txtOrNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrNumber.Click += new System.EventHandler(this.gotFocus);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // ttp
            // 
            this.ttp.BackColor = System.Drawing.Color.Black;
            this.ttp.ForeColor = System.Drawing.Color.White;
            this.ttp.ShowAlways = true;
            // 
            // frmPointOfSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPointOfSales";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frmPointOfSales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPointOfSales_FormClosed);
            this.Load += new System.EventHandler(this.pos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblProductInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cbxDiscount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.TextBox txtOrNumber;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVatPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.TextBox txtVatValue;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtInputCash;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrice;
        internal System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Button btnNew;
    }
}