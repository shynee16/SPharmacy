using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPharmacy.Transactions
{
    public partial class frmReceivePurchase : Form
    {
        Selects.ReceiveOrderedProducts formQuantityPrice;
        public frmReceivePurchase()
        {
            InitializeComponent();
            formQuantityPrice = new Selects.ReceiveOrderedProducts(this);
        }

        List<DataLayer.Purchase> Purchases = new List<DataLayer.Purchase>();
        List<DataLayer.Receive> Receives = new List<DataLayer.Receive>();
        DataLayer.Receive perReceive = new DataLayer.Receive();
        List<DataLayer.Product> Products = new List<DataLayer.Product>();
        DataLayer.Product perProduct = new DataLayer.Product();
        List<DataLayer.Supplier> Suppliers = new List<DataLayer.Supplier>();
        string code = "";

        private void loadPO()
        {
            Purchases = DataLayer.getPurchase();
            Receives = DataLayer.getReceive();
            Suppliers = DataLayer.getSupplier();
            Products = DataLayer.getProducts();
            dgvPurchases.Rows.Clear();
            code = "";
            foreach (DataLayer.Purchase eachPurchase in Purchases)
            {
                if (!eachPurchase.Code.Equals(code))
                {
                    code = eachPurchase.Code;
                    if (chkPendingOnly.Checked)
                    {
                        bool received = false;
                        foreach (DataLayer.Receive eachReceive in Receives)
                        {
                            if (eachReceive.PurchaseCode == eachPurchase.Code)
                            {
                                received = true;
                            }
                        }
                        if (!received)
                        {
                            foreach (DataLayer.Supplier eachSupplier in Suppliers)
                            {
                                if (eachSupplier.ID == eachPurchase.Supplier)
                                {
                                    string purchaseCode = eachPurchase.Code;
                                    while (purchaseCode.Length < 5)
                                    {
                                        purchaseCode = "0" + purchaseCode;
                                    }
                                    dgvPurchases.Rows.Add(purchaseCode, eachSupplier.Name, eachPurchase.Date);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataLayer.Supplier eachSupplier in Suppliers)
                        {
                            if (eachSupplier.ID == eachPurchase.Supplier)
                            {
                                string purchaseCode = eachPurchase.Code;
                                while (purchaseCode.Length < 5)
                                {
                                    purchaseCode = "0" + purchaseCode;
                                }
                                dgvPurchases.Rows.Add(purchaseCode, eachSupplier.Name, eachPurchase.Date);
                            }
                        }
                        
                    }
                }
            }
            dgvPurchases.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceivePurchase_Load(object sender, EventArgs e)
        {
            loadPO();
        }

        private void chkPendingOnly_CheckedChanged(object sender, EventArgs e)
        {
            loadPO();
        }

        private void dgvPurchases_SelectionChanged(object sender, EventArgs e)
        {
            dgvOrderedProducts.Rows.Clear();
            dgvReceivedProducts.Rows.Clear();
            if (dgvPurchases.SelectedRows.Count > 0)
            {
                code = Convert.ToInt32(dgvPurchases.SelectedRows[0].Cells["poCode"].Value).ToString();
                foreach (DataLayer.Purchase eachPurchase in Purchases)
                {
                    if (eachPurchase.Code.Equals(code))
                    {
                        bool received = false;
                        foreach (DataLayer.Receive eachReceive in Receives)
                        {
                            if (eachReceive.PurchaseCode == eachPurchase.Code)
                            {
                                received = true;
                            }
                        }
                        foreach (DataLayer.Product eachProduct in Products)
                        {
                            if (eachProduct.ID == eachPurchase.Product)
                            {
                                dgvOrderedProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachPurchase.Quantity);
                            }
                        }
                        if (received)
                        {
                            foreach (DataLayer.Receive eachReceive in Receives)
                            {
                                if (eachReceive.PurchaseCode.Equals(eachPurchase.Code))
                                {
                                    foreach (DataLayer.Product eachProduct in Products)
                                    {
                                        if (eachProduct.ID == eachPurchase.Product)
                                        {
                                            dgvReceivedProducts.Rows.Add(eachProduct.Code, eachProduct.ProductName, eachReceive.Quantity, eachReceive.Price);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                dgvOrderedProducts.ClearSelection();
                dgvReceivedProducts.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvReceivedProducts.SelectedRows.Count > 0)
            {
                dgvReceivedProducts.Rows.Remove(dgvReceivedProducts.SelectedRows[0]);
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvOrderedProducts.SelectedRows.Count > 0)
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvOrderedProducts.SelectedRows[0].Cells["poProductCode"].Value.ToString()))
                    {
                        perProduct = eachProduct;
                        formQuantityPrice.ShowDialog();
                    }
                }
            }
            else
            {
                DataLayer.showMessage("Warning", "No selection done.");
            }
        }

        internal void receiveProduct(int inputQTY, decimal inputPrice)
        {
            dgvReceivedProducts.Rows.Add(perProduct.Code, perProduct.ProductName, inputQTY, inputPrice);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = false;
            foreach (DataGridViewRow dgvRow in dgvReceivedProducts.Rows)
            {
                perReceive = new DataLayer.Receive();
                perReceive.PurchaseCode = code;
                perReceive.Date = dtpDate.Value;
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["rpoProductCode"].Value.ToString()))
                    {
                        perReceive.Product = eachProduct.ID;
                    }
                }
                perReceive.Quantity = Convert.ToInt32(dgvRow.Cells["rpoQuantity"].Value);
                perReceive.Price = Convert.ToDecimal(dgvRow.Cells["rpoPrice"].Value);
                if (DataLayer.insertReceive(perReceive))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            if (result && updateStock())
            {
                DataLayer.showMessage("Success", "Purchase order has been save.");
                dtpDate.Value = DateTime.Now;
                loadPO();
            }
            else
            {
                DataLayer.deleteReceive(perReceive);
                DataLayer.showMessage("Failed", "Failed to save receive purchase order.\nPlease make sure correct Purchase Order is selected.");
            }
        }

        private bool updateStock()
        {
            foreach (DataGridViewRow dgvRow in dgvReceivedProducts.Rows) 
            {
                foreach (DataLayer.Product eachProduct in Products)
                {
                    if (eachProduct.Code.Equals(dgvRow.Cells["rpoProductCode"].Value.ToString()))
                    {
                        int qty = Convert.ToInt32(dgvRow.Cells["rpoQuantity"].Value);
                        perProduct = eachProduct;
                        perProduct.Stocks = eachProduct.Stocks + qty;
                        if (!DataLayer.updateStock(perProduct))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
