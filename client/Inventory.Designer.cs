namespace client
{
    partial class Inventory
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            SearchTextBox = new TextBox();
            TypeComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            InventoryDataGridView = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            AlertQuantity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 571);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(InventoryDataGridView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.056042F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.9439545F));
            tableLayoutPanel1.Size = new Size(771, 571);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(SearchTextBox);
            panel2.Controls.Add(TypeComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 40);
            panel2.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(340, 9);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(209, 23);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Tất cả", "Available", "Unavailable" });
            TypeComboBox.Location = new Point(71, 9);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(173, 23);
            TypeComboBox.TabIndex = 2;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 15);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại";
            // 
            // InventoryDataGridView
            // 
            InventoryDataGridView.AllowUserToAddRows = false;
            InventoryDataGridView.AllowUserToDeleteRows = false;
            InventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductPrice, Stock, AlertQuantity, Status });
            InventoryDataGridView.Dock = DockStyle.Fill;
            InventoryDataGridView.Location = new Point(3, 49);
            InventoryDataGridView.Name = "InventoryDataGridView";
            InventoryDataGridView.ReadOnly = true;
            InventoryDataGridView.Size = new Size(765, 519);
            InventoryDataGridView.TabIndex = 1;
            // 
            // ProductID
            // 
            ProductID.Frozen = true;
            ProductID.HeaderText = "Mã ";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.Frozen = true;
            ProductName.HeaderText = "Tên";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 200;
            // 
            // ProductPrice
            // 
            ProductPrice.Frozen = true;
            ProductPrice.HeaderText = "Giá";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.Frozen = true;
            Stock.HeaderText = "Tồn kho";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // AlertQuantity
            // 
            AlertQuantity.Frozen = true;
            AlertQuantity.HeaderText = "Mức cảnh báo";
            AlertQuantity.Name = "AlertQuantity";
            AlertQuantity.ReadOnly = true;
            AlertQuantity.Width = 120;
            // 
            // Status
            // 
            Status.Frozen = true;
            Status.HeaderText = "Trạng thái";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 571);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory";
            Text = "Kho";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private DataGridView InventoryDataGridView;
        private TextBox SearchTextBox;
        private ComboBox TypeComboBox;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn AlertQuantity;
        private DataGridViewTextBoxColumn Status;
    }
}