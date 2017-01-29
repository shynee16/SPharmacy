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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        List<DataLayer.User> Users = new List<DataLayer.User>();
        DataLayer.User perUser = new DataLayer.User();
        DataLayer.buttonClicked buttons = new DataLayer.buttonClicked();
        List<DataLayer.UserType> UserTypes = new List<DataLayer.UserType>();
        DataLayer.UserType perUserType = new DataLayer.UserType();

        private void loadUsers()
        {
            UserTypes = DataLayer.getUserTypes();
            Users = DataLayer.getUsers();
            dgvUsers.Rows.Clear();
            foreach (DataLayer.User eachUser in Users)
            {
                foreach (DataLayer.UserType eachUserType in UserTypes)
                {
                    if (eachUserType.ID == eachUser.UserType)
                    {
                        dgvUsers.Rows.Add(eachUser.Username, eachUserType.UserTypeName, eachUser.GivenName, eachUser.LastName);
                    }
                }
            }
            dgvUsers.ClearSelection();
        }

        private void loadUserType()
        {
            UserTypes = DataLayer.getUserTypes();
            cbxUserType.Items.Clear();
            foreach (DataLayer.UserType perUserType in UserTypes)
            {
                cbxUserType.Items.Add(perUserType.UserTypeName);
            }
            cbxUserType.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.add;
            txtAddress.Clear();
            txtGivenName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
            txtVerifyPassword.Clear();
            txtUserName.Select();
            cbxUserType.SelectedIndex = -1;
            perUser = new DataLayer.User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "")
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            perUser.GivenName = txtGivenName.Text;
            perUser.Address = txtAddress.Text;
            perUser.LastName = txtLastName.Text;
            perUser.Password = txtPassword.Text;
            perUser.Username = txtUserName.Text;
            perUser.UserType = perUserType.ID;
            if (txtPassword.Text == txtVerifyPassword.Text)
            {
                if (buttons == DataLayer.buttonClicked.add)
                {
                    if (DataLayer.insertUser(perUser))
                    {
                        DataLayer.showMessage("Success", "User has been added.");
                        txtAddress.Clear();
                        txtGivenName.Clear();
                        txtLastName.Clear();
                        txtPassword.Clear();
                        txtUserName.Clear();
                        txtVerifyPassword.Clear();
                        cbxUserType.SelectedIndex = -1;
                        loadUsers();
                    }
                    else
                    {
                        DataLayer.showMessage("Failed", "Check your input, choose the right usertype, and make sure password is typed correctly then try again.");
                    }
                }
                if (buttons == DataLayer.buttonClicked.edit)
                {
                    if (DataLayer.updateUser(perUser))
                    {
                        DataLayer.showMessage("Success", "User has been edited.");
                        txtAddress.Clear();
                        txtGivenName.Clear();
                        txtLastName.Clear();
                        txtPassword.Clear();
                        txtUserName.Clear();
                        txtVerifyPassword.Clear();
                        cbxUserType.SelectedIndex = -1;
                        loadUsers();
                    }
                    else
                    {
                        DataLayer.showMessage("Failed", "Check your input, choose the right usertype, and make sure password is typed correctly then try again.");
                    }
                }
            }
            

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadUserType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttons = DataLayer.buttonClicked.edit;
            if (dgvUsers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.User eachUser in Users)
                {
                    if (eachUser.Username.Equals(dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString()))
                    {
                        perUser = eachUser;
                        txtAddress.Text = perUser.Address;
                        txtGivenName.Text = perUser.GivenName;
                        txtLastName.Text = perUser.LastName;
                        txtPassword.Text = perUser.Password;
                        txtUserName.Text = perUser.Username;
                        txtVerifyPassword.Text = perUser.Password;
                        foreach (DataLayer.UserType eachUsertype in UserTypes)
                        {
                            if (eachUsertype.ID == perUser.UserType)
                            {
                                cbxUserType.SelectedIndex = cbxUserType.FindStringExact (eachUsertype.UserTypeName);
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

        private void cbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataLayer.UserType eachUserType in UserTypes)
            {
                if (cbxUserType.SelectedIndex != -1 && eachUserType.UserTypeName.Equals(cbxUserType.SelectedItem.ToString()))
                {
                    perUserType = eachUserType;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.User eachUser in Users)
                {
                    if (eachUser.Username.Equals(dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString()))
                    {
                        if (MessageBox.Show("Are you sure you want to delete '" + dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString() + "' from Users?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            perUser = eachUser;
                            if (DataLayer.deleteUser(perUser) && perUser.Username != DataLayer.currentUser.Username)
                            {
                                DataLayer.showMessage("Deleted", "User has been deleted.");
                                loadUsers();
                            }
                            else
                            {
                                DataLayer.showMessage("Failed", "Failed to delete selected user.");
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

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                foreach (DataLayer.User eachUser in Users)
                {
                    if (eachUser.Username.Equals(dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString()))
                    {
                        perUser = eachUser;
                        txtAddress.Text = perUser.Address;
                        txtGivenName.Text = perUser.GivenName;
                        txtLastName.Text = perUser.LastName;
                        txtPassword.Text = perUser.Password;
                        txtUserName.Text = perUser.Username;
                        txtVerifyPassword.Text = perUser.Password;
                        foreach (DataLayer.UserType eachUsertype in UserTypes)
                        {
                            if (eachUsertype.ID == perUser.UserType)
                            {
                                cbxUserType.SelectedIndex = cbxUserType.FindStringExact(eachUsertype.UserTypeName);
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                perUser = new DataLayer.User();
                txtAddress.Clear();
                txtGivenName.Clear();
                txtLastName.Clear();
                txtPassword.Clear();
                txtUserName.Clear();
                txtVerifyPassword.Clear();
            }
        }
    }
}
