using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;
using client;
using DatabaseClass;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static client.SignInForm;

namespace StoreClient
{
    public partial class Shift : Form
    {
        bool isShiftStart = true;
        public Shift()
        {
            InitializeComponent();
        }
        public Shift(bool isShiftStart)
        {
            InitializeComponent();
            this.isShiftStart = isShiftStart;
        }

        private void Shift_Shown(object sender, EventArgs e)
        {
            if (isShiftStart)
            {
                return;
            }
            else
            {
                label1.Text = "Kết thúc ca làm việc";
            }
        }

        private async void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (isShiftStart)
            {
                StartShift();
            }
            else
            {
                EndShift();
            }
        }
        private async void EndShift()
        {
            // kiểm tra nhân viên có phải là nhân viên của cửa hàng này không
            var emp = DatabaseAccess.GetEmployeeByEmail(EmailBox.Text);
            if (emp == null || emp.Store_ID != Session.StoreID)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra ca làm 
            var shift = emp.GetShift(((int)DateTime.Now.DayOfWeek + 6) % 7 + 1);
            if (shift == null || !shift.Is_Active)
            {
                MessageBox.Show("Bạn không có ca làm bây giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = await FirebaseAuthentication.SignIn(EmailBox.Text, PasswordBox.Text);
            if (result.Item1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                // cập nhật ca làm cho nhân viên
                shift.Is_Active = false;
                shift.UpdateShift();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void StartShift()
        {
            // kiểm tra nhân viên có phải là nhân viên của cửa hàng này không
            var emp = DatabaseAccess.GetEmployeeByEmail(EmailBox.Text);
            if (emp == null || emp.Store_ID != Session.StoreID)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ca làm 
            var shift = emp.GetShift(((int)DateTime.Now.DayOfWeek + 6) % 7 + 1);
            if (shift == null)
            {
                MessageBox.Show("Bạn không có ca làm bây giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = await FirebaseAuthentication.SignIn(EmailBox.Text, PasswordBox.Text);
            if (result.Item1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                // cập nhật ca làm cho nhân viên
                shift.Is_Active = true;
                shift.UpdateShift();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
