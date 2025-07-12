using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DatabaseClass;
using Authentication;
using static client.SignInForm;
using StoreClient;
using static System.Windows.Forms.DataGridViewRow;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;

namespace client
{
    public partial class Home : Form
    {
        public DatabaseAccess.Store store;
        private List<DatabaseAccess.Inventory> inventoryList = new List<DatabaseAccess.Inventory>();
        private List<DatabaseAccess.Product> productList = new List<DatabaseAccess.Product>();
        private Dictionary<string, DatabaseAccess.Product> productDictionary = new Dictionary<string, DatabaseAccess.Product>();
        private Dictionary<string, int> temporaryInvoiceDetails = new Dictionary<string, int>();
        private List<DataGridViewRow> rowsSource = new List<DataGridViewRow>();
        private List<DatabaseAccess.Employee> employees = new List<DatabaseAccess.Employee>();
        private List<DatabaseAccess.Employee> onDutyEmployee = new List<DatabaseAccess.Employee>();
        double total = 0;
        private System.Windows.Forms.Timer chatTimer;
        // Thêm biến lưu tên manager (giả sử truyền vào khi khởi tạo hoặc hardcode tạm)
        private string managerName = "Quản lý"; // Có thể truyền từ ngoài vào hoặc lấy từ API
        public Home()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
            EmployeeComboBox.DataSource = onDutyEmployee;
            EmployeeComboBox.DisplayMember = "Employee_Name";
            EmployeeComboBox.ValueMember = "Employee_ID";
            button1.Click += button1_Click;
            // Tự động load chat khi mở form
            this.tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // Khởi tạo timer cập nhật chat
            chatTimer = new System.Windows.Forms.Timer();
            chatTimer.Interval = 2000; // 2 giây
            chatTimer.Tick += chatTimer_Tick;
        }
        private void FetchData()
        {
            inventoryList = DatabaseAccess.GetInventoriesByStoreID(store.Store_ID);
            productList = DatabaseAccess.GetProductsByStoreID(store.Store_ID);
            employees = DatabaseAccess.GetEmployeesByStoreID(store.Store_ID);
        }
        private void FetchOnDutyEmployee()
        {
            onDutyEmployee.Clear();
            onDutyEmployee = DatabaseAccess.GetOnDutyEmployee(store.Store_ID);
        }
        private async void Home_Load(object sender, EventArgs e)
        {
            FetchData();
            // build product dictionary
            foreach (var product in productList)
            {
                productDictionary[product.Product_ID] = product;
            }

            // build inventory dictionary
            foreach (var inventory in inventoryList)
            {
                var product = productDictionary[inventory.Product_ID];
                if (product != null)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    if (inventory.Inventory_Status)
                    {
                        newRow.CreateCells(AvailableProductDataGridView);
                        newRow.Cells[0].Value = product.Product_ID;
                        newRow.Cells[1].Value = product.Product_Name;
                        newRow.Cells[2].Value = product.Product_Price.ToString();
                        // add to rows source
                        rowsSource.Add(newRow);
                    }
                }
            }
            AvailableProductDataGridView.Rows.Clear();
            AvailableProductDataGridView.Rows.AddRange(rowsSource.ToArray());
            // Gọi load chat ngay khi vào form
            await LoadChatHistory();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void InvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Show();
        }

        private async void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            await Task.Run(() => nhanVien.FetchEmployeesList(store.Store_ID));
            nhanVien.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.inventoryList = inventoryList;
            inventory.productDictionary = productDictionary;
            inventory.UpdateData();
            inventory.ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInForm loginForm = new SignInForm();
            loginForm.Show();
            this.Hide();
        }

        private void CloseStatusMenu_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Xác nhận đóng cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                store.Store_Status = false;
                Task.Run(() => store.UpdateStore());
                CloseStatusMenu.Checked = true;
                OpenStatusMenu.Checked = false;
            }
        }

        private void OpenStatusMenu_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Xác nhận mở cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                store.Store_Status = true;
                Task.Run(() => store.UpdateStore());
                CloseStatusMenu.Checked = false;
                OpenStatusMenu.Checked = true;
            }
        }

        private void StartShift_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift(true);
            shift.ShowDialog();
        }

        private void EndShift_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift(false);
            shift.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddInvoiceDetail();
        }
        private void AddInvoiceDetail()
        {
            var selectedRow = AvailableProductDataGridView.CurrentCell.OwningRow;
            if (selectedRow == null) return;
            string productId = selectedRow.Cells[0].Value.ToString();
            if (!temporaryInvoiceDetails.ContainsKey(productId))
            {
                temporaryInvoiceDetails[productId] = 0;
            }
            temporaryInvoiceDetails[productId] += (int)numericUpDown1.Value;
            RefreshInvoiceDetail();
        }
        private void RefreshInvoiceDetail()
        {
            InvoiceDetailDataGridView.Rows.Clear();
            foreach (var item in temporaryInvoiceDetails)
            {
                if (productDictionary.TryGetValue(item.Key, out var product))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(InvoiceDetailDataGridView);
                    row.Cells[0].Value = product.Product_ID;
                    row.Cells[1].Value = product.Product_Name;
                    row.Cells[2].Value = product.Product_Price;
                    row.Cells[3].Value = item.Value;
                    row.Cells[4].Value = product.Product_Price * item.Value;
                    InvoiceDetailDataGridView.Rows.Add(row);
                }
            }
            total = 0;
            foreach (var item in temporaryInvoiceDetails)
            {
                if (productDictionary.TryGetValue(item.Key, out var product))
                {
                    total += product.Product_Price * item.Value;
                }
            }
            TotalLabel.Text = total.ToString();
        }

        private void AvailableProductDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddInvoiceDetail();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {

            string keyword = searchTextBox.Text.ToLower();
            List<DataGridViewRow> filteredRows = rowsSource
                .Where(row =>
                    !row.IsNewRow && // Bỏ dòng trống
                    (
                        row.Cells[1].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[0].Value?.ToString().ToLower().Contains(keyword) == true ||
                        keyword == ""
                    )
                )
                .ToList();
            AvailableProductDataGridView.Rows.Clear();
            AvailableProductDataGridView.Rows.AddRange(filteredRows.ToArray());
        }
        private void RemoveInvoiceDetail()
        {
            try
            {
                var selectedRow = InvoiceDetailDataGridView.CurrentCell.OwningRow;
                if (selectedRow == null) return;
                string productId = selectedRow.Cells[0].Value.ToString();
                temporaryInvoiceDetails.Remove(productId);
                RefreshInvoiceDetail();
            }
            catch
            {
                return;
            }
           
        }
        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            RemoveInvoiceDetail();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            temporaryInvoiceDetails.Clear();
            InvoiceDetailDataGridView.Rows.Clear();
            TotalLabel.Text = "0";
            numericUpDown1.Value = 1;
            total = 0;
        }

        private async void payBtn_Click(object sender, EventArgs e)
        {
            // ask user to confirm
            var r = MessageBox.Show("Xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                return;
            }
            // check if there are any products in the invoice
            if (temporaryInvoiceDetails.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check responsible employee
            if (EmployeeComboBox.SelectedItem == null || EmployeeComboBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên phụ trách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // new invoice 
            DatabaseAccess.Invoice newInvoice = new DatabaseAccess.Invoice();
            newInvoice.Invoice_ID = GenerateRandomCode();
            newInvoice.Employee_ID = EmployeeComboBox.SelectedValue.ToString();
            newInvoice.Invoice_TotalAmount = 0;
            newInvoice.Invoice_TotalQuantity = 0;
            newInvoice.Invoice_Date = DateTime.Now;
            newInvoice.Invoice_Status = "Paid";
            newInvoice.Invoice_Note = null;

            // new invoice detail list
            List<DatabaseAccess.InvoiceDetail> invoiceDetails = new List<DatabaseAccess.InvoiceDetail>();
            foreach (var invoiceDetail in temporaryInvoiceDetails)
            {
                DatabaseAccess.InvoiceDetail newInvoiceDetail = new DatabaseAccess.InvoiceDetail();
                newInvoiceDetail.Invoice_ID = newInvoice.Invoice_ID;
                newInvoiceDetail.Product_ID = invoiceDetail.Key;
                newInvoiceDetail.InvoiceDetail_Quantity = invoiceDetail.Value;
                if (productDictionary.TryGetValue(invoiceDetail.Key, out var product))
                {
                    newInvoiceDetail.InvoiceDetail_UnitPrice = product.Product_Price;
                }
                newInvoiceDetail.InvoiceDetail_TotalPrice = newInvoiceDetail.InvoiceDetail_UnitPrice * newInvoiceDetail.InvoiceDetail_Quantity;
                invoiceDetails.Add(newInvoiceDetail);
            }
            // get customer information from database
            Customers getCustomer = new Customers(true);
            getCustomer.ShowDialog();
            if (getCustomer.DialogResult == DialogResult.OK)
            {
                newInvoice.Customer_ID = getCustomer.selectedCustomer.Customer_ID;
            }
            else
            {
                newInvoice.Customer_ID = null; // nếu không chọn khách hàng thì để null
            }

            // update database
            await Task.Run(() => DatabaseAccess.Invoice.CreateNewInvoice(newInvoice));
            await Task.Run(() =>
            {
                foreach (var invoiceDetail in invoiceDetails)
                {
                    DatabaseAccess.InvoiceDetail.CreateNewInvoiceDetail(invoiceDetail);
                    // update inventory
                    if (DatabaseAccess.Inventory.GetInventoryByID(Session.StoreID, invoiceDetail.Product_ID) is DatabaseAccess.Inventory inventory)
                    {
                        inventory.Inventory_Stock -= invoiceDetail.InvoiceDetail_Quantity;
                        inventory.UpdateInventory();
                    }
                }
            }
            );
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // reset invoice details
            resetBtn_Click(sender, e);
        }
        public static string GenerateRandomCode()
        {
            var rand = new Random();
            string code;

            do
            {
                int number = rand.Next(0, 100000000);
                code = $"IN{number}";
            }
            while (DatabaseAccess.Invoice.GetInvoiceByID(code) != null);

            return code;
        }

        private void EmployeeComboBox_Click(object sender, EventArgs e)
        {
            // fetch on duty employees
            FetchOnDutyEmployee();
            EmployeeComboBox.DataSource = onDutyEmployee;
            EmployeeComboBox.DisplayMember = "Employee_Name";
            EmployeeComboBox.ValueMember = "Employee_ID";
        }

        public class Message
        {
            public int Id { get; set; }
            public string SenderId { get; set; }
            public string ReceiverId { get; set; }
            public string Content { get; set; }
            public DateTime Timestamp { get; set; }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string message = richTextBox2.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Vui lòng nhập nội dung tin nhắn!");
                return;
            }
            MessageBox.Show($"Nội dung gửi: {message}"); // Debug
            await SendMessageToApi(store.Store_ID, "kanekirito1279@gmail.com", message);
            richTextBox2.Clear();
            await LoadChatHistory();
        }

        private async Task SendMessageToApi(string senderId, string receiverId, string content)
        {
            var msg = new
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Content = content
            };
            var json = System.Text.Json.JsonSerializer.Serialize(msg);
            var data = new System.Net.Http.StringContent(json, System.Text.Encoding.UTF8, "application/json");
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.PostAsync("http://localhost:55135/api/message/send", data);
                response.EnsureSuccessStatusCode();
            }
        }

        private async Task LoadChatHistory()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:55135/api/message/history?user1={store.Store_ID}&user2=kanekirito1279@gmail.com");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var messages = System.Text.Json.JsonSerializer.Deserialize<List<Message>>(json, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                richTextBox1.Clear();
                foreach (var msg in messages)
                {
                                       
                                       string who = msg.SenderId == store.Store_ID ? "Bạn" : managerName;

                    string content = string.IsNullOrEmpty(msg.Content) ? "(Không có nội dung)" : msg.Content;
                    richTextBox1.AppendText($"{who}: {content}\n");
                }
            }
        }

        private async void chatTimer_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                await LoadChatHistory();
            }
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chuyển sang tab Tin nhắn thì bật timer và load chat
            if (tabControl1.SelectedTab == tabPage1)
            {
                await LoadChatHistory();
                chatTimer.Start();
            }
            else
            {
                chatTimer.Stop();
            }
        }
    }
}
