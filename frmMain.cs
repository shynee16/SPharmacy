using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy
{
    public partial class frmMain : Form
    {
        frmLogin formLogin;
        stockAlert formStockAlert;
        public frmMain(frmLogin parent)
        {
            InitializeComponent();
            formLogin = parent;
            formStockAlert = new stockAlert(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmSuppliers_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Suppliers"))
            {
                File_Maintenance.frmSupplier formSupplier = new File_Maintenance.frmSupplier();
                formSupplier.MdiParent = this;
                formSupplier.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void tsmProducts_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Products"))
            {
                File_Maintenance.frmProducts formProducts = new File_Maintenance.frmProducts();
                formProducts.MdiParent = this;
                formProducts.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }

        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Discounts"))
            {
                File_Maintenance.frmDiscount formDiscount = new File_Maintenance.frmDiscount();
                formDiscount.MdiParent = this;
                formDiscount.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }

        }

        private void tsmUnit_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Units"))
            {
                File_Maintenance.frmUnits formUnits = new File_Maintenance.frmUnits();
                formUnits.MdiParent = this;
                formUnits.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }

        }

        private void tsmVats_Click(object sender, EventArgs e)
        {

        }

        private void userTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.Security.Contains("UserTypes"))
            {
                File_Maintenance.UserType formUserTypes = new File_Maintenance.UserType();
                formUserTypes.MdiParent = this;
                formUserTypes.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.Transactions.Contains("PurchaseOrders"))
            {
                Transactions.Purchase formPurchase = new Transactions.Purchase();
                formPurchase.MdiParent = this;
                formPurchase.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.Security.Contains("Users"))
            {
                File_Maintenance.frmUsers formUsers = new File_Maintenance.frmUsers();
                formUsers.MdiParent = this;
                formUsers.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }

        }

        private void tsmDiscount_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Discounts"))
            {
                File_Maintenance.frmDiscount formDiscounts = new File_Maintenance.frmDiscount();
                formDiscounts.MdiParent = this;
                formDiscounts.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MenuStrip.BackColor = Color.Indigo;
            MenuStrip.ForeColor = Color.White;
            lblUser.Text = "User: " + DataLayer.currentUser.GivenName + " " + DataLayer.currentUser.LastName;
            lblUsertype.Text = "Position: " + DataLayer.currentUserType.UserTypeName;
            tmrDateTime.Enabled = true;
        }
            
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Categories"))
            {
                File_Maintenance.frmCategory formCategory = new File_Maintenance.frmCategory();
                formCategory.MdiParent = this;
                formCategory.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void subCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Categories"))
            {
                File_Maintenance.frmSubcategory formSubcategory = new File_Maintenance.frmSubcategory();
                formSubcategory.MdiParent = this;
                formSubcategory.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void tsmUnit_Click_1(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Units"))
            {
                File_Maintenance.frmUnits formUnits = new File_Maintenance.frmUnits();
                formUnits.MdiParent = this;
                formUnits.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void tsmExpiration_Click_1(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("Expirations"))
            {
                File_Maintenance.frmExpiry formExpirations = new File_Maintenance.frmExpiry();
                formExpirations.MdiParent = this;
                formExpirations.Show();
            }
            else
            {
                MessageBox.Show("Access Denied.");
            }
        }

        private void receivePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.Transactions.Contains("ReceivePurchaseOrder"))
            {
                Transactions.frmReceivePurchase formReceivePO = new Transactions.frmReceivePurchase();
                formReceivePO.MdiParent = this;
                formReceivePO.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void tsmVats_Click_1(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("VAT"))
            {
                File_Maintenance.frmVAT formVAT = new File_Maintenance.frmVAT();
                formVAT.MdiParent = this;
                formVAT.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void receiptNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataLayer.currentUserType.FileMaintenance.Contains("ReceiptNumber"))
            {
                frmReciptNumber formRN = new frmReciptNumber();
                formRN.MdiParent = this; 
                formRN.Show();
            }
            else
            {
                DataLayer.showMessage("Access Denied", "You have no right to access this form.\nPlease refer to the Manager.");
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions.frmPointOfSales formPOS = new Transactions.frmPointOfSales();
            formPOS.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out of the system?", "System Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataLayer.logout();
                this.Close();
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            MdiClient control = null;
            foreach (var ctrl in this.Controls)
            {
                try
                {
                    control = (MdiClient)ctrl;
                    control.BackColor = Color.Black;
                }
                catch
                {

                }
            }
            frmLogo logo = new frmLogo();
            logo.MdiParent = this;
            logo.Show();
        }

        private void DropDownOpened(object sender, EventArgs e)
        {
            MenuStrip.ForeColor = Color.Black;
        }

        private void DropDownClosed(object sender, EventArgs e)
        {
            MenuStrip.ForeColor = Color.White;
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy   HH:mm:ss    dddd");
        }

    }
}
