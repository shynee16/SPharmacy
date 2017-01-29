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
    public partial class Purchase : Form
    {
        Selects.QuantityOrder formQuantity;
        public Purchase()
        {
            InitializeComponent();
            formQuantity = new Selects.QuantityOrder(this);
        }

        List<DataLayer.Purchase> Purchases = new List<DataLayer.Purchase>();
        DataLayer.Purchase perPurchase = new DataLayer.Purchase();
        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();
        List<DataLayer.Supplier> Suppliers = new List<DataLayer.Supplier>();
        DataLayer.Supplier perSupplier = new DataLayer.Supplier();
        AutoCompleteStringCollection srcSupplier = new AutoCompleteStringCollection();

        private void btnNew_Click(object sender, EventArgs e)
        {
            setPOnumber();
            dtpDate.Value = DateTime.Now;
            txtSupplier.Clear();
            txtCPerson.Clear();
            dgvProductsOrder.Rows.Clear();
            dgvProductsSupplied.Rows.Clear();
        }

        private void loadSupplierProducts()
        {
            dgvProductsSupplied.Rows.Clear();
            Products = DataLayer.getProductsBySupplier(perSupplier);
            foreach (DataLayer.Product eachProduct in Products)
            {
                dgvProductsSupplied.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachProduct.Stocks);
            }
            dgvProductsSupplied.ClearSelection();
        }

        private void setPOnumber()
        {
            int po = DataLayer.getMax("purchase") + 1;
            txtOrderNumber.Text = po.ToString();
            while (txtOrderNumber.TextLength < 5)
            {
                txtOrderNumber.Text = "0" + txtOrderNumber.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "" || txtSupplier.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            bool result = false;
            perPurchase.Code = txtOrderNumber.Text;
            perPurchase.Date = dtpDate.Value;
            perPurchase.Supplier = perSupplier.ID;
            foreach (DataGridViewRow dgvRow in dgvProductsOrder.Rows)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["dgvCode"].Value.ToString()))
                    {
                        perPurchase.Product = eachProduct.ID;
                        perPurchase.Quantity = Convert.ToInt32(dgvRow.Cells["dgvQuantity"].Value);
                        if (DataLayer.insertPurchase(perPurchase))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            if (result)
            {
                DataLayer.showMessage("Success", "Purchase order has been save.");
                dtpDate.Value = DateTime.Now;
                txtOrderNumber.Clear();
                txtSupplier.Clear();
                txtCPerson.Clear();
                dgvProductsOrder.Rows.Clear();
                dgvProductsSupplied.Rows.Clear();
            }
            else
            {
                DataLayer.deletePurchase(perPurchase);
                DataLayer.showMessage("Failed", "Failed to save purchase order.\nPlease make sure Purchase Order # and Supplier is not empty.");
            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            Suppliers = DataLayer.getSupplier();
            Products = DataLayer.getProducts();
            foreach (DataLayer.Supplier eachSupplier in Suppliers)
            {
                srcSupplier.Add(eachSupplier.Name);
            }
            txtSupplier.AutoCompleteCustomSource = srcSupplier;
            dtpDate.Value = DateTime.Now;
        }

        internal void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvProductsSupplied.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvProductsSupplied.SelectedRows[0].Cells["Code"].Value.ToString()))
                    {
                        perProduct = eachProduct;
                    }
                }
                formQuantity.ShowDialog();
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }
        internal void addProductOrder(int quantity)
        {
            dgvProductsOrder.Rows.Add(perProduct.Code, perProduct.ProductName, quantity);
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            foreach (DataLayer.Supplier eachSupplier in Suppliers)
            {
                if (eachSupplier.Name.Equals(txtSupplier.Text))
                {
                    perSupplier = eachSupplier;
                }
            }
            if (perSupplier.ID != 0)
            {
                txtCPerson.Text = perSupplier.CPerson;
                loadSupplierProducts();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (dgvProductsOrder.SelectedRows.Count > 0)
            {
                dgvProductsOrder.Rows.Remove(dgvProductsOrder.SelectedRows[0]);
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        internal void dataFromAlert(DataLayer.Supplier inputSupplier)
        {
            setPOnumber();
            perSupplier = inputSupplier;
            txtSupplier.Text = perSupplier.Name;
            dtpDate.Value = DateTime.Today;
            loadSupplierProducts();
        }
    }
}
