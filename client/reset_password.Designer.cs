namespace client
{
    partial class reset_password
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
            label2 = new Label();
            ConfirmBtn = new Button();
            label1 = new Label();
            EmailTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Email ";
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.Blue;
            ConfirmBtn.FlatStyle = FlatStyle.Popup;
            ConfirmBtn.Font = new Font("Arial", 9F);
            ConfirmBtn.ForeColor = Color.White;
            ConfirmBtn.Location = new Point(231, 132);
            ConfirmBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(82, 34);
            ConfirmBtn.TabIndex = 6;
            ConfirmBtn.Text = "Xác nhận";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 7;
            label1.Text = "Khôi phục mật khẩu";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(70, 80);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(243, 23);
            EmailTextBox.TabIndex = 8;
            // 
            // reset_password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 253);
            Controls.Add(EmailTextBox);
            Controls.Add(label1);
            Controls.Add(ConfirmBtn);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "reset_password";
            Text = "reset_password";
            FormClosed += reset_password_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button ConfirmBtn;
        private Label label1;
        private TextBox EmailTextBox;
    }
}