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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
        }

        List<DataLayer.Discount> Discounts = new List<DataLayer.Discount>();
        DataLayer.Discount perDiscount = new DataLayer.Discount();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadDiscount()
        {
            Discounts = DataLayer.getDiscounts();
            dgvDiscount.Rows.Clear();
            foreach (DataLayer.Discount perDiscount in Discounts)
            {
                dgvDiscount.Rows.Add(perDiscount.Name, perDiscount.Value);
            }
            dgvDiscount.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtDescription.Clear();
            txtDescription.Select();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            loadDiscount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || nudDiscount.Value == 0)
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perDiscount.Name = txtDescription.Text;
            perDiscount.Value = nudDiscount.Value;
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertDiscount(perDiscount))
                {
                    DataLayer.showMessage("Success", "Discount has been added.");
                    loadDiscount();
                    txtDescription.Clear();
                    nudDiscount.Value = 0;
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateDiscount(perDiscount))
                {
                    DataLayer.showMessage("Success", "Discount has been edited");
                    loadDiscount();
                    txtDescription.Clear();
                    nudDiscount.Value = 0;
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
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Discount eachDiscount in Discounts)
                {
                    if (eachDiscount.Name.Equals(dgvDiscount.SelectedRows[0].Cells["Description"].Value.ToString()))
                    {
                        perDiscount = eachDiscount;
                        txtDescription.Text = perDiscount.Name;
                        nudDiscount.Value = perDiscount.Value;
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
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Discount eachDiscount in Discounts)
                {
                    if (eachDiscount.Name.Equals(dgvDiscount.SelectedRows[0].Cells["Description"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvDiscount.SelectedRows[0].Cells["Description"].Value.ToString() + "' from Discounts?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perDiscount = eachDiscount;
                            if (DataLayer.deleteDiscount(perDiscount))
                            {
                                DataLayer.showMessage("Deleted", "Discount has been deleted.");
                                loadDiscount();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected discount.\nDeletion of discount that has been used in a transaction is not allowed.");
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

        private void dgvDiscount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Discount eachDiscount in Discounts)
                {
                    if (eachDiscount.Name.Equals(dgvDiscount.SelectedRows[0].Cells["Description"].Value.ToString()))
                    {
                        perDiscount = eachDiscount;
                        txtDescription.Text = perDiscount.Name;
                        nudDiscount.Value = perDiscount.Value;
                        break;
                    }
                }
            }
            else
            {
                perDiscount = new DataLayer.Discount();
                txtDescription.Clear();
                nudDiscount.Value = 0.00m;
            }
        }
    }
}
