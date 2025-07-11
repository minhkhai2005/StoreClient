namespace StoreClient
{
    partial class Customers
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
            tableLayoutPanel1 = new TableLayoutPanel();
            CustomerDataGridView = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerNane = new DataGridViewTextBoxColumn();
            CustomerPhone = new DataGridViewTextBoxColumn();
            CustomerEmail = new DataGridViewTextBoxColumn();
            CustomerGender = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            CancelBtn = new Button();
            addNewCustomer = new Button();
            ConfirmBtn = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            Refresh = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CustomerDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(796, 620);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerNane, CustomerPhone, CustomerEmail, CustomerGender });
            CustomerDataGridView.Dock = DockStyle.Fill;
            CustomerDataGridView.Location = new Point(3, 48);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.Size = new Size(790, 569);
            CustomerDataGridView.TabIndex = 0;
            CustomerDataGridView.CellDoubleClick += CustomerDataGridView_CellDoubleClick;
            // 
            // CustomerID
            // 
            CustomerID.Frozen = true;
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 150;
            // 
            // CustomerNane
            // 
            CustomerNane.Frozen = true;
            CustomerNane.HeaderText = "Tên khách hàng";
            CustomerNane.Name = "CustomerNane";
            CustomerNane.ReadOnly = true;
            CustomerNane.Width = 200;
            // 
            // CustomerPhone
            // 
            CustomerPhone.Frozen = true;
            CustomerPhone.HeaderText = "Số điện thoại";
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            CustomerEmail.Frozen = true;
            CustomerEmail.HeaderText = "Email";
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.ReadOnly = true;
            CustomerEmail.Width = 200;
            // 
            // CustomerGender
            // 
            CustomerGender.Frozen = true;
            CustomerGender.HeaderText = "Giới tính";
            CustomerGender.Name = "CustomerGender";
            CustomerGender.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(Refresh);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(addNewCustomer);
            panel1.Controls.Add(ConfirmBtn);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 39);
            panel1.TabIndex = 1;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(706, 11);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Bỏ qua";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // addNewCustomer
            // 
            addNewCustomer.Location = new Point(625, 11);
            addNewCustomer.Name = "addNewCustomer";
            addNewCustomer.Size = new Size(75, 23);
            addNewCustomer.TabIndex = 3;
            addNewCustomer.Text = "Thêm";
            addNewCustomer.UseVisualStyleBackColor = true;
            addNewCustomer.Click += addNewCustomer_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(544, 11);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(75, 23);
            ConfirmBtn.TabIndex = 2;
            ConfirmBtn.Text = "Xác nhận";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(72, 9);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(216, 23);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // Refresh
            // 
            Refresh.Location = new Point(463, 11);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 5;
            Refresh.Text = "Làm mới ";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 620);
            Controls.Add(tableLayoutPanel1);
            Name = "Customers";
            Text = "Thông tin khách hàng";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView CustomerDataGridView;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerNane;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn CustomerEmail;
        private DataGridViewTextBoxColumn CustomerGender;
        private Panel panel1;
        private TextBox SearchTextBox;
        private Label label1;
        private Button ConfirmBtn;
        private Button addNewCustomer;
        private Button CancelBtn;
        private Button Refresh;
    }
}