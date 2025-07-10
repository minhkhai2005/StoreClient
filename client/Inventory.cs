using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static client.Home;

namespace client
{
    public partial class Inventory : Form
    {
        private DataGridView dgvInventory = new DataGridView { Dock = DockStyle.Bottom, Height = 300 };
        private ComboBox cmbFilter = new ComboBox { Left = 20, Top = 20, Width = 150 };
        private TextBox txtSearch = new TextBox { Left = 200, Top = 20, Width = 200, PlaceholderText = "Tìm sản phẩm..." };
        private Button btnUpdate = new Button { Text = "Cập nhật kho", Left = 420, Top = 20 };

        private List<Product> products;
        public Inventory()
        {
            InitializeComponent();
            Text = "Kho hàng";
            Controls.Add(cmbFilter);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(dgvInventory);

            cmbFilter.Items.AddRange(new string[] { "Tất cả", "Available", "Unavailable" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.SelectedIndexChanged += (s, e) => LoadData();
            txtSearch.TextChanged += (s, e) => LoadData();
            btnUpdate.Click += (s, e) => LoadData();

            LoadMockData();
            LoadData();
        }
        private void LoadMockData()
        {
            products = new List<Product>
            {
                new Product { Id = "P001", Name = "Sản phẩm A", Category = "Loại 1", Quantity = 10, Status = "Available" },
                new Product { Id = "P002", Name = "Sản phẩm B", Category = "Loại 2", Quantity = 0, Status = "Unavailable" },
                new Product { Id = "P003", Name = "Sản phẩm C", Category = "Loại 1", Quantity = 5, Status = "Available" },
            };
        }

        private void LoadData()
        {
            string filter = cmbFilter.SelectedItem.ToString();
            string keyword = txtSearch.Text.ToLower();

            var filtered = products.Where(p =>
                (filter == "Tất cả" || p.Status == filter) &&
                (p.Name.ToLower().Contains(keyword) || p.Id.ToLower().Contains(keyword))
            ).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("Mã SP");
            table.Columns.Add("Tên SP");
            table.Columns.Add("Loại");
            table.Columns.Add("Số lượng");
            table.Columns.Add("Trạng thái");

            foreach (var p in filtered)
            {
                table.Rows.Add(p.Id, p.Name, p.Category, p.Quantity, p.Status);
            }

            dgvInventory.DataSource = table;

        }

        public class Product
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Quantity { get; set; }
            public string Status { get; set; }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kho_Load(object sender, EventArgs e)
        {

        }

    }
}
