using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy.Selects
{
    public partial class ReceiveOrderedProducts : Form
    {
        Transactions.frmReceivePurchase formReceive;
        public ReceiveOrderedProducts(Transactions.frmReceivePurchase formParent)
        {
            InitializeComponent();
            formReceive = formParent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nudPrice.Value > 0 && nudQuantity.Value > 0)
            {
                formReceive.receiveProduct(Convert.ToInt32(nudQuantity.Value), nudPrice.Value);
                this.Close();
            }
            else
            {
                DataLayer.showMessage("Warning", "Quantity must be greater than 0.");
            }
        }

        private void ReceiveOrderedProducts_Load(object sender, EventArgs e)
        {
            nudPrice.Value = 0.00m;
            nudQuantity.Value = 0.00m;
        }
    }
}
