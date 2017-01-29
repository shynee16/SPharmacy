using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy.Selects
{
    public partial class BrowseProducts : Form
    {
        File_Maintenance.frmExpiry formExpiry;
        File_Maintenance.frmSupplier formSupplier;
        public BrowseProducts(Form inputForm)
        {
            InitializeComponent();
            if (fromExpiry(inputForm))
            {
                formParent = fromForm.expiry;
            }
            if (fromSupplier(inputForm))
            {
                formParent = fromForm.supplier;
            }
        }

        enum fromForm { expiry, supplier }
        fromForm formParent = new fromForm();

        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();

        private bool fromExpiry(Form inputForm)
        {
            try
            {
                formExpiry = (File_Maintenance.frmExpiry)inputForm;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool fromSupplier(Form inputForm)
        {
            try
            {
                formSupplier = (File_Maintenance.frmSupplier)inputForm;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void loadProducts()
        {
            Products = DataLayer.getProducts();
            dgvProducts.Rows.Clear();
            foreach (DataLayer.Product eachProduct in Products)
            {
                dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName);
            }
            dgvProducts.ClearSelection();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvProducts.SelectedRows[0].Cells["ProductCode"].Value.ToString()))
                    {
                        perProduct = eachProduct;
                        if (formParent == fromForm.expiry)
                        {
                            formExpiry.setProduct(perProduct);
                        }
                        if (formParent == fromForm.supplier)
                        {
                            formSupplier.addProduct(perProduct);
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void BrowseProducts_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {
            Products = DataLayer.getProducts();
            dgvProducts.Rows.Clear();
            foreach (DataLayer.Product eachProduct in Products)
            {
                if (eachProduct.Code.Contains(txtSearch.Text) ||eachProduct.ProductName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName);
                }
            }
            dgvProducts.ClearSelection();
        }
    }
}
