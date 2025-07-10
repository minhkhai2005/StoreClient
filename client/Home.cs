using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace client
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.flowLayoutPanel1.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = Color.LightGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
            public bool IsAvailable { get; set; }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<Product> products = LoadProducts();
            ShowProducts(products);
        }

        private List<Product> LoadProducts()
        {
            return new List<Product>
            {
                new Product { Name = "Áo Thun", Price = 150000, ImagePath = "images/shirt.jpg", IsAvailable = true },
                new Product { Name = "Quần Jean", Price = 250000, ImagePath = "images/jeans.jpg", IsAvailable = false }
            };
        }

        private void ShowProducts(List<Product> products)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                Panel panel = new Panel();
                panel.Location = new Point(30, 30);
                panel.Size = new Size(200, 260);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(0);

                PictureBox pic = new PictureBox();
                string fullImagePath = Path.Combine(Application.StartupPath, "images", product.ImagePath);

                // ✅ Kiểm tra ảnh có tồn tại không
                if (File.Exists(fullImagePath))
                    pic.Image = Image.FromFile(fullImagePath);
                else
                    pic.Image = SystemIcons.Error.ToBitmap();
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Size = new Size(180, 120);
                pic.Location = new Point(30, 30);

                Label lblName = new Label();
                lblName.Text = product.Name;
                lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblName.Location = new Point(10, 140);
                lblName.Size = new Size(180, 20);

                Label lblPrice = new Label();
                lblPrice.Text = $"Giá: {product.Price:#,##0}đ";
                lblPrice.ForeColor = Color.Green;
                lblPrice.Location = new Point(15, 165);
                lblPrice.Size = new Size(180, 20);

                Label lblStatus = new Label();
                lblStatus.Text = product.IsAvailable ? "Available" : "Unavailable";
                lblStatus.ForeColor = product.IsAvailable ? Color.Blue : Color.Red;
                lblStatus.Location = new Point(10, 190);
                lblStatus.Size = new Size(180, 20);

                Button btnBuy = new Button();
                btnBuy.Text = "Mua";
                btnBuy.Enabled = product.IsAvailable;
                btnBuy.BackColor = Color.DodgerBlue;
                btnBuy.ForeColor = Color.White;
                btnBuy.FlatStyle = FlatStyle.Flat;
                btnBuy.Size = new Size(80, 30);
                btnBuy.Location = new Point(10, 215);

                panel.Controls.Add(pic);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblPrice);
                panel.Controls.Add(lblStatus);
                panel.Controls.Add(btnBuy);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory khoHang = new Inventory();
            khoHang.ShowDialog();

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
    }
}
