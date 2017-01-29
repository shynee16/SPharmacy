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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();
        List<DataLayer.Category> Categories = new List<DataLayer.Category>();
        DataLayer.Category perCategory = new DataLayer.Category();
        List<DataLayer.Subcategory> Subcategories = new List<DataLayer.Subcategory>();
        DataLayer.Subcategory perSubcategory = new DataLayer.Subcategory();
        List<DataLayer.Unit> Units = new List<DataLayer.Unit>();
        DataLayer.Unit perUnit = new DataLayer.Unit();

        private void loadProducts()
        {
            Products = DataLayer.getProductsByCategory(perCategory.ID, perSubcategory.ID);
            dgvProducts.Rows.Clear();

            foreach (DataLayer.Product eachProduct in Products)
            {
                dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachProduct.Price, eachProduct.SellingPrice);
            }
            dgvProducts.ClearSelection();
           
        }
        private void loadCategory()
        {
            Categories = DataLayer.getCategories();
            cbxCategories.Items.Clear();
            cbxCategories.Items.Add("All");
            foreach (DataLayer.Category perCategory in Categories)
            {
                cbxCategories.Items.Add(perCategory.Name);
            }
            cbxCategories.SelectedIndex = 0;
            loadSubcategory();
        }

        private void loadSubcategory()
        {
            Subcategories = DataLayer.getSubcategories(perCategory);
            cbxSubcategories.Items.Clear();
            cbxSubcategories.Items.Add("All");
            foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
            {
                cbxSubcategories.Items.Add(eachSubcategory.Name);
            }
            cbxSubcategories.SelectedIndex = 0;
            loadProducts();
        }

        private void loadUnit()
        {
            Units = DataLayer.getUnits();
            cbxUnit.Items.Clear();
            foreach (DataLayer.Unit eachUnit in Units)
            {
                cbxUnit.Items.Add(eachUnit.Name);
            }
            cbxUnit.SelectedIndex = -1;
        }

        private void updateSellingPrice()
        {
            decimal sellingPrice = 0;
            decimal price = nudPrice.Value;
            decimal markup = nudMarkUp.Value / 100;
            decimal vat = DataLayer.getVAT() / 100;
            sellingPrice = price + (price * markup);
            if (chkVat.Checked)
            {
                sellingPrice = sellingPrice + (sellingPrice * vat);
            }
            txtSellingPrice.Text = Math.Round(sellingPrice, 2).ToString();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

            loadCategory();
            loadUnit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtCode.Clear();
            txtGenericName.Clear();
            txtProductName.Clear();
            nudMarkUp.Value = perSubcategory.MarkUp;
            nudPrice.Value = 0;
            nudROP.Value = 0;
            txtSellingPrice.Text = "0.00";
            txtCode.Select();
            perProduct = new DataLayer.Product();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtProductName.Text == "" || nudPrice.Value == 0)
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perProduct.Code = txtCode.Text;
            perProduct.GenericName = txtGenericName.Text;
            perProduct.ProductName = txtProductName.Text;
            perProduct.MarkUp = nudMarkUp.Value;
            perProduct.Price = nudPrice.Value;
            perProduct.ReOrderPoint = Convert.ToInt32(nudROP.Value.ToString());
            perProduct.SellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            perProduct.Subcategory = perSubcategory.ID;
            perProduct.Unit = perUnit.ID;
            if (chkVat.Checked) 
            {
                perProduct.Vatable = true;
            }
            if (chkDiscountable.Checked)
            {
                perProduct.Discountable = true;
            }
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertProduct(perProduct))
                {
                    DataLayer.showMessage("Saved", "Product has been added.");
                    loadProducts();
                    txtCode.Clear();
                    txtGenericName.Clear();
                    txtProductName.Clear();
                    nudMarkUp.Value = 0;
                    nudPrice.Value = 0;
                    nudROP.Value = 0;
                    txtSellingPrice.Text = "0.00";
                    cbxUnit.SelectedIndex = -1;
                }
                else
                {
                    DataLayer.showMessage("Failed!", "Check all inputs and choose the right category and subcategory then try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateProduct(perProduct))
                {
                    DataLayer.showMessage("Saved", "Product has been edited.");
                    loadProducts();
                    txtCode.Clear();
                    txtGenericName.Clear();
                    txtProductName.Clear();
                    nudMarkUp.Value = 0;
                    nudPrice.Value = 0;
                    nudROP.Value = 0;
                    txtSellingPrice.Text = "0.00";
                    cbxUnit.SelectedIndex = -1;
                }
                else
                {
                    DataLayer.showMessage("Failed!", "Check all inputs and choose the right category and subcategory then try again.");
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvProducts.SelectedRows[0].Cells["Code"].Value.ToString()))
                    {
                        txtCode.Text = eachProduct.Code;
                        txtGenericName.Text = eachProduct.GenericName;
                        txtProductName.Text = eachProduct.ProductName;
                        nudMarkUp.Value = eachProduct.MarkUp;
                        nudPrice.Value = eachProduct.Price;
                        nudROP.Value = eachProduct.ReOrderPoint;
                        if (eachProduct.Vatable)
                        {
                            chkVat.Checked = true;
                        }
                        if (eachProduct.Discountable)
                        {
                            chkDiscountable.Checked = true;
                        }
                        foreach (DataLayer.Unit eachUnit in Units)
                        {
                            if (eachUnit.ID == eachProduct.Unit)
                            {
                                cbxUnit.SelectedIndex = cbxUnit.FindStringExact(eachUnit.Name);
                            }
                        }

                        foreach (DataLayer.Category eachCategory in Categories)
                        {
                            Subcategories = DataLayer.getSubcategories(eachCategory);
                            foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
                            {
                                if (eachSubcategory.ID == eachProduct.Subcategory && eachSubcategory.Category == eachCategory.ID)
                                {
                                    cbxCategories.SelectedIndex = cbxCategories.FindStringExact(eachCategory.Name);
                                    cbxSubcategories.SelectedIndex = cbxSubcategories.FindStringExact(eachSubcategory.Name);
                                    
                                }
                            }
                        }
                        foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
                        {
                            if (eachProduct.Code.Equals(dgvRow.Cells["Code"].Value.ToString()))
                            {
                                dgvProducts.CurrentCell = dgvRow.Cells["ProName"];
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Products = DataLayer.getProductsByCategory(perCategory.ID, perSubcategory.ID);
            dgvProducts.Rows.Clear();
            foreach (DataLayer.Product eachProduct in Products)
            {
                if (eachProduct.Code.Contains(txtSearch.Text) ||eachProduct.ProductName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    dgvProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachProduct.Price, eachProduct.SellingPrice);
                }
            }
            dgvProducts.ClearSelection();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            perCategory = new DataLayer.Category();
            foreach (DataLayer.Category eachCategory in Categories)
            {
                if (eachCategory.Name.Equals(cbxCategories.SelectedItem.ToString()))
                {
                    perCategory = eachCategory;
                    break;
                }
            }
            loadSubcategory();
        }

        private void cbxSubcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            perSubcategory = new DataLayer.Subcategory();
            foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
            {
                if (eachSubcategory.Name.Equals(cbxSubcategories.SelectedItem.ToString()))
                {
                    perSubcategory = eachSubcategory;
                    break;
                }
            }
            loadProducts();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            updateSellingPrice();
        }

        private void nudMarkUp_ValueChanged(object sender, EventArgs e)
        {
            updateSellingPrice();
        }

        private void chkVat_CheckedChanged(object sender, EventArgs e)
        {
            updateSellingPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvProducts.SelectedRows[0].Cells["Code"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvProducts.SelectedRows[0].Cells["ProName"].Value.ToString() + "' from Products?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perProduct = eachProduct;
                            if (DataLayer.deleteProduct(perProduct))
                            {
                                DataLayer.showMessage("Deleted", "Category has been deleted.");
                                loadProducts();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected product.\nDeletion of product that has been used in a transaction is not allowed.");
                            }
                            break;
                        }
                    }
                }
                loadProducts();
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataLayer.Unit eachUnit in Units)
            {
                if (eachUnit.Name.Equals(cbxUnit.Text))
                {
                    perUnit = eachUnit;
                }
            }
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
                        txtCode.Text = perProduct.Code;
                        txtGenericName.Text = perProduct.GenericName;
                        txtProductName.Text = perProduct.ProductName;
                        nudMarkUp.Value = perProduct.MarkUp;
                        nudPrice.Value = perProduct.Price;
                        nudROP.Value = perProduct.ReOrderPoint;
                        if (perProduct.Vatable)
                        {
                            chkVat.Checked = true;
                        }
                        if (perProduct.Discountable)
                        {
                            chkDiscountable.Checked = true;
                        }
                        foreach (DataLayer.Unit eachUnit in Units)
                        {
                            if (eachUnit.ID == perProduct.Unit)
                            {
                                cbxUnit.SelectedIndex = cbxUnit.FindStringExact(eachUnit.Name);
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                perProduct = new DataLayer.Product();
                txtCode.Clear();
                txtGenericName.Clear();
                txtProductName.Clear();
                nudMarkUp.Value = 0.00m;
                nudPrice.Value = 0.00m;
                nudROP.Value = 0.00m;
                chkVat.Checked = false;
                chkDiscountable.Checked = false;
                cbxUnit.SelectedIndex = -1;
            }
        }
    }
}
