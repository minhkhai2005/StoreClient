namespace client
{
    partial class NhanVien
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
            EmployeeDataGridView = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeeGender = new DataGridViewTextBoxColumn();
            EmployeeBirth = new DataGridViewTextBoxColumn();
            EmployeePhoneNumber = new DataGridViewTextBoxColumn();
            EmployeeEmail = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            SearchTextBox = new TextBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(EmployeeDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1659756F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.83402F));
            tableLayoutPanel1.Size = new Size(681, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.AllowUserToAddRows = false;
            EmployeeDataGridView.AllowUserToDeleteRows = false;
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, EmployeeGender, EmployeeBirth, EmployeePhoneNumber, EmployeeEmail });
            EmployeeDataGridView.Dock = DockStyle.Fill;
            EmployeeDataGridView.Location = new Point(3, 52);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.Size = new Size(675, 427);
            EmployeeDataGridView.TabIndex = 0;
            // 
            // EmployeeID
            // 
            EmployeeID.Frozen = true;
            EmployeeID.HeaderText = "Mã";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            EmployeeName.Frozen = true;
            EmployeeName.HeaderText = "Tên";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            // 
            // EmployeeGender
            // 
            EmployeeGender.Frozen = true;
            EmployeeGender.HeaderText = "Giới tính";
            EmployeeGender.Name = "EmployeeGender";
            EmployeeGender.ReadOnly = true;
            // 
            // EmployeeBirth
            // 
            EmployeeBirth.Frozen = true;
            EmployeeBirth.HeaderText = "Ngày sinh";
            EmployeeBirth.Name = "EmployeeBirth";
            EmployeeBirth.ReadOnly = true;
            // 
            // EmployeePhoneNumber
            // 
            EmployeePhoneNumber.Frozen = true;
            EmployeePhoneNumber.HeaderText = "Số điện thoại";
            EmployeePhoneNumber.Name = "EmployeePhoneNumber";
            EmployeePhoneNumber.ReadOnly = true;
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Frozen = true;
            EmployeeEmail.HeaderText = "Email";
            EmployeeEmail.Name = "EmployeeEmail";
            EmployeeEmail.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 43);
            panel1.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(84, 9);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(288, 23);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm";
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 482);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhanVien";
            Text = "Nhân viên";
            Shown += NhanVien_Shown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView EmployeeDataGridView;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeGender;
        private DataGridViewTextBoxColumn EmployeeBirth;
        private DataGridViewTextBoxColumn EmployeePhoneNumber;
        private DataGridViewTextBoxColumn EmployeeEmail;
        private Panel panel1;
        private TextBox SearchTextBox;
        private Label label2;
    }
}