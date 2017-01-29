using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy
{
    public partial class stockAlert : Form
    {
        frmMain formMain;
        Transactions.frmPointOfSales formPOS;
        public stockAlert(Form formParent)
        {
            InitializeComponent();
            if (fromMain(formParent))
            {
                this.MdiParent = formMain;
            }
            fromPOS(formParent);
        }
        private bool fromMain(Form inputForm)
        {
            try
            {
                formMain = (frmMain)inputForm;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void fromPOS(Form inputForm)
        {
            try
            {
                formPOS = (Transactions.frmPointOfSales)inputForm;
            }
            catch { }
        }

        bool shown = false;
        bool disable = false;
        Point formLocation = new Point();
        Size formSize = new Size();

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (chkSession.Checked)
            {
                disable = true;
            }
            this.Hide();
            formSize = new Size(360, 60);
            this.Size = formSize;
            if (!this.IsMdiChild)
            {
                formLocation.Y = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
                this.Location = formLocation;
            }
            lblProducts.Hide();
            lblSuppliers.Hide();
            dgvProducts.Hide();
            dgvSuppliers.Hide();
            btnOK.Hide();
            btnClose.Hide();
            chkSession.Hide();
            btnShow.Text = "Show Details";
            shown = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!shown)
            {
                formSize = new Size(540, 320);
                lblProducts.Show();
                lblSuppliers.Show();
                dgvProducts.Show();
                dgvSuppliers.Show();
                if (this.IsMdiChild)
                {
                    btnOK.Show();
                }
                btnClose.Show();
                chkSession.Show();
                btnShow.Text = "Hide Details";
                this.Size = formSize;
                if (!this.IsMdiChild)
                {
                    formLocation.Y = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
                    this.Location = formLocation;
                }
                dgvProducts.ClearSelection();
                shown = true;
                lblStockAlert.BackColor = Color.Black;
                lblStockAlert.ForeColor = Color.White;
            }
            else
            {
                formSize = new Size(360, 60);
                lblProducts.Hide();
                lblSuppliers.Hide();
                dgvProducts.Hide();
                dgvSuppliers.Hide();
                btnOK.Hide();
                btnClose.Hide();
                chkSession.Hide();
                btnShow.Text = "Show Details";
                this.Size = formSize;
                if (!this.IsMdiChild)
                {
                    formLocation.Y = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
                    this.Location = formLocation;
                }
                shown = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Supplier eachSupplier in Suppliers)
                {
                    perSupplier = eachSupplier;
                    break;
                }
                Transactions.Purchase formPurchase = new Transactions.Purchase();
                formPurchase.dataFromAlert(perSupplier);
                formPurchase.MdiParent = formMain;
                formPurchase.Show();
                formSize = new Size(360, 60);
                lblProducts.Hide();
                lblSuppliers.Hide();
                dgvProducts.Hide();
                dgvSuppliers.Hide();
                btnOK.Hide();
                btnClose.Hide();
                chkSession.Hide();
                btnShow.Text = "Show Details";
                this.Size = formSize;
                if (!this.IsMdiChild)
                {
                    formLocation.Y = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
                    this.Location = formLocation;
                }
                shown = false;
            }
            else
            {
                DataLayer.showMessage("Warning", "Please select a supplier.");
            }
        }

        private void stockAlert_Load(object sender, EventArgs e)
        {
            formSize = new Size(360, 60);
            this.Size = formSize;
            if (!this.IsMdiChild)
            {
                formLocation.Y = Screen.PrimaryScreen.Bounds.Bottom - this.Size.Height;
                this.Location = formLocation;
            }
            lblProducts.Hide();
            lblSuppliers.Hide();
            dgvProducts.Hide();
            dgvSuppliers.Hide();
            btnOK.Hide();
            btnClose.Hide();
            chkSession.Hide();
            btnShow.Text = "Show Details";            
            shown = false;
        }

        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        List<DataLayer.Supplier> Suppliers = new List<DataLayer.Supplier>();
        DataLayer.Product perProduct = new DataLayer.Product();
        DataLayer.Supplier perSupplier = new DataLayer.Supplier();

        private void tmrAction_Tick(object sender, EventArgs e)
        {
            if (disable)
            {
                tmrAction.Enabled = false;
                return;
            }
            Products = DataLayer.getProducts();
            if (!shown)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Stocks <= eachProduct.ReOrderPoint)
                    {
                        alert();
                        this.Show();
                        if (!this.IsMdiChild)
                        {
                            formPOS.Activate();
                        }
                        return;
                    }
                }
                this.Hide();
            }
        }

        private void alert()
        {
            Products = DataLayer.getProducts();
            dgvProducts.Rows.Clear();
            foreach (DataLayer.Product eachProduct in Products)
            {
                if (eachProduct.Stocks <= eachProduct.ReOrderPoint)
                {
                    dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachProduct.Stocks);
                }
            }
            dgvProducts.ClearSelection();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvProducts.SelectedRows[0].Cells["Code"].Value.ToString()))
                    {
                        perProduct = eachProduct;
                        break;
                    }
                }
                Suppliers = DataLayer.getSuppliersByProduct(perProduct);
                dgvSuppliers.Rows.Clear();
                foreach (DataLayer.Supplier eachSupplier in Suppliers)
                {
                    dgvSuppliers.Rows.Add(eachSupplier.Code, eachSupplier.Name);
                }
                dgvSuppliers.ClearSelection();
            }
            else
            {
                dgvSuppliers.Rows.Clear();
            }
        }

        int timerColor;
        private void tmrAlert_Tick(object sender, EventArgs e)
        {
            if (!shown)
            {
                timerColor += 1;
                if (timerColor % 2 == 0)
                {
                    lblStockAlert.BackColor = Color.White;
                    lblStockAlert.ForeColor = Color.Black;
                    timerColor = 0;
                }
                else
                {
                    lblStockAlert.BackColor = Color.Black;
                    lblStockAlert.ForeColor = Color.White;
                }
            }
        }

    }
}
