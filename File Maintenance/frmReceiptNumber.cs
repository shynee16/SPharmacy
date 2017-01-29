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
    public partial class frmReciptNumber : Form
    {
        public frmReciptNumber()
        {
            InitializeComponent();
        }

        DataLayer.ReceiptNumber perReceiptNumber = new DataLayer.ReceiptNumber();

        private void loadRN()
        {
            perReceiptNumber = DataLayer.getReceiptNumber();
            txtStart.Text = perReceiptNumber.Start;
            txtEnd.Text = perReceiptNumber.End;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReciptNumber_Load(object sender, EventArgs e)
        {
            loadRN();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtStart.Text);
                Convert.ToInt32(txtEnd.Text);
            }
            catch
            {
                DataLayer.showMessage("Warning", "Saving of empty or other than numeric value is not allowed");
                return;
            }
            perReceiptNumber.Start = txtStart.Text;
            perReceiptNumber.End = txtEnd.Text;
            if (DataLayer.updateReceiptNumber(perReceiptNumber))
            {
                DataLayer.showMessage("Saved", "ReceiptNumber has been edited.");
                loadRN();
            }
            else
            {
                DataLayer.showMessage("Failed", "Check your input and try again.");
            }
        }
    }
}
