using DatabaseClass;
using Authentication;
namespace client
{
    public partial class SignInForm : Form
    {
        public static class Session
        {
            public static string Email { get; set; }
            public static string StoreID { get; set; }
            public static DatabaseAccess.Store store { get; set; }
        }
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            sign_up sign_Up = new sign_up();
            sign_Up.Show();
            this.Hide();

        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            reset_password reset_Password = new reset_password();
            reset_Password.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            //check if there is any store with this email
            if (DatabaseAccess.GetStoreByEmail(EmailBox.Text) == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = await FirebaseAuthentication.SignIn(EmailBox.Text, PasswordBox.Text);
            if (result.Item1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Session.Email = EmailBox.Text;
                DatabaseAccess.CurrentEmail = EmailBox.Text; // Lưu email vào DatabaseAccess
                Session.store = DatabaseAccess.GetStoreByEmail(EmailBox.Text);
                Session.StoreID = Session.store.Store_ID;
                Home home = new Home();
                home.store = Session.store; // Truyền store vào Home
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
