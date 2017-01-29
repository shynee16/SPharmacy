using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy.Transactions
{
    public partial class frmPointOfSales : Form
    {
        receipt formReceipt;
        stockAlert formAlert;
        public frmPointOfSales()
        {
            InitializeComponent();
            formReceipt = new receipt(this);
            formAlert = new stockAlert(this);
        }

        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();
        List<DataLayer.Receipt> Receipts = new List<DataLayer.Receipt>();
        DataLayer.Receipt perReceipt = new DataLayer.Receipt();
        DataLayer.TransactionReceipt perTransactionReceipt = new DataLayer.TransactionReceipt();
        List<DataLayer.Discount> Discounts = new List<DataLayer.Discount>();
        DataLayer.Discount perDiscount = new DataLayer.Discount();
        decimal vat = 0.00m;
        decimal discount = 0.00m;
        int quantity = 1;
        int itemcount = 0;
        decimal subtotal = 0.00m;
        decimal total = 0.00m;
        decimal vatvalue = 0.00m;
        decimal discountvalue = 0.00m;
        decimal payment = -1.00m;

        private void updateNumbers()
        {
            itemcount = 0;
            subtotal = 0.00m;
            vatvalue = 0.00m;
            discountvalue = 0.00m;
            total = 0.00m;
            decimal unitPrice = 0.00m;
            foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
            {
                quantity = Convert.ToInt32(dgvRow.Cells["dgvQuantity"].Value);
                itemcount += quantity;
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["dgvCode"].Value.ToString()))
                    {
                        unitPrice = eachProduct.Price + (eachProduct.Price * (eachProduct.MarkUp / 100));
                        if (eachProduct.Vatable)
                        {
                            vatvalue += unitPrice * vat * quantity;
                        }
                        if (eachProduct.Discountable)
                        {
                            discountvalue += (unitPrice + (unitPrice * vat)) * discount * quantity;
                        }
                        subtotal += unitPrice * quantity;
                    }
                }
            }
            total = subtotal + vatvalue - discountvalue;
            txtTotalItems.Text = itemcount.ToString();
            txtSubtotal.Text = Math.Round(subtotal, 2).ToString();
            txtVatValue.Text = Math.Round(vatvalue, 2).ToString();
            txtDiscountValue.Text = Math.Round(discountvalue, 2).ToString();
            txtTotalDue.Text = Math.Round(total, 2).ToString();
        }

        private void addTransaction()
        {
            perProduct = new DataLayer.Product();
            foreach (DataLayer.Product eachProduct in Products)
            {
                if (eachProduct.Code.Equals(txtProductCode.Text))
                {
                    perProduct = eachProduct;
                }
            }
            quantity = Convert.ToInt32(nudQuantity.Value);
            if (perProduct.ID != 0)
            {
                if (dgvProducts.Rows.Count == 0)
                {
                    updateReceiptNumber();
                }
                dgvProducts.Rows.Add(perProduct.Code, perProduct.ProductName, perProduct.SellingPrice, quantity, perProduct.SellingPrice * quantity);
                dgvProducts.ClearSelection();
                txtProductCode.Clear();
                nudQuantity.Value = 1;
            }
            updateNumbers();
        }

        private void clearAll()
        {
            perProduct = new DataLayer.Product();
            perReceipt = new DataLayer.Receipt();
            perTransactionReceipt = new DataLayer.TransactionReceipt();
            perDiscount = new DataLayer.Discount();
            txtOrNumber.Clear();
            txtTotalItems.Text = "0";
            dgvProducts.Rows.Clear();
            cbxDiscount.SelectedIndex = 0;
            txtSubtotal.Text = "0.00";
            txtVatPercent.Text = vat * 100 + " %";
            txtVatValue.Text = "0.00";
            txtTotalDue.Text = "0.00";
            txtInputCash.Text = "0.00";
            txtCash.Text = "0.00";
            txtChange.Text = "0.00";
            txtProductCode.Select();
        }

        private void updateReceiptNumber()
        {
            int receiptnumber = DataLayer.getMax("receipts") + 1;
            if (receiptnumber <= 1)
            {
                receiptnumber = Convert.ToInt32(DataLayer.getReceiptNumber().Start) + 1;
                txtOrNumber.Text = receiptnumber.ToString();
            }
            else
            {
                txtOrNumber.Text = receiptnumber.ToString();
            }
            while (txtOrNumber.TextLength < 8)
            {
                txtOrNumber.Text = "0" + txtOrNumber.Text;
            }
        }

        private void loadDiscounts()
        {
            Discounts = DataLayer.getDiscounts();
            cbxDiscount.Items.Clear();
            cbxDiscount.Items.Add("None");
            foreach (DataLayer.Discount eachDiscount in Discounts)
            {
                cbxDiscount.Items.Add(eachDiscount.Name);
            }
            cbxDiscount.SelectedIndex = 0;
        }
        private void loadProducts()
        {
            Products = DataLayer.getProducts();
        }
        private void loadVAT()
        {
            vat = DataLayer.getVAT() / 100;
            txtVatPercent.Text = (vat*100) + " %";
        }

        private void pos_Load(object sender, EventArgs e)
        {
            tmrDateTime.Enabled = true;
            loadDiscounts();
            loadProducts();
            loadVAT();
            txtName.Text = DataLayer.currentUser.GivenName + " " + DataLayer.currentUser.LastName;
            txtPosition.Text = DataLayer.currentUserType.UserTypeName;
        }

        private void cbxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            perDiscount = new DataLayer.Discount();
            foreach (DataLayer.Discount eachDiscount in Discounts)
            {
                if (eachDiscount.Name.Equals(cbxDiscount.Text))
                {
                    perDiscount = eachDiscount;
                }
            }
            txtDiscountPercent.Text = perDiscount.Value.ToString() + " %";
            txtDiscountName.Text = perDiscount.Name;
            discount = perDiscount.Value / 100;
            updateNumbers();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            if (txtProductCode.Text != "")
            {
                addTransaction();
            }
            if (txtProductCode.TextLength > 16)
            {
                txtProductCode.Clear();
            }
        }

        private bool savedTransaction()
        {
            foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
            {
                perTransactionReceipt = new DataLayer.TransactionReceipt();
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["dgvCode"].Value.ToString()))
                    {
                        perTransactionReceipt.Receipt = perReceipt.ID;
                        perTransactionReceipt.Product = eachProduct.ID;
                        perTransactionReceipt.Quantity = Convert.ToInt32(dgvRow.Cells["dgvQuantity"].Value);
                        if (!DataLayer.insertTransactionReceipt(perTransactionReceipt))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool updateStock()
        {
            foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["dgvCode"].Value.ToString()))
                    {
                        int qty = Convert.ToInt32(dgvRow.Cells["dgvQuantity"].Value);
                        perProduct = eachProduct;
                        perProduct.Stocks = eachProduct.Stocks - qty;
                        if (!DataLayer.updateStock(perProduct))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void showReceipt()
        {
            formReceipt = new receipt(this);
            receipt.data miscdata = new receipt.data();
            miscdata.cash = txtCash.Text;
            miscdata.change = txtChange.Text;
            miscdata.discount = txtDiscountValue.Text;
            miscdata.subtotal = txtSubtotal.Text;
            miscdata.totalitems = txtTotalItems.Text;
            miscdata.vat = txtVatValue.Text;
            formReceipt.setData(perReceipt, miscdata, dgvProducts);
            formReceipt.Show();
        }

        private void txtInputCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                payment = Convert.ToDecimal(txtInputCash.Text);
                if (payment >= total)
                {
                    txtCash.Text = Math.Round(payment, 2).ToString();
                    txtChange.Text = Math.Round(payment - total, 2).ToString();
                }
                else
                {
                    txtCash.Text = "0.00";
                    txtChange.Text = "0.00";
                }
            }
            catch
            {
                txtInputCash.Clear();
                txtCash.Text = "0.00";
                txtChange.Text = "0.00";
            }
        }

        private void gotFocus(object sender, EventArgs e)
        {
            txtProductCode.Select();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close POS?", "Close POS?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataLayer.logout();
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtOrNumber.Text == "" || payment < total)
            {
                DataLayer.showMessage("Warning", "Please check if a transaction is available.");
                return;
            }
            perReceipt = new DataLayer.Receipt();
            perReceipt.Cashier = DataLayer.currentUser.ID;
            perReceipt.DateTime = DateTime.Now;
            perReceipt.Discount = perDiscount.ID;
            perReceipt.ReceiptNumber = txtOrNumber.Text;
            perReceipt.TotalDue = total;

            if (DataLayer.insertReceipt(perReceipt))
            {
                Receipts = DataLayer.getReceipts();
                foreach (DataLayer.Receipt eachReceipt in Receipts)
                {
                    if (eachReceipt.ReceiptNumber.Equals(perReceipt.ReceiptNumber))
                    {
                        perReceipt = eachReceipt;
                    }
                }
                if (perReceipt.ID != 0)
                {
                    if (updateStock() && savedTransaction())
                    {
                        showReceipt();
                        //DataLayer.showMessage("Saved!", "Transaction has been saved successfully.");
                        clearAll();
                    }
                    else
                    {
                        DataLayer.showMessage("Failed!", "Failed to save transaction.");
                    }
                }
            }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString("dd/MM/yy   HH:mm:ss");
        }

        private void frmPointOfSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAlert.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
