using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class InvoiceForm : Form
    {
        private ComboBox cmbProducts = new ComboBox { Left = 20, Top = 20, Width = 200 };
        private NumericUpDown numQuantity = new NumericUpDown { Left = 240, Top = 20, Width = 60, Minimum = 1, Maximum = 1000 };
        private Button btnAdd = new Button { Text = "Thêm", Left = 320, Top = 20 };
        private DataGridView dgvInvoice = new DataGridView { Left = 20, Top = 60, Width = 600, Height = 300 };
        private Label lblTotal = new Label { Text = "Tổng tiền: 0", Left = 20, Top = 370, AutoSize = true };
        private Button btnExport = new Button { Text = "Xuất hóa đơn", Left = 500, Top = 370 };

        private List<Product> allProducts;
        private List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        public InvoiceForm()
        {
            InitializeComponent();
            Text = "Tạo hóa đơn";
            Width = 660;
            Height = 450;
            Controls.Add(cmbProducts);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(dgvInvoice);
            Controls.Add(lblTotal);
            Controls.Add(btnExport);

            LoadMockProducts();
            cmbProducts.DataSource = allProducts;
            cmbProducts.DisplayMember = "Name";

            btnAdd.Click += (s, e) => AddProduct();
            btnExport.Click += (s, e) => MessageBox.Show("Hóa đơn đã được xuất!");

            SetupInvoiceGrid();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadMockProducts()
        {
            allProducts = new List<Product>
            {
                new Product { Id = "P001", Name = "Sản phẩm A", Category = "Loại 1", Quantity = 100, Status = "Available", Price = 50000 },
                new Product { Id = "P002", Name = "Sản phẩm B", Category = "Loại 2", Quantity = 50, Status = "Available", Price = 75000 },
                new Product { Id = "P003", Name = "Sản phẩm C", Category = "Loại 3", Quantity = 30, Status = "Unavailable", Price = 100000 },
            };
        }

        private void SetupInvoiceGrid()
        {
            dgvInvoice.DataSource = null;
            dgvInvoice.Columns.Clear();
            dgvInvoice.AutoGenerateColumns = false;

            dgvInvoice.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên SP", DataPropertyName = "Name", Width = 150 });
            dgvInvoice.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = "Quantity", Width = 80 });
            dgvInvoice.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đơn giá", DataPropertyName = "UnitPrice", Width = 100 });
            dgvInvoice.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thành tiền", DataPropertyName = "Total", Width = 120 });

            dgvInvoice.DataSource = invoiceItems;
        }

        private void AddProduct()
        {
            if (cmbProducts.SelectedItem is Product selected)
            {
                int qty = (int)numQuantity.Value;
                var existing = invoiceItems.FirstOrDefault(i => i.ProductId == selected.Id);
                if (existing != null)
                {
                    existing.Quantity += qty;
                }
                else
                {
                    invoiceItems.Add(new InvoiceItem
                    {
                        ProductId = selected.Id,
                        Name = selected.Name,
                        Quantity = qty,
                        UnitPrice = selected.Price,
                    });
                }

                SetupInvoiceGrid();
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            decimal total = invoiceItems.Sum(i => i.Total);
            lblTotal.Text = $"Tổng tiền: {total:N0} VND";
        }
    }

    public class InvoiceItem
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Quantity * UnitPrice;
    }

    public class Product
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}

