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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(25, 66);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 1;
            label2.Text = "Email đăng ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(25, 152);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 211);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            // 
            // reset_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 337);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "reset_password";
            Text = "reset_password";
            FormClosed += reset_password_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}