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
    public partial class receipt : Form
    {
        Transactions.frmPointOfSales formPOS;
        public receipt(Transactions.frmPointOfSales formParent)
        {
            InitializeComponent();
            formPOS = formParent;
        }
        internal struct data
        {
            internal string totalitems;
            internal string subtotal;
            internal string vat;
            internal string discount;
            internal string cash;
            internal string change;
        }

        DataLayer.Receipt dataReceipt = new DataLayer.Receipt();
        data miscData = new data();
        DataGridView dgv = new DataGridView();

        internal void setData(DataLayer.Receipt inputReceipt, data inputData, DataGridView inputDgv)
        {
            dataReceipt = inputReceipt;
            miscData = inputData;
            dgv = inputDgv;
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                pnlItems.Controls.Add(addValue(dgvRow));
                pnlItems.Controls.Add(addDescription(dgvRow));
            }
            lblDate.Text = dataReceipt.DateTime.ToString("dd/MM/yy HH:mm:ss");
            lblCashier.Text = "Cashier: " + DataLayer.currentUser.GivenName + " " + DataLayer.currentUser.LastName;
            lblReceipt.Text = "OR: " + dataReceipt.ReceiptNumber;
            lblTotalItems.Text = miscData.totalitems;
            lblSubTotal.Text = miscData.subtotal;
            lblVAT.Text = miscData.vat;
            lblDiscount.Text = miscData.discount;
            lblTotalDue.Text = dataReceipt.TotalDue.ToString();
            lblCash.Text = miscData.cash;
            lblChange.Text = miscData.change;
        }

        private Label addDescription(DataGridViewRow inputRow)
        {
            Label label = new Label();
            label.Dock = DockStyle.Top;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Text = inputRow.Cells["dgvCode"].Value.ToString() + "     " + inputRow.Cells["dgvProductName"].Value.ToString();
            return label;
        }

        private Label addValue(DataGridViewRow inputRow)
        {
            Label label = new Label();
            label.Dock = DockStyle.Top;
            label.TextAlign = ContentAlignment.MiddleRight;
            string qty = "";
            if (Convert.ToInt32(inputRow.Cells["dgvQuantity"].Value) > 1) {
                qty = inputRow.Cells["dgvQuantity"].Value.ToString() + "pcs      ";
            }
            else
            {
                qty = inputRow.Cells["dgvQuantity"].Value.ToString() + "pc      ";
            }
            label.Text = inputRow.Cells["dgvUnitPrice"].Value.ToString() + "     " + qty + inputRow.Cells["dgvTotalPrice"].Value.ToString();
            return label;
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}