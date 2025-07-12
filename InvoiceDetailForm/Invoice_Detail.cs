using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace InvoiceDetailForm
{
    public partial class Invoice_Detail : UserControl
    {
        public event EventHandler CancelClicked;
        public void UpdateTime(string time)
        {
            lblTime.Text += " " + time;
        }
        public void UpdateStoreName(string seller)
        {
            lblSeller.Text = seller;
        }
        public void UpdateTotalQuantity(string quantity)
        {
            lblTotalQuantity.Text = quantity;
        }
        public void UpdateTotalCost(string cost)
        {
            lblTotalCost.Text = cost;
        }
        public void UpdateInvoiceData(List<DatabaseAccess.InvoiceDetail> ids , Dictionary<string, string> prdIDToPrdName)
        {
            dgvInvoice.Rows.Clear();
            foreach (var item in ids)
            {
                string prdName = prdIDToPrdName[item.Product_ID];
                string quantity = item.InvoiceDetail_Quantity.ToString();
                string totalPrice = item.InvoiceDetail_TotalPrice.ToString("C2");
                string price = item.InvoiceDetail_UnitPrice.ToString("C2");
                dgvInvoice.Rows.Add(prdName, quantity, price, totalPrice);
            }
        }
        public Invoice_Detail()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing invoice...");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            CancelClicked.Invoke(this, EventArgs.Empty);
        }
    }
}

