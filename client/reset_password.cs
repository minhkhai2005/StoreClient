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

namespace client
{
    public partial class reset_password : Form
    {
        public reset_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reset_password_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            SignInForm form1 = new SignInForm();
            form1.Show();
        }

        private async void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Xác nhận đặt lại mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }
            bool sendRequestResult = false;
            await Task.Run(() => sendRequestResult = FirebaseAuthentication.SendResetPasswordEmail(EmailTextBox.Text).Result);
            if (!sendRequestResult)
            {
                MessageBox.Show("Không thể gửi yêu cầu đặt lại mật khẩu. Vui lòng kiểm tra lại email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Đã gửi yêu cầu đặt lại mật khẩu. Vui lòng kiểm tra email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
