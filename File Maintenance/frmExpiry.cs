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
    public partial class frmExpiry : Form
    {
        Selects.BrowseProducts BrowseProducts;
        public frmExpiry()
        {
            InitializeComponent();
            BrowseProducts = new Selects.BrowseProducts(this);
        }

        List<DataLayer.Expiration> Expirations = new List<DataLayer.Expiration>();
        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProducts = new DataLayer.Product();
        DataLayer.Expiration perExpiration = new DataLayer.Expiration();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadExpiry()
        {
            Expirations = DataLayer.getExpirations();
            dgvExpirations.Rows.Clear();
            Products = DataLayer.getProducts();
            foreach (DataLayer.Expiration perExpiration in Expirations)
            {
                foreach (DataLayer.Product perProduct in Products)
                {
                    if (perExpiration.Product == perProduct.ID)
                    {
                        dgvExpirations.Rows.Add(perProduct.Code, perProduct.ProductName, perExpiration.BatchNumber, perExpiration.Date.ToString("yyyy-MM-dd"));
                    }
                }
                dgvExpirations.ClearSelection();
            }
        }
        private void btnChooseProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtCode.Clear();
            txtBatchNumber.Clear();
            txtProductName.Clear();
            txtBatchNumber.Select();
            perExpiration = new DataLayer.Expiration();
        }

        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseProducts.ShowDialog();
        }
        internal void setProduct(DataLayer.Product inputProduct)
        {
            perProducts = inputProduct;
            txtCode.Text = perProducts.Code;
            txtProductName.Text = perProducts.ProductName;
            txtBatchNumber.Clear();
            dtpExpiration.Value = DateTime.Today.AddYears(1);
            txtBatchNumber.Select();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvExpirations.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Expiration eachExpiration in Expirations)
                {
                    if (eachExpiration.BatchNumber.Equals(dgvExpirations.SelectedRows[0].Cells["BatchNumber"].Value.ToString()))
                    {
                        txtBatchNumber.Text = eachExpiration.BatchNumber;
                        dtpExpiration.Value = eachExpiration.Date;
                        foreach (DataLayer.Product eachProduct in Products)
                        {
                            if (eachProduct.ID == eachExpiration.Product)
                            {
                                txtCode.Text = eachProduct.Code;
                                txtProductName.Text = eachProduct.ProductName;
                            }
                        }
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBatchNumber.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perExpiration.BatchNumber = txtBatchNumber.Text;
            perExpiration.Product = perProducts.ID;
            perExpiration.Date = dtpExpiration.Value;
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertExpiry(perExpiration))
                {
                    DataLayer.showMessage("Success", "Product Expiry has been added.");
                    loadExpiry();
                    txtCode.Clear();
                    txtBatchNumber.Clear();
                    txtProductName.Clear();
                    txtBatchNumber.Select();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateExpiry(perExpiration))
                {
                    DataLayer.showMessage("Success", "Product Expiry has been edited.");
                    loadExpiry();
                    txtCode.Clear();
                    txtBatchNumber.Clear();
                    txtProductName.Clear();
                    txtBatchNumber.Select();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpirations.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Expiration eachExpiration in Expirations)
                {
                    if (eachExpiration.BatchNumber.Equals(dgvExpirations.SelectedRows[0].Cells["BatchNumber"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvExpirations.SelectedRows[0].Cells["BatchNumber"].Value.ToString() + "' from Expirations?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perExpiration = eachExpiration;
                            if (DataLayer.deleteExpiry(perExpiration))
                            {
                                DataLayer.showMessage("Deleted", "Product expiration has been deleted.");
                                loadExpiry();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected unit.");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExpiry_Load(object sender, EventArgs e)
        {
            loadExpiry();
        }

        private void dgvExpirations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExpirations.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Expiration eachExpiration in Expirations)
                {
                    if (eachExpiration.BatchNumber.Equals(dgvExpirations.SelectedRows[0].Cells["BatchNumber"].Value.ToString()))
                    {
                        txtBatchNumber.Text = eachExpiration.BatchNumber;
                        dtpExpiration.Value = eachExpiration.Date;
                        foreach (DataLayer.Product eachProduct in Products)
                        {
                            if (eachProduct.ID == eachExpiration.Product)
                            {
                                txtCode.Text = eachProduct.Code;
                                txtProductName.Text = eachProduct.ProductName;
                            }
                        }
                    }
                }
            }
            else
            {
                txtBatchNumber.Clear();
                dtpExpiration.Value = DateTime.Today.AddYears(1);
                txtCode.Clear();
                txtProductName.Clear();
            }
        }
    }
}
