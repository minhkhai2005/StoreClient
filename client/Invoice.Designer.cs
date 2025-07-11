namespace StoreClient
{
    partial class Invoice
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
            panel1 = new Panel();
            SearchTextBox = new TextBox();
            label1 = new Label();
            InvoiceDataGridView = new DataGridView();
            InvoiceID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            InvoiceQuantity = new DataGridViewTextBoxColumn();
            InvoiceTotal = new DataGridViewTextBoxColumn();
            InvoiceDate = new DataGridViewTextBoxColumn();
            InvoiceStatus = new DataGridViewTextBoxColumn();
            InvoiceNote = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(InvoiceDataGridView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(805, 607);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 44);
            panel1.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(72, 8);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(327, 23);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // InvoiceDataGridView
            // 
            InvoiceDataGridView.AllowUserToAddRows = false;
            InvoiceDataGridView.AllowUserToDeleteRows = false;
            InvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { InvoiceID, EmployeeID, CustomerID, InvoiceQuantity, InvoiceTotal, InvoiceDate, InvoiceStatus, InvoiceNote });
            InvoiceDataGridView.Dock = DockStyle.Fill;
            InvoiceDataGridView.Location = new Point(3, 53);
            InvoiceDataGridView.Name = "InvoiceDataGridView";
            InvoiceDataGridView.ReadOnly = true;
            InvoiceDataGridView.Size = new Size(799, 551);
            InvoiceDataGridView.TabIndex = 1;
            // 
            // InvoiceID
            // 
            InvoiceID.Frozen = true;
            InvoiceID.HeaderText = "Mã hóa đơn";
            InvoiceID.Name = "InvoiceID";
            InvoiceID.ReadOnly = true;
            // 
            // EmployeeID
            // 
            EmployeeID.Frozen = true;
            EmployeeID.HeaderText = "Mã nhân viên";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.Frozen = true;
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // InvoiceQuantity
            // 
            InvoiceQuantity.Frozen = true;
            InvoiceQuantity.HeaderText = "Số lượng ";
            InvoiceQuantity.Name = "InvoiceQuantity";
            InvoiceQuantity.ReadOnly = true;
            // 
            // InvoiceTotal
            // 
            InvoiceTotal.Frozen = true;
            InvoiceTotal.HeaderText = "Tổng tiền";
            InvoiceTotal.Name = "InvoiceTotal";
            InvoiceTotal.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            InvoiceDate.Frozen = true;
            InvoiceDate.HeaderText = "Thời gian";
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.ReadOnly = true;
            // 
            // InvoiceStatus
            // 
            InvoiceStatus.Frozen = true;
            InvoiceStatus.HeaderText = "Trạng thái";
            InvoiceStatus.Name = "InvoiceStatus";
            InvoiceStatus.ReadOnly = true;
            // 
            // InvoiceNote
            // 
            InvoiceNote.Frozen = true;
            InvoiceNote.HeaderText = "Ghi chú";
            InvoiceNote.Name = "InvoiceNote";
            InvoiceNote.ReadOnly = true;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 607);
            Controls.Add(tableLayoutPanel1);
            Name = "Invoice";
            Text = "Hóa đơn";
            Shown += Invoice_Shown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox SearchTextBox;
        private Label label1;
        private DataGridView InvoiceDataGridView;
        private DataGridViewTextBoxColumn InvoiceID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn InvoiceQuantity;
        private DataGridViewTextBoxColumn InvoiceTotal;
        private DataGridViewTextBoxColumn InvoiceDate;
        private DataGridViewTextBoxColumn InvoiceStatus;
        private DataGridViewTextBoxColumn InvoiceNote;
    }
}