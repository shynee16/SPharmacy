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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string caption, string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            lblTitle.Text = caption;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            
        }

    }
}
