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
    public partial class frmSubcategory : Form
    {
        public frmSubcategory()
        {
            InitializeComponent();
        }

        List<DataLayer.Category> Categories = new List<DataLayer.Category>();
        DataLayer.Category perCategory = new DataLayer.Category();
        List<DataLayer.Subcategory> Subcategories = new List<DataLayer.Subcategory>();
        DataLayer.Subcategory perSubcategory = new DataLayer.Subcategory();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadCategory()
        {
            Categories = DataLayer.getCategories();
            cbxCategories.Items.Clear();
            foreach (DataLayer.Category perCategory in Categories)
            {
                cbxCategories.Items.Add(perCategory.Name);
            }
            cbxCategories.SelectedIndex = -1;
        }

        private void loadSubcategory()
        {
            Subcategories = DataLayer.getSubcategories(perCategory);
            dgvSubcategory.Rows.Clear();
            foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
            {
                dgvSubcategory.Rows.Add(eachSubcategory.Name, eachSubcategory.MarkUp);
            }
            dgvSubcategory.ClearSelection();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubcategory.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perSubcategory.Name = txtSubcategory.Text;
            perSubcategory.Category = perCategory.ID;
            perSubcategory.MarkUp = nudMarkUp.Value;
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertSubcategory(perSubcategory))
                {
                    DataLayer.showMessage("Saved", "Subcategory has been added.");
                    loadSubcategory();
                    txtSubcategory.Clear();
                    nudMarkUp.Value = 0;
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check all inputs and choose the right category then try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateSubcategory(perSubcategory))
                {
                    DataLayer.showMessage("Saved!", "Subcategory has been edited.");
                    loadSubcategory();
                    txtSubcategory.Clear();
                    nudMarkUp.Value = 0;
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check all inputs and choose the right category then try again.");
                }
            }

        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DataLayer.Category eachCategory in Categories)
            {
                if (eachCategory.Name.Equals(cbxCategories.SelectedItem.ToString()))
                {
                    perCategory = eachCategory;
                    loadSubcategory();
                    break;
                }
            }
        }

        private void frmSubcategory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtSubcategory.Clear();
            nudMarkUp.Value = 0;
            txtSubcategory.Select();
            perSubcategory = new DataLayer.Subcategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubcategory.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Subcategory eachSubCategory in Subcategories)
                {
                    if (eachSubCategory.Name.Equals(dgvSubcategory.SelectedRows[0].Cells["SubCategory"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvSubcategory.SelectedRows[0].Cells["SubCategory"].Value.ToString() + "' from Subcategories?", "Delete",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perSubcategory = eachSubCategory;
                            if (DataLayer.deleteSubcategory(perSubcategory))
                            {
                                DataLayer.showMessage("Deleted", "Subcategory has been deleted.");
                                loadSubcategory();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected subcategory.\nDeletion of subcategory that contains a product is not allowed.");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvSubcategory.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
                {
                    if (eachSubcategory.Name.Equals(dgvSubcategory.SelectedRows[0].Cells["SubCategory"].Value.ToString()))
                    {
                        perSubcategory = eachSubcategory;
                        txtSubcategory.Text = perSubcategory.Name;
                        nudMarkUp.Value = perSubcategory.MarkUp;
                        break;
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void dgvSubcategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubcategory.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Subcategory eachSubcategory in Subcategories)
                {
                    if (eachSubcategory.Name.Equals(dgvSubcategory.SelectedRows[0].Cells["SubCategory"].Value.ToString()))
                    {
                        perSubcategory = eachSubcategory;
                        txtSubcategory.Text = perSubcategory.Name;
                        nudMarkUp.Value = perSubcategory.MarkUp;
                        break;
                    }
                }
            }
            else
            {
                perSubcategory = new DataLayer.Subcategory();
                txtSubcategory.Clear();
                nudMarkUp.Value = 0.00m;
            }
        }
    }
}
