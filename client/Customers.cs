using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;
using static System.Windows.Forms.DataGridViewRow;
using static client.SignInForm;

namespace StoreClient
{
    public partial class Customers : Form
    {
        private List<DatabaseAccess.Customer> customers = new List<DatabaseAccess.Customer>();
        private List<DataGridViewRow> rowsSource = new List<DataGridViewRow>();
        private Dictionary<string, DatabaseAccess.Customer> customerDictionary = new Dictionary<string, DatabaseAccess.Customer>();
        private bool getData = false;
        public DatabaseAccess.Customer selectedCustomer { get; set; }
        public Customers()
        {
            InitializeComponent();
            FetchCustomersList(Session.StoreID);
            UpdateCustomerGridView();
        }
        public Customers(bool getData)
        {
            InitializeComponent();
            this.getData = getData;
            FetchCustomersList(Session.StoreID);
            UpdateCustomerGridView();
        }
        public void FetchCustomersList(string storeID)
        {
            customers = DatabaseAccess.GetCustomersByStoreID(storeID);
            rowsSource.Clear();
            foreach (var customer in customers)
            {
                customerDictionary[customer.Customer_ID] = customer;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(CustomerDataGridView);
                newRow.Cells[0].Value = customer.Customer_ID;
                newRow.Cells[1].Value = customer.Customer_Name;
                newRow.Cells[2].Value = customer.Customer_Phone;
                newRow.Cells[3].Value = customer.Customer_Email;
                newRow.Cells[4].Value = customer.Customer_Gender ? "Nữ" : "Nam";
                rowsSource.Add(newRow);
            }
        }
        private void UpdateCustomerGridView()
        {
            CustomerDataGridView.Rows.Clear();
            CustomerDataGridView.Rows.AddRange(rowsSource.ToArray());
            if (rowsSource.Count > 0)
            {
                CustomerDataGridView.CurrentCell = CustomerDataGridView.Rows[0].Cells[0]; // Set focus to the first cell
            }
        }
        private void CustomerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!getData) return; // If not in getData mode, do nothing
            var selectedRow = CustomerDataGridView.CurrentCell.OwningRow;
            if (selectedRow == null || selectedRow.IsNewRow) return;
            string customerId = selectedRow.Cells[0].Value.ToString();
            if (customerDictionary.TryGetValue(customerId, out var customer))
            {
                selectedCustomer = customer;
                this.DialogResult = DialogResult.OK; // Set dialog result to OK
                this.Close();
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            CustomerDataGridView_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, 0)); // Simulate double click on the first cell
        }

        private void addNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomerForm = new AddNewCustomer();
            addNewCustomerForm.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                        keyword == ""
                    )
                )
                .ToList();
            CustomerDataGridView.Rows.Clear();
            CustomerDataGridView.Rows.AddRange(filteredRows.ToArray());
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FetchCustomersList(Session.StoreID);
            UpdateCustomerGridView();
        }
    }
}
