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
    public partial class QuantityOrder : Form
    {
        Transactions.Purchase formPurchase;
        public QuantityOrder(Transactions.Purchase formParent)
        {
            InitializeComponent();
            formPurchase = formParent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value > 0)
            {
                formPurchase.addProductOrder(Convert.ToInt32(nudQuantity.Value));
                this.Close();
            }
            else
            {
                DataLayer.showMessage("Warning", "Quantity must be greater than 0.");
            }
        }

        private void QuantityOrder_Load(object sender, EventArgs e)
        {
            nudQuantity.Value = 0.00m;
        }
    }
}
