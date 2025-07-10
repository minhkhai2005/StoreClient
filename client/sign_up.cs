using Authentication;
using DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class sign_up : Form
    {
        public sign_up()
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
                code = $"S{number}";          
            }
            while (DatabaseAccess.Store.GetStoreByID(code) != null); 

            return code;
        }
        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            // validate entered password
            if (!ValidateEnteredPassword())
            {
                return;
            }


            // new store
            if (StoreOption.Checked)
            {
                var r = MessageBox.Show("Bạn có chắc chắn muốn đăng ký cửa hàng mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }
                var isSuccess = await FirebaseAuthentication.SignUp(StoreEmailTextBox.Text, StorePasswordTextBox.Text);
                if (isSuccess.Success)
                {
                    MessageBox.Show("Đăng ký thành công. Vui lòng kiểm tra email để xác nhận tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewStore();
                }
                else
                {

                    MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            // new employee
            else
            {
                var r = MessageBox.Show("Bạn có chắc chắn muốn đăng ký nhân viên mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }
                var isSuccess = await FirebaseAuthentication.SignUp(EmployeeEmailTextBox.Text, EmployeePasswordTextBox.Text);
                if (isSuccess.Success)
                {
                    MessageBox.Show("Đăng ký thành công. Vui lòng kiểm tra email để xác nhận tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewEmployee();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            SignInForm form1 = new SignInForm();
            form1.Show();
        }

        private void StoreOption_CheckedChanged(object sender, EventArgs e)
        {
            if (StoreOption.Checked)
            {
                StoreEmailTextBox.Enabled = true;
                StorePasswordTextBox.Enabled = true;
                StoreConfirmPasswordTextBox.Enabled = true;
                StoreNameTextBox.Enabled = true;
                StoreAddressTextBox.Enabled = true;

                EmployeeEmailTextBox.Enabled = false;
                EmployeePasswordTextBox.Enabled = false;
                EmployeeConfirmPasswordTextbox.Enabled = false;
                EmployeeNameTextBox.Enabled = false;
                EmployeePhoneNumberTextBox.Enabled = false;
                MaleOption.Enabled = false;
                FemaleOption.Enabled = false;
                EmployeeBirthDTP.Enabled = false;

            }
            else
            {
                StoreEmailTextBox.Enabled = false;
                StorePasswordTextBox.Enabled = false;
                StoreConfirmPasswordTextBox.Enabled = false;
                StoreNameTextBox.Enabled = false;
                StoreAddressTextBox.Enabled = false;

                EmployeeEmailTextBox.Enabled = true;
                EmployeePasswordTextBox.Enabled = true;
                EmployeeConfirmPasswordTextbox.Enabled = true;
                EmployeeNameTextBox.Enabled = true;
                EmployeePhoneNumberTextBox.Enabled = true;
                MaleOption.Enabled = true;
                FemaleOption.Enabled = true;
                EmployeeBirthDTP.Enabled = true;
            }
        }

        private void NewStore()
        {
            DatabaseAccess.Store newStore = new DatabaseAccess.Store();
            newStore.Store_Name = StoreNameTextBox.Text;
            newStore.Store_ID = GenerateRandomCode();
            newStore.Store_Address = StoreAddressTextBox.Text;
            newStore.Manager_ID = null;
            newStore.Store_Status = false;
            newStore.Store_Email = StoreEmailTextBox.Text;
            newStore.CreateNewStore();
        }
        private void NewEmployee()
        {
            DatabaseAccess.Employee newEmployee = new DatabaseAccess.Employee();
            newEmployee.Employee_ID = GenerateRandomCode();
            newEmployee.Employee_Name = EmployeeNameTextBox.Text;
            newEmployee.Employee_Gender = MaleOption.Checked ? false : true;
            newEmployee.Employee_PhoneNumber = EmployeePhoneNumberTextBox.Text;
            newEmployee.Employee_Birth = EmployeeBirthDTP.Value;
            newEmployee.Store_ID = null;
            newEmployee.Employee_Email = EmployeeEmailTextBox.Text;
            newEmployee.CreateNewEmployee();
        }
        private bool ValidateEnteredPassword()
        {
            if (StoreOption.Checked)
            {
                if (StorePasswordTextBox.Text != StoreConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                if (EmployeePasswordTextBox.Text != EmployeeConfirmPasswordTextbox.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
