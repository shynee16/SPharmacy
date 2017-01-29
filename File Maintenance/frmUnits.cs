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
    public partial class frmUnits : Form
    {
        public frmUnits()
        {
            InitializeComponent();
        }

        List<DataLayer.Unit> Units = new List<DataLayer.Unit>();
        DataLayer.Unit perUnit = new DataLayer.Unit();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadUnit()
        {
            Units = DataLayer.getUnits();
            dgvUnits.Rows.Clear();
            foreach (DataLayer.Unit perUnit in Units)
            {
                dgvUnits.Rows.Add(perUnit.Name);
            }
            dgvUnits.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtUnit.Clear();
            txtUnit.Select();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            loadUnit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUnit.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perUnit.Name = txtUnit.Text;
            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertUnit(perUnit))
                {
                    DataLayer.showMessage("Success", "Unit has been added.");
                    loadUnit();
                    txtUnit.Clear();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateUnit(perUnit))
                {
                    DataLayer.showMessage("Success", "Unit has been edited.");
                    loadUnit();
                    txtUnit.Clear();
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
            if (dgvUnits.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Unit eachUnit in Units)
                {
                    if (eachUnit.Name.Equals(dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString()))
                    {
                        perUnit = eachUnit;
                        txtUnit.Text = perUnit.Name;
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
            if (dgvUnits.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Unit eachUnit in Units)
                {
                    if (eachUnit.Name.Equals(dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + eachUnit.Name + "' in Units?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perUnit = eachUnit;
                            if (DataLayer.deleteUnit(perUnit))
                            {
                                DataLayer.showMessage("Deleted", "Unit has been deleted.");
                                loadUnit();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected unit.\nDeletion of unit that is used in a product is not allowed.");
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

        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Unit eachUnit in Units)
                {
                    if (eachUnit.Name.Equals(dgvUnits.SelectedRows[0].Cells["UnitName"].Value.ToString()))
                    {
                        perUnit = eachUnit;
                        txtUnit.Text = perUnit.Name;
                        break;
                    }
                }
            }
            else
            {
                perUnit = new DataLayer.Unit();
                txtUnit.Clear();
            }
        }
    }
}
