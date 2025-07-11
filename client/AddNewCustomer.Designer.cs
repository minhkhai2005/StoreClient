namespace StoreClient
{
    partial class AddNewCustomer
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
            label4 = new Label();
            label5 = new Label();
            CustomerNameTextBox = new TextBox();
            CustomerPhoneTextBox = new TextBox();
            CustomerEmailTextBox = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ConfirmBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 139);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 198);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 264);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(31, 97);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(321, 23);
            CustomerNameTextBox.TabIndex = 5;
            // 
            // CustomerPhoneTextBox
            // 
            CustomerPhoneTextBox.Location = new Point(31, 157);
            CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            CustomerPhoneTextBox.Size = new Size(321, 23);
            CustomerPhoneTextBox.TabIndex = 6;
            // 
            // CustomerEmailTextBox
            // 
            CustomerEmailTextBox.Location = new Point(31, 216);
            CustomerEmailTextBox.Name = "CustomerEmailTextBox";
            CustomerEmailTextBox.Size = new Size(321, 23);
            CustomerEmailTextBox.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(31, 282);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(147, 282);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(250, 330);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(102, 36);
            ConfirmBtn.TabIndex = 10;
            ConfirmBtn.Text = "Xác nhận";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // AddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 405);
            Controls.Add(ConfirmBtn);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(CustomerEmailTextBox);
            Controls.Add(CustomerPhoneTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewCustomer";
            Text = "AddNewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerPhoneTextBox;
        private TextBox CustomerEmailTextBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button ConfirmBtn;
    }
}