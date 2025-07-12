using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;
namespace InvoiceDetailForm
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
            invoice_Detail1.UpdateTime(i.Invoice_Date.ToString("dd-MM-yyyy HH:mm:ss"));
            invoice_Detail1.UpdateStoreName(store.Store_Name);
            invoice_Detail1.UpdateTotalCost(i.Invoice_TotalAmount.ToString("C2"));
            invoice_Detail1.UpdateTotalQuantity(i.Invoice_TotalQuantity.ToString());
            invoice_Detail1.UpdateInvoiceData(invoiceDetails, prdToPrdName);
        }

        private void invoice_Detail1_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
