using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPharmacy.File_Maintenance
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        List<DataLayer.Category> Categories = new List<DataLayer.Category>();
        DataLayer.Category perCategory = new DataLayer.Category();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadCategory()
        {
            Categories = DataLayer.getCategories();
            dgvCategories.Rows.Clear();
            foreach (DataLayer.Category perCategory in Categories)
            {
                dgvCategories.Rows.Add(perCategory.Name);
            }
            dgvCategories.ClearSelection();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtCategory.Clear();
            txtCategory.Select();
            perCategory = new DataLayer.Category();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            if (dgvCategories.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Category eachCategory in Categories)
                {
                    if (eachCategory.Name.Equals(dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString() + "' from Categories?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perCategory = eachCategory;
                            if (DataLayer.deleteCategory(perCategory))
                            {
                                DataLayer.showMessage("Deleted", "Category has been deleted.");
                                loadCategory();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected category.\nDeletion of category that contains a subcategory is not allowed.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perCategory.Name = txtCategory.Text;
            if (buttons == DataLayer.buttonClicked.add) 
            {
                if (DataLayer.insertCategory(perCategory))
                {
                    DataLayer.showMessage("Saved", "Category has been added.");
                    loadCategory();
                    txtCategory.Clear();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateCategory(perCategory))
                {
                    DataLayer.showMessage("Saved", "Category has been edited.");
                    loadCategory();
                    txtCategory.Clear();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
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
            if (dgvCategories.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Category eachCategory in Categories)
                {
                    if (eachCategory.Name.Equals(dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString()))
                    {
                        perCategory = eachCategory;
                        txtCategory.Text = perCategory.Name;
                        break;
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Category eachCategory in Categories)
                {
                    if (eachCategory.Name.Equals(dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString()))
                    {
                        perCategory = eachCategory;
                        txtCategory.Text = perCategory.Name;
                        break;
                    }
                }
            }
            else
            {
                perCategory = new DataLayer.Category();
                txtCategory.Clear();
            }
        }
    }
}
