using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DatabaseClass;

namespace client
{
    public partial class Home : Form
    {
        public DatabaseAccess.Store store;
        private List<DatabaseAccess.Inventory> inventoryList;
        private Dictionary<string, DatabaseAccess.Product> productDictionary;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            inventoryList = DatabaseAccess.GetInventoriesByStoreID(store.Store_ID);
            productDictionary = new Dictionary<string, DatabaseAccess.Product>();
            foreach (var inventory in inventoryList)
            {
                var product = DatabaseAccess.GetProductByID(inventory.Product_ID);
                if (product != null)
                {
                    productDictionary[product.Product_ID] = product;
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
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
                Task.Run(()=>store.UpdateStore());
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
    }
}
