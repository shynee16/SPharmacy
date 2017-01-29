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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        List<DataLayer.UserType> UserTypes = new List<DataLayer.UserType>();
        DataLayer.UserType perUserType = new DataLayer.UserType();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();

        private void loadUserTypes()
        {
            UserTypes = DataLayer.getUserTypes();
            dgvUserType.Rows.Clear();
            foreach (DataLayer.UserType eachUserType in UserTypes)
            {
                perUserType = eachUserType;
                dgvUserType.Rows.Add(perUserType.UserTypeName);
            }
            dgvUserType.ClearSelection();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            ClearAllchk();
            txtUserType.Clear();
            txtUserType.Select();
            perUserType = new DataLayer.UserType();
        }

        private void UserType_Load(object sender, EventArgs e)
        {
            loadUserTypes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvUserType.SelectedRows.Count > 0)
            {
                foreach (DataLayer.UserType eachUserType in UserTypes)
                {
                    if (eachUserType.UserTypeName.Equals(dgvUserType.SelectedRows[0].Cells["UsersType"].Value.ToString()))
                    {
                        perUserType = eachUserType;
                        txtUserType.Text = perUserType.UserTypeName;
                        loadUserType();
                        break;
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
            if (txtUserType.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perUserType.UserTypeName = txtUserType.Text;
            perUserType.FileMaintenance = "";
            perUserType.Transactions = "";
            perUserType.Security = "";
            if (chkCategories.Checked)
            {
                perUserType.FileMaintenance += "Categories";
            }
            if (chkDiscounts.Checked)
            {
                perUserType.FileMaintenance += "Discounts";
            }
            if (chkExpirations.Checked)
            {
                perUserType.FileMaintenance += "Expirations";
            }
            if (chkPointOfSales.Checked)
            {
                perUserType.Transactions += "PointOfSales";
            }
            if (chkProducts.Checked)
            {
                perUserType.FileMaintenance += "Products";
            }
            if (chkPurchaseOrders.Checked)
            {
                perUserType.Transactions += "PurchaseOrders";
            }
            if (chkReceiptNumber.Checked)
            {
                perUserType.FileMaintenance += "ReceiptNumber";
            }
            if (chkReceiveProducts.Checked)
            {
                perUserType.Transactions += "ReceivePurchaseOrder";
            }
            if (chkSuppliers.Checked)
            {
                perUserType.FileMaintenance += "Suppliers";
            }
            if (chkUnits.Checked)
            {
                perUserType.FileMaintenance += "Units";
            }
            if (chkUsers.Checked)
            {
                perUserType.Security += "Users";
            }
            if (chkUserTypes.Checked)
            {
                perUserType.Security += "UserTypes";
            }
            if (chkVAT.Checked)
            {
                perUserType.FileMaintenance += "VAT";
            }

            if (buttons == DataLayer.buttonClicked.add)
            {
                if (DataLayer.insertUserType(perUserType))
                {
                    DataLayer.showMessage("Success", "Usertype has been added.");
                    loadUserTypes();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            if (buttons == DataLayer.buttonClicked.edit)
            {
                if (DataLayer.updateUserType(perUserType))
                {
                    DataLayer.showMessage("Success", "Usertype has been edited.");
                    txtUserType.Clear();
                    ClearAllchk();
                    loadUserTypes();
                }
                else
                {
                    DataLayer.showMessage("Failed", "Check your input and try again.");
                }
            }
            
        }

        private void ClearAllchk()
        {
            chkCategories.Checked = false;
            chkDiscounts.Checked = false;
            chkExpirations.Checked = false;
            chkPointOfSales.Checked = false;
            chkProducts.Checked = false;
            chkPurchaseOrders.Checked = false;
            chkReceiptNumber.Checked = false;
            chkReceiveProducts.Checked = false;
            chkSuppliers.Checked = false;
            chkUnits.Checked = false;
            chkUsers.Checked = false;
            chkUserTypes.Checked = false;
            chkVAT.Checked = false;
        }
        private void loadUserType()
        {
            txtUserType.Text = perUserType.UserTypeName;
            ClearAllchk();
            if (perUserType.FileMaintenance.Contains("Categories"))
            {
                chkCategories.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("Discounts"))
            {
                chkDiscounts.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("Expirations"))
            {
                chkExpirations.Checked = true;
            }
            if (perUserType.Transactions.Contains("PointOfSales"))
            {
                chkPointOfSales.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("Products"))
            {
                chkProducts.Checked = true;
            }
            if (perUserType.Transactions.Contains("PurchaseOrders"))
            {
                chkPurchaseOrders.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("ReceiptNumber"))
            {
                chkReceiptNumber.Checked = true;
            }
            if (perUserType.Transactions.Contains("ReceivePurchaseOrder"))
            {
                chkReceiveProducts.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("Suppliers"))
            {
                chkSuppliers.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("Units"))
            {
                chkUnits.Checked = true;
            }
            if (perUserType.Security.Contains("Users"))
            {
                chkUsers.Checked = true;
            }
            if (perUserType.Security.Contains("UserTypes"))
            {
                chkUserTypes.Checked = true;
            }
            if (perUserType.FileMaintenance.Contains("VAT"))
            {
                chkVAT.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUserType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserType.SelectedRows.Count > 0)
            {
                foreach (DataLayer.UserType eachUserType in UserTypes)
                {
                    if (eachUserType.UserTypeName.Equals(dgvUserType.SelectedRows[0].Cells["UsersType"].Value.ToString()))
                    {
                        perUserType = eachUserType;
                        loadUserType();
                    }
                }
            }
            else
            {
                ClearAllchk();
                txtUserType.Clear();
            }
        }

    }
}
