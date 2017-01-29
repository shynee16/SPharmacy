using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy.File_Maintenance
{
    public partial class frmSupplier : Form
    {
        Selects.BrowseProducts formProducts;
        public frmSupplier()
        {
            InitializeComponent();
            formProducts = new Selects.BrowseProducts(this);
        }

        List<DataLayer.Supplier> Suppliers = new List<DataLayer.Supplier>();
        DataLayer.Supplier perSupplier = new DataLayer.Supplier();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();
        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();

        private void loadProducts()
        {
            Products = DataLayer.getProductsBySupplier(perSupplier);
            dgvProducts.Rows.Clear();
            foreach (DataLayer.Product eachProduct in Products)
            {
                dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName);
            }
            dgvProducts.ClearSelection();
        }

        internal void addProduct(DataLayer.Product inputProduct)
        {
            perProduct = inputProduct;
            dgvProducts.Rows.Add(perProduct.Code, perProduct.ProductName);
        }

        private void loadSupplier()
        {
            Suppliers = DataLayer.getSupplier();
            dgvSuppliers.Rows.Clear();
            foreach (DataLayer.Supplier eachSupplier in Suppliers)
            {
                string supplierCode = eachSupplier.Code;
                while (supplierCode.Length < 5)
                {
                    supplierCode = "0" + supplierCode;
                }
                dgvSuppliers.Rows.Add(supplierCode, eachSupplier.Name, eachSupplier.CPerson, eachSupplier.CNumber);
            }
            dgvSuppliers.ClearSelection();
        }

        private void setCode()
        {
            int po = DataLayer.getMax("suppliers") + 1;
            txtCode.Text = po.ToString();
            while (txtCode.TextLength < 5)
            {
                txtCode.Text = "0" + txtCode.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            clearAll();
            setCode();
            txtName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perSupplier.Code = txtCode.Text;
            perSupplier.Name = txtName.Text;
            perSupplier.CPerson = txtContactPerson.Text;
            perSupplier.CNumber = txtContact.Text;
            perSupplier.TelNum = txtTelephone.Text;
            perSupplier.Address = txtAddress.Text;
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertSupplier(perSupplier) && saveSuppliersProducts())
                {
                    DataLayer.showMessage("Saved", "Supplier has been added.");
                    loadSupplier();
                    clearAll();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateSupplier(perSupplier) && saveSuppliersProducts())
                {
                    DataLayer.showMessage("Saved", "Supplier has been edited.");
                    loadSupplier();
                    clearAll();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }

        }

        private bool saveSuppliersProducts()
        {
            if (!DataLayer.deleteSupplierProducts(perSupplier))
            {
                return false;
            }
            foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
            {
                Products = DataLayer.getProducts();
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["dgvProductCode"].Value.ToString()))
                    {
                        if (!DataLayer.insertSuppliersProducts(perSupplier, eachProduct))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void clearAll()
        {
            txtCode.Clear();
            txtName.Clear();
            txtContactPerson.Clear();
            txtTelephone.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            dgvProducts.Rows.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            loadSupplier();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Suppliers = DataLayer.getSupplier();
            dgvSuppliers.Rows.Clear();
            foreach (DataLayer.Supplier eachSupplier in Suppliers)
            {
                if (eachSupplier.Code.Contains(txtSearch.Text) || eachSupplier.Name.ToLower().Contains(txtSearch.Text.ToLower()) || eachSupplier.CPerson.ToLower().Contains(txtSearch.Text.ToLower()) || eachSupplier.CNumber.Contains(txtSearch.Text))
                {
                    dgvSuppliers.Rows.Add(eachSupplier.Code, eachSupplier.Name, eachSupplier.CPerson, eachSupplier.CNumber);
                }
            }
            dgvSuppliers.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Supplier eachSupplier in Suppliers)
                {
                    if (eachSupplier.Code.Equals(Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["Code"].Value).ToString()))
                    {
                        perSupplier = eachSupplier;
                        txtName.Text = perSupplier.Name;
                        txtCode.Text = perSupplier.Code;
                        while (txtCode.TextLength < 5)
                        {
                            txtCode.Text = "0" + txtCode.Text;
                        }
                        txtTelephone.Text = perSupplier.TelNum;
                        txtContactPerson.Text = perSupplier.CPerson;
                        txtContact.Text = perSupplier.CNumber;
                        txtAddress.Text = perSupplier.Address;
                        break;
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Supplier eachSupplier in Suppliers)
                {
                    if (eachSupplier.Name.Equals(dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString() + "' from Suppliers?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perSupplier = eachSupplier;
                            if (DataLayer.deleteSupplier(eachSupplier))
                            {
                                DataLayer.showMessage("Deleted", "Supplier has been deleted.");
                                loadSupplier();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected supplier.\nDeletion of supplier that is linked to a product is not allowed.");
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Supplier eachSupplier in Suppliers)
                {
                    if (eachSupplier.Code.Equals(Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["Code"].Value).ToString()))
                    {
                        perSupplier = eachSupplier;
                        txtName.Text = perSupplier.Name;
                        txtCode.Text = perSupplier.Code;
                        while (txtCode.TextLength < 5)
                        {
                            txtCode.Text = "0" + txtCode.Text;
                        }
                        txtTelephone.Text = perSupplier.TelNum;
                        txtContactPerson.Text = perSupplier.CPerson;
                        txtContact.Text = perSupplier.CNumber;
                        txtAddress.Text = perSupplier.Address;
                        loadProducts();
                    }
                }
            }
            else
            {
                clearAll();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            formProducts.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                dgvProducts.Rows.Remove(dgvProducts.SelectedRows[0]);
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }
    }
}
  
