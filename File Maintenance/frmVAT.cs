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
    public partial class frmVAT : Form
    {
        public frmVAT()
        {
            InitializeComponent();
        }

        decimal VAT = new decimal();

        private void frmVAT_Load(object sender, EventArgs e)
        {
            loadVAT();
        }

        private void loadVAT()
        {
            VAT = DataLayer.getVAT();
            nudVat.Value = VAT;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudVat.Value == 0)
            {
                DataLayer.showMessage("Warning", "Saving of empty value is not allowed");
                return;
            }
            VAT = nudVat.Value;
            if (DataLayer.updateVAT(VAT))
            {
                DataLayer.showMessage("Success", "VAT has been saved.");
                loadVAT();
            }
            else
            {
                DataLayer.showMessage("Failed", "Check your input and try again.");
            }
            
        }
    }
}
