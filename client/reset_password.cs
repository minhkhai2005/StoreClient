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
    }
}
