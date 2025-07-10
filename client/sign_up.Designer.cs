namespace client
{
    partial class sign_up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StoreEmailTextBox = new TextBox();
            StoreConfirmPasswordTextBox = new TextBox();
            StorePasswordTextBox = new TextBox();
            StoreNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SignUpBtn = new Button();
            EmployeeOption = new RadioButton();
            StoreOption = new RadioButton();
            label6 = new Label();
            StoreAddressTextBox = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            FemaleOption = new RadioButton();
            MaleOption = new RadioButton();
            label8 = new Label();
            EmployeePhoneNumberTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            EmployeeNameTextBox = new TextBox();
            EmployeePasswordTextBox = new TextBox();
            EmployeeConfirmPasswordTextbox = new TextBox();
            EmployeeEmailTextBox = new TextBox();
            label7 = new Label();
            EmployeeBirthDTP = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StoreEmailTextBox
            // 
            StoreEmailTextBox.ForeColor = SystemColors.ActiveCaptionText;
            StoreEmailTextBox.Location = new Point(130, 26);
            StoreEmailTextBox.Margin = new Padding(3, 2, 3, 2);
            StoreEmailTextBox.Name = "StoreEmailTextBox";
            StoreEmailTextBox.Size = new Size(174, 23);
            StoreEmailTextBox.TabIndex = 0;
            // 
            // StoreConfirmPasswordTextBox
            // 
            StoreConfirmPasswordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            StoreConfirmPasswordTextBox.Location = new Point(130, 103);
            StoreConfirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            StoreConfirmPasswordTextBox.Name = "StoreConfirmPasswordTextBox";
            StoreConfirmPasswordTextBox.PasswordChar = '*';
            StoreConfirmPasswordTextBox.Size = new Size(174, 23);
            StoreConfirmPasswordTextBox.TabIndex = 1;
            StoreConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // StorePasswordTextBox
            // 
            StorePasswordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            StorePasswordTextBox.Location = new Point(130, 64);
            StorePasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            StorePasswordTextBox.Name = "StorePasswordTextBox";
            StorePasswordTextBox.PasswordChar = '*';
            StorePasswordTextBox.Size = new Size(174, 23);
            StorePasswordTextBox.TabIndex = 1;
            StorePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // StoreNameTextBox
            // 
            StoreNameTextBox.ForeColor = SystemColors.ActiveCaptionText;
            StoreNameTextBox.Location = new Point(130, 140);
            StoreNameTextBox.Margin = new Padding(3, 2, 3, 2);
            StoreNameTextBox.Name = "StoreNameTextBox";
            StoreNameTextBox.Size = new Size(174, 23);
            StoreNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(10, 105);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(10, 143);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Tên của hàng";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Blue;
            SignUpBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            SignUpBtn.Font = new Font("Arial", 9F);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(537, 351);
            SignUpBtn.Margin = new Padding(3, 2, 3, 2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(107, 34);
            SignUpBtn.TabIndex = 7;
            SignUpBtn.Text = "Đăng Ký";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // EmployeeOption
            // 
            EmployeeOption.AutoSize = true;
            EmployeeOption.Location = new Point(565, 304);
            EmployeeOption.Name = "EmployeeOption";
            EmployeeOption.Size = new Size(79, 19);
            EmployeeOption.TabIndex = 8;
            EmployeeOption.Text = "Nhân viên";
            EmployeeOption.UseVisualStyleBackColor = true;
            // 
            // StoreOption
            // 
            StoreOption.AutoSize = true;
            StoreOption.Checked = true;
            StoreOption.Location = new Point(565, 329);
            StoreOption.Name = "StoreOption";
            StoreOption.Size = new Size(76, 19);
            StoreOption.TabIndex = 9;
            StoreOption.TabStop = true;
            StoreOption.Text = "Cửa hàng";
            StoreOption.UseVisualStyleBackColor = true;
            StoreOption.CheckedChanged += StoreOption_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(10, 186);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ cửa hàng";
            // 
            // StoreAddressTextBox
            // 
            StoreAddressTextBox.ForeColor = SystemColors.ActiveCaptionText;
            StoreAddressTextBox.Location = new Point(130, 183);
            StoreAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            StoreAddressTextBox.Name = "StoreAddressTextBox";
            StoreAddressTextBox.Size = new Size(174, 23);
            StoreAddressTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(FemaleOption);
            panel1.Controls.Add(MaleOption);
            panel1.Location = new Point(350, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 33);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 5);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 2;
            label5.Text = "Giới tính";
            // 
            // FemaleOption
            // 
            FemaleOption.AutoSize = true;
            FemaleOption.Enabled = false;
            FemaleOption.Location = new Point(177, 3);
            FemaleOption.Name = "FemaleOption";
            FemaleOption.Size = new Size(41, 19);
            FemaleOption.TabIndex = 1;
            FemaleOption.TabStop = true;
            FemaleOption.Text = "Nữ";
            FemaleOption.UseVisualStyleBackColor = true;
            // 
            // MaleOption
            // 
            MaleOption.AutoSize = true;
            MaleOption.Enabled = false;
            MaleOption.Location = new Point(120, 3);
            MaleOption.Name = "MaleOption";
            MaleOption.Size = new Size(51, 19);
            MaleOption.TabIndex = 0;
            MaleOption.TabStop = true;
            MaleOption.Text = "Nam";
            MaleOption.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F);
            label8.Location = new Point(350, 186);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 24;
            label8.Text = "Số điện thoại";
            // 
            // EmployeePhoneNumberTextBox
            // 
            EmployeePhoneNumberTextBox.Enabled = false;
            EmployeePhoneNumberTextBox.ForeColor = SystemColors.ActiveCaptionText;
            EmployeePhoneNumberTextBox.Location = new Point(470, 183);
            EmployeePhoneNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            EmployeePhoneNumberTextBox.Name = "EmployeePhoneNumberTextBox";
            EmployeePhoneNumberTextBox.Size = new Size(174, 23);
            EmployeePhoneNumberTextBox.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F);
            label9.Location = new Point(350, 145);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 22;
            label9.Text = "Tên Nhân viên";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F);
            label10.Location = new Point(350, 107);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 21;
            label10.Text = "Nhập lại mật khẩu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F);
            label11.Location = new Point(350, 69);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 20;
            label11.Text = "Mật Khẩu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F);
            label12.Location = new Point(350, 28);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 19;
            label12.Text = "Email";
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Enabled = false;
            EmployeeNameTextBox.ForeColor = SystemColors.ActiveCaptionText;
            EmployeeNameTextBox.Location = new Point(470, 142);
            EmployeeNameTextBox.Margin = new Padding(3, 2, 3, 2);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.Size = new Size(174, 23);
            EmployeeNameTextBox.TabIndex = 18;
            // 
            // EmployeePasswordTextBox
            // 
            EmployeePasswordTextBox.Enabled = false;
            EmployeePasswordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            EmployeePasswordTextBox.Location = new Point(470, 66);
            EmployeePasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            EmployeePasswordTextBox.Name = "EmployeePasswordTextBox";
            EmployeePasswordTextBox.PasswordChar = '*';
            EmployeePasswordTextBox.Size = new Size(174, 23);
            EmployeePasswordTextBox.TabIndex = 16;
            EmployeePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmployeeConfirmPasswordTextbox
            // 
            EmployeeConfirmPasswordTextbox.Enabled = false;
            EmployeeConfirmPasswordTextbox.ForeColor = SystemColors.ActiveCaptionText;
            EmployeeConfirmPasswordTextbox.Location = new Point(470, 105);
            EmployeeConfirmPasswordTextbox.Margin = new Padding(3, 2, 3, 2);
            EmployeeConfirmPasswordTextbox.Name = "EmployeeConfirmPasswordTextbox";
            EmployeeConfirmPasswordTextbox.PasswordChar = '*';
            EmployeeConfirmPasswordTextbox.Size = new Size(174, 23);
            EmployeeConfirmPasswordTextbox.TabIndex = 17;
            EmployeeConfirmPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // EmployeeEmailTextBox
            // 
            EmployeeEmailTextBox.Enabled = false;
            EmployeeEmailTextBox.ForeColor = SystemColors.ActiveCaptionText;
            EmployeeEmailTextBox.Location = new Point(470, 28);
            EmployeeEmailTextBox.Margin = new Padding(3, 2, 3, 2);
            EmployeeEmailTextBox.Name = "EmployeeEmailTextBox";
            EmployeeEmailTextBox.Size = new Size(174, 23);
            EmployeeEmailTextBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.Location = new Point(350, 271);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 25;
            label7.Text = "Ngày sinh";
            // 
            // EmployeeBirthDTP
            // 
            EmployeeBirthDTP.Enabled = false;
            EmployeeBirthDTP.Location = new Point(441, 265);
            EmployeeBirthDTP.Name = "EmployeeBirthDTP";
            EmployeeBirthDTP.Size = new Size(203, 23);
            EmployeeBirthDTP.TabIndex = 26;
            // 
            // sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 396);
            Controls.Add(EmployeeBirthDTP);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(EmployeePhoneNumberTextBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(EmployeeNameTextBox);
            Controls.Add(EmployeePasswordTextBox);
            Controls.Add(EmployeeConfirmPasswordTextbox);
            Controls.Add(EmployeeEmailTextBox);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(StoreAddressTextBox);
            Controls.Add(StoreOption);
            Controls.Add(EmployeeOption);
            Controls.Add(SignUpBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StoreNameTextBox);
            Controls.Add(StorePasswordTextBox);
            Controls.Add(StoreConfirmPasswordTextBox);
            Controls.Add(StoreEmailTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "sign_up";
            Text = "sign_up";
            FormClosed += sign_up_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StoreEmailTextBox;
        private TextBox StoreConfirmPasswordTextBox;
        private TextBox StorePasswordTextBox;
        private TextBox StoreNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SignUpBtn;
        private RadioButton EmployeeOption;
        private RadioButton StoreOption;
        private Label label6;
        private TextBox StoreAddressTextBox;
        private Panel panel1;
        private RadioButton FemaleOption;
        private RadioButton MaleOption;
        private Label label5;
        private Label label8;
        private TextBox EmployeePhoneNumberTextBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox EmployeeNameTextBox;
        private TextBox EmployeePasswordTextBox;
        private TextBox EmployeeConfirmPasswordTextbox;
        private TextBox EmployeeEmailTextBox;
        private Label label7;
        private DateTimePicker EmployeeBirthDTP;
    }
}