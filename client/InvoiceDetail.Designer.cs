namespace StoreClient
{
    partial class InvoiceDetail
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
            TimeLabel = new Label();
            StoreLabel = new Label();
            dataGridView1 = new DataGridView();
            ItemCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            QuantityCol = new DataGridViewTextBoxColumn();
            TotalCol = new DataGridViewTextBoxColumn();
            label2 = new Label();
            TotalQuantityLabel = new Label();
            TotalPriceLabel = new Label();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết hóa đơn";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(12, 67);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(57, 15);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "Thời gian";
            // 
            // StoreLabel
            // 
            StoreLabel.AutoSize = true;
            StoreLabel.Location = new Point(338, 67);
            StoreLabel.Name = "StoreLabel";
            StoreLabel.Size = new Size(58, 15);
            StoreLabel.TabIndex = 2;
            StoreLabel.Text = "Của hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemCol, PriceCol, QuantityCol, TotalCol });
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(481, 476);
            dataGridView1.TabIndex = 3;
            // 
            // ItemCol
            // 
            ItemCol.Frozen = true;
            ItemCol.HeaderText = "Sản phẩm";
            ItemCol.Name = "ItemCol";
            ItemCol.ReadOnly = true;
            ItemCol.Width = 150;
            // 
            // PriceCol
            // 
            PriceCol.Frozen = true;
            PriceCol.HeaderText = "Giá";
            PriceCol.Name = "PriceCol";
            PriceCol.ReadOnly = true;
            // 
            // QuantityCol
            // 
            QuantityCol.Frozen = true;
            QuantityCol.HeaderText = "Số lượng";
            QuantityCol.Name = "QuantityCol";
            QuantityCol.ReadOnly = true;
            // 
            // TotalCol
            // 
            TotalCol.Frozen = true;
            TotalCol.HeaderText = "Tổng";
            TotalCol.Name = "TotalCol";
            TotalCol.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 590);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Tổng";
            // 
            // TotalQuantityLabel
            // 
            TotalQuantityLabel.AutoSize = true;
            TotalQuantityLabel.Location = new Point(311, 590);
            TotalQuantityLabel.Name = "TotalQuantityLabel";
            TotalQuantityLabel.Size = new Size(54, 15);
            TotalQuantityLabel.TabIndex = 5;
            TotalQuantityLabel.Text = "Số lượng";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Location = new Point(418, 590);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(24, 15);
            TotalPriceLabel.TabIndex = 6;
            TotalPriceLabel.Text = "Giá";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(418, 623);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // InvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(505, 658);
            Controls.Add(CancelBtn);
            Controls.Add(TotalPriceLabel);
            Controls.Add(TotalQuantityLabel);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(StoreLabel);
            Controls.Add(TimeLabel);
            Controls.Add(label1);
            Name = "InvoiceDetail";
            Text = "InvoiceDetail";
            Shown += InvoiceDetail_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TimeLabel;
        private Label StoreLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn TotalCol;
        private Label label2;
        private Label TotalQuantityLabel;
        private Label TotalPriceLabel;
        private Button CancelBtn;
    }
}