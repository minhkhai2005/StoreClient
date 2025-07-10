namespace client
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SignUpLabel = new Label();
            login = new Button();
            label3 = new Label();
            ResetPasswordLabel = new Label();
            SuspendLayout();
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(138, 22);
            EmailBox.Margin = new Padding(3, 2, 3, 2);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(200, 23);
            EmailBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(138, 66);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(200, 23);
            PasswordBox.TabIndex = 1;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(33, 66);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Arial", 9F);
            SignUpLabel.ForeColor = Color.Blue;
            SignUpLabel.Location = new Point(150, 112);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(51, 15);
            SignUpLabel.TabIndex = 5;
            SignUpLabel.Text = "Đăng ký";
            SignUpLabel.Click += SignUp_Click;
            // 
            // login
            // 
            login.BackColor = Color.Blue;
            login.FlatStyle = FlatStyle.Popup;
            login.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            login.ForeColor = Color.White;
            login.Location = new Point(176, 143);
            login.Margin = new Padding(3, 2, 3, 2);
            login.Name = "login";
            login.Size = new Size(82, 22);
            login.TabIndex = 6;
            login.Text = "Đăng Nhập";
            login.UseVisualStyleBackColor = false;
            login.Click += SignIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(34, 112);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Chưa có tài khoản";
            // 
            // ResetPasswordLabel
            // 
            ResetPasswordLabel.AutoSize = true;
            ResetPasswordLabel.ForeColor = Color.Blue;
            ResetPasswordLabel.Location = new Point(241, 110);
            ResetPasswordLabel.Name = "ResetPasswordLabel";
            ResetPasswordLabel.Size = new Size(90, 15);
            ResetPasswordLabel.TabIndex = 8;
            ResetPasswordLabel.Text = "Quên Mật Khẩu";
            ResetPasswordLabel.Click += ResetPassword_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 184);
            Controls.Add(ResetPasswordLabel);
            Controls.Add(label3);
            Controls.Add(login);
            Controls.Add(SignUpLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignInForm";
            Text = "Đăng Nhập";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Label label1;
        private Label label2;
        private Label SignUpLabel;
        private Button login;
        private Label label3;
        private Label ResetPasswordLabel;
    }
}
