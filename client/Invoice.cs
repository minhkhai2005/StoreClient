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
using static client.SignInForm;
using static System.Windows.Forms.DataGridViewRow;

namespace StoreClient
{
    public partial class Invoice : Form
    {
        List<DatabaseAccess.Invoice> invoices = new List<DatabaseAccess.Invoice>();
        List<DataGridViewRow> rowsSource = new List<DataGridViewRow>();
        public Invoice()
        {
            InitializeComponent();
        }
        private async void FetchInvoicesList()
        {
            await Task.Run(() => invoices = DatabaseAccess.GetInvoicesByStoreID(Session.StoreID));
            foreach (var invoice in invoices)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(InvoiceDataGridView);
                row.Cells[0].Value = invoice.Invoice_ID;
                row.Cells[1].Value = invoice.Employee_ID;
                row.Cells[2].Value = invoice.Customer_ID;
                row.Cells[3].Value = invoice.Invoice_TotalQuantity;
                row.Cells[4].Value = invoice.Invoice_TotalAmount;
                row.Cells[6].Value = invoice.Invoice_Status;
                row.Cells[5].Value = invoice.Invoice_Date.ToString("dd/MM/yyyy HH:mm:ss");
                rowsSource.Add(row);
            }
            UpdateInvoiceDataGridView();
        }
        private void UpdateInvoiceDataGridView()
        {
            InvoiceDataGridView.Rows.Clear();
            InvoiceDataGridView.Rows.AddRange(rowsSource.ToArray());
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string keyword = SearchTextBox.Text.ToLower();
            List<DataGridViewRow> filteredRows = rowsSource
                .Where(row =>
                    !row.IsNewRow && // Bỏ dòng trống
                    (
                        row.Cells[0].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[1].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[2].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[3].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[4].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[5].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[6].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[7].Value?.ToString().ToLower().Contains(keyword) == true ||
                        keyword == ""
                    )
                )
                .ToList();
            InvoiceDataGridView.Rows.Clear();
            InvoiceDataGridView.Rows.AddRange(filteredRows.ToArray());
        }

        private void Invoice_Shown(object sender, EventArgs e)
        {
            FetchInvoicesList();
        }
    }
}
