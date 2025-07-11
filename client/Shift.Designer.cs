namespace StoreClient
{
    partial class Shift
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            ConfirmBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Bắt đầu ca làm việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 65);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Email nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(120, 62);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(253, 23);
            EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(120, 102);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(253, 23);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(153, 160);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(123, 33);
            ConfirmBtn.TabIndex = 5;
            ConfirmBtn.Text = "Xác nhận";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // Shift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(429, 227);
            Controls.Add(ConfirmBtn);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Shift";
            Text = "Làm việc";
            Shown += Shift_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Button ConfirmBtn;
    }
}