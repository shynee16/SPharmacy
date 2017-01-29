using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPharmacy
{
    public partial class frmLogin : Form
    {
        List<DataLayer.User> Users = new List<DataLayer.User>();
        List<DataLayer.UserType> UserTypes = new List<DataLayer.UserType>();

        frmMain formMain;
        public frmLogin()
        {
            InitializeComponent();
            formMain = new frmMain(this);

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Users = DataLayer.getUsers();
            UserTypes = DataLayer.getUserTypes();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (DataLayer.login(txtUsername.Text, txtPassword.Text))
            {
                formMain.Show();
                this.Close();
            }
            else
            {
                DataLayer.showMessage("Login Failed", "Wrong username and password combination.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
