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
using static client.SignInForm;

namespace StoreClient
{
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }
        public static string GenerateRandomCode()
        {
            var rand = new Random();
            string code;

            do
            {
                int number = rand.Next(0, 100000000);
                code = $"C{number}";
            }
            while (DatabaseAccess.Customer.GetStoreByID(code) != null);

            return code;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Xác nhận thêm khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No) return;

            string name = CustomerNameTextBox.Text.Trim();
            string phone = CustomerPhoneTextBox.Text.Trim();
            string email = CustomerEmailTextBox.Text.Trim();

            DatabaseAccess.Customer newCustomer = new DatabaseAccess.Customer();
            newCustomer.Customer_Name = name;
            newCustomer.Customer_Phone = phone;
            newCustomer.Customer_Email = email;
            newCustomer.Customer_Gender = !radioButton1.Checked;
            newCustomer.Store_ID = Session.StoreID;
            newCustomer.Customer_ID = GenerateRandomCode();
            Task.Run(() => DatabaseAccess.Customer.CreateNewCustomer(newCustomer));

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
