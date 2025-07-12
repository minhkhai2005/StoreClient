using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace StoreClient
{
    public partial class InvoiceDetail : Form
    {
        private DatabaseAccess.Invoice i { get; set; }
        private List<DatabaseAccess.InvoiceDetail> invoiceDetails { get; set; }
        private DatabaseAccess.Store store { get; set; }
        private Dictionary<string, string> prdToPrdName { get; set; } = new Dictionary<string, string>();
        public InvoiceDetail()
        {
            InitializeComponent();
        }
        public InvoiceDetail(string invoiceID, string StoreID)
        {
            InitializeComponent();
            i = DatabaseAccess.Invoice.GetInvoiceByID(invoiceID);
            invoiceDetails = DatabaseAccess.InvoiceDetail.GetInvoiceDetailsByInvoiceID(i.Invoice_ID);
            this.store = DatabaseAccess.GetStoreByID(StoreID); // Fixed potential issue with uninitialized store
            foreach (var id in invoiceDetails)
            {
                var p = DatabaseAccess.Product.GetProductByID(id.Product_ID);
                prdToPrdName.Add(id.Product_ID, p.Product_Name);
            }
        }
        public void UpdateInfo()
        {
            TimeLabel.Text = i.Invoice_Date.ToString("dd-MM-yyyy HH:mm:ss");
            StoreLabel.Text = store.Store_Name;
            TotalPriceLabel.Text = i.Invoice_TotalAmount.ToString();
            TotalQuantityLabel.Text = i.Invoice_TotalQuantity.ToString();
            UpdateInvoiceData(invoiceDetails, prdToPrdName);
        }

        public void UpdateInvoiceData(List<DatabaseAccess.InvoiceDetail> ids, Dictionary<string, string> prdIDToPrdName)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ids)
            {
                string prdName = prdIDToPrdName[item.Product_ID];
                string quantity = item.InvoiceDetail_Quantity.ToString();
                string totalPrice = item.InvoiceDetail_TotalPrice.ToString();
                string price = item.InvoiceDetail_UnitPrice.ToString();
                dataGridView1.Rows.Add(prdName, price, quantity, totalPrice);
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceDetail_Shown(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
