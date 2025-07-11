namespace client
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            myAccountToolStripMenuItem = new ToolStripMenuItem();
            InvoiceMenu = new ToolStripMenuItem();
            EmployeeMenu = new ToolStripMenuItem();
            StartShift = new ToolStripMenuItem();
            EndShift = new ToolStripMenuItem();
            InventoryMenu = new ToolStripMenuItem();
            trạngTháiCửaHàngToolStripMenuItem = new ToolStripMenuItem();
            CloseStatusMenu = new ToolStripMenuItem();
            OpenStatusMenu = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            createInvoice = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            EmployeeComboBox = new ComboBox();
            TotalLabel = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            AvailableProductDataGridView = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            AddBtn = new Button();
            searchTextBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            InvoiceDetailDataGridView = new DataGridView();
            InvoiceProductID = new DataGridViewTextBoxColumn();
            InvoiceProductName = new DataGridViewTextBoxColumn();
            InvoicePrice = new DataGridViewTextBoxColumn();
            InvoiceQuantity = new DataGridViewTextBoxColumn();
            InvoiceTotal = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            payBtn = new Button();
            resetBtn = new Button();
            deleteItemBtn = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            createInvoice.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvailableProductDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceDetailDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, myAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(72, 20);
            homeToolStripMenuItem.Text = "Hệ Thống";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(129, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // myAccountToolStripMenuItem
            // 
            myAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InvoiceMenu, EmployeeMenu, InventoryMenu, trạngTháiCửaHàngToolStripMenuItem });
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(62, 20);
            myAccountToolStripMenuItem.Text = "Quản Lý";
            // 
            // InvoiceMenu
            // 
            InvoiceMenu.Name = "InvoiceMenu";
            InvoiceMenu.Size = new Size(179, 22);
            InvoiceMenu.Text = "Hóa đơn";
            InvoiceMenu.Click += InvoiceToolStripMenuItem_Click;
            // 
            // EmployeeMenu
            // 
            EmployeeMenu.DropDownItems.AddRange(new ToolStripItem[] { StartShift, EndShift });
            EmployeeMenu.Name = "EmployeeMenu";
            EmployeeMenu.Size = new Size(179, 22);
            EmployeeMenu.Text = "Nhân viên";
            EmployeeMenu.Click += nhânViênToolStripMenuItem_Click;
            // 
            // StartShift
            // 
            StartShift.Name = "StartShift";
            StartShift.Size = new Size(133, 22);
            StartShift.Text = "Bắt đầu ca";
            StartShift.Click += StartShift_Click;
            // 
            // EndShift
            // 
            EndShift.Name = "EndShift";
            EndShift.Size = new Size(133, 22);
            EndShift.Text = "Kết thúc ca";
            EndShift.Click += EndShift_Click;
            // 
            // InventoryMenu
            // 
            InventoryMenu.Name = "InventoryMenu";
            InventoryMenu.Size = new Size(179, 22);
            InventoryMenu.Text = "Kho hàng";
            InventoryMenu.Click += khoHàngToolStripMenuItem_Click;
            // 
            // trạngTháiCửaHàngToolStripMenuItem
            // 
            trạngTháiCửaHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CloseStatusMenu, OpenStatusMenu });
            trạngTháiCửaHàngToolStripMenuItem.Name = "trạngTháiCửaHàngToolStripMenuItem";
            trạngTháiCửaHàngToolStripMenuItem.Size = new Size(179, 22);
            trạngTháiCửaHàngToolStripMenuItem.Text = "Trạng thái cửa hàng";
            // 
            // CloseStatusMenu
            // 
            CloseStatusMenu.Checked = true;
            CloseStatusMenu.CheckState = CheckState.Checked;
            CloseStatusMenu.Name = "CloseStatusMenu";
            CloseStatusMenu.Size = new Size(128, 22);
            CloseStatusMenu.Text = "Đóng cửa ";
            CloseStatusMenu.Click += CloseStatusMenu_Click;
            // 
            // OpenStatusMenu
            // 
            OpenStatusMenu.Name = "OpenStatusMenu";
            OpenStatusMenu.Size = new Size(128, 22);
            OpenStatusMenu.Text = "Mở cửa";
            OpenStatusMenu.Click += OpenStatusMenu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(createInvoice);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 597);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tin nhắn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.4358978F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.500885F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4991121F));
            tableLayoutPanel1.Size = new Size(780, 563);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // createInvoice
            // 
            createInvoice.Controls.Add(tableLayoutPanel2);
            createInvoice.Location = new Point(4, 24);
            createInvoice.Name = "createInvoice";
            createInvoice.Padding = new Padding(3);
            createInvoice.Size = new Size(786, 569);
            createInvoice.TabIndex = 1;
            createInvoice.Text = "Tạo hóa đơn";
            createInvoice.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(780, 563);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            tableLayoutPanel2.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EmployeeComboBox);
            panel1.Controls.Add(TotalLabel);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 40);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 13);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Nhân viên";
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Location = new Point(73, 10);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new Size(156, 23);
            EmployeeComboBox.TabIndex = 2;
            EmployeeComboBox.Click += EmployeeComboBox_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(447, 13);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(13, 15);
            TotalLabel.TabIndex = 1;
            TotalLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 13);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Tổng tiền:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(AvailableProductDataGridView, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.414873F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.58513F));
            tableLayoutPanel3.Size = new Size(384, 511);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // AvailableProductDataGridView
            // 
            AvailableProductDataGridView.AllowUserToAddRows = false;
            AvailableProductDataGridView.AllowUserToDeleteRows = false;
            AvailableProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AvailableProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, ProductPrice });
            AvailableProductDataGridView.Dock = DockStyle.Fill;
            AvailableProductDataGridView.Location = new Point(3, 46);
            AvailableProductDataGridView.Name = "AvailableProductDataGridView";
            AvailableProductDataGridView.ReadOnly = true;
            AvailableProductDataGridView.Size = new Size(378, 462);
            AvailableProductDataGridView.TabIndex = 0;
            AvailableProductDataGridView.CellDoubleClick += AvailableProductDataGridView_CellDoubleClick;
            // 
            // ProductID
            // 
            ProductID.Frozen = true;
            ProductID.HeaderText = "Mã";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 60;
            // 
            // ProductName
            // 
            ProductName.Frozen = true;
            ProductName.HeaderText = "Tên";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 120;
            // 
            // ProductPrice
            // 
            ProductPrice.Frozen = true;
            ProductPrice.HeaderText = "Giá";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            ProductPrice.Width = 120;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 37);
            panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(258, 8);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(36, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(300, 8);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(60, 8);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(192, 23);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(InvoiceDetailDataGridView, 0, 1);
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(393, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.219178F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 91.78082F));
            tableLayoutPanel4.Size = new Size(384, 511);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // InvoiceDetailDataGridView
            // 
            InvoiceDetailDataGridView.AllowUserToAddRows = false;
            InvoiceDetailDataGridView.AllowUserToDeleteRows = false;
            InvoiceDetailDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceDetailDataGridView.Columns.AddRange(new DataGridViewColumn[] { InvoiceProductID, InvoiceProductName, InvoicePrice, InvoiceQuantity, InvoiceTotal });
            InvoiceDetailDataGridView.Dock = DockStyle.Fill;
            InvoiceDetailDataGridView.Location = new Point(3, 45);
            InvoiceDetailDataGridView.Name = "InvoiceDetailDataGridView";
            InvoiceDetailDataGridView.ReadOnly = true;
            InvoiceDetailDataGridView.Size = new Size(378, 463);
            InvoiceDetailDataGridView.TabIndex = 0;
            // 
            // InvoiceProductID
            // 
            InvoiceProductID.Frozen = true;
            InvoiceProductID.HeaderText = "Mã";
            InvoiceProductID.Name = "InvoiceProductID";
            InvoiceProductID.ReadOnly = true;
            // 
            // InvoiceProductName
            // 
            InvoiceProductName.Frozen = true;
            InvoiceProductName.HeaderText = "Tên";
            InvoiceProductName.Name = "InvoiceProductName";
            InvoiceProductName.ReadOnly = true;
            // 
            // InvoicePrice
            // 
            InvoicePrice.Frozen = true;
            InvoicePrice.HeaderText = "Đơn giá";
            InvoicePrice.Name = "InvoicePrice";
            InvoicePrice.ReadOnly = true;
            // 
            // InvoiceQuantity
            // 
            InvoiceQuantity.Frozen = true;
            InvoiceQuantity.HeaderText = "Số lượng";
            InvoiceQuantity.Name = "InvoiceQuantity";
            InvoiceQuantity.ReadOnly = true;
            // 
            // InvoiceTotal
            // 
            InvoiceTotal.Frozen = true;
            InvoiceTotal.HeaderText = "Thành tiền";
            InvoiceTotal.Name = "InvoiceTotal";
            InvoiceTotal.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(payBtn);
            panel3.Controls.Add(resetBtn);
            panel3.Controls.Add(deleteItemBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 36);
            panel3.TabIndex = 1;
            // 
            // payBtn
            // 
            payBtn.BackColor = Color.Lime;
            payBtn.FlatStyle = FlatStyle.Flat;
            payBtn.Location = new Point(279, 7);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(96, 23);
            payBtn.TabIndex = 2;
            payBtn.Text = "Thanh toán";
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += payBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(84, 7);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Tạo mới";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // deleteItemBtn
            // 
            deleteItemBtn.Location = new Point(3, 7);
            deleteItemBtn.Name = "deleteItemBtn";
            deleteItemBtn.Size = new Size(75, 23);
            deleteItemBtn.TabIndex = 0;
            deleteItemBtn.Text = "Xóa";
            deleteItemBtn.UseVisualStyleBackColor = true;
            deleteItemBtn.Click += deleteItemBtn_Click;
            // 
            // richTextBox1
            // 
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 2);
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(774, 481);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 490);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(683, 70);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(692, 490);
            button1.Name = "button1";
            button1.Size = new Size(85, 70);
            button1.TabIndex = 2;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 621);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            createInvoice.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AvailableProductDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoiceDetailDataGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem InvoiceMenu;
        private ToolStripMenuItem EmployeeMenu;
        private ToolStripMenuItem InventoryMenu;
        private ToolStripMenuItem StartShift;
        private ToolStripMenuItem EndShift;
        private ToolStripMenuItem trạngTháiCửaHàngToolStripMenuItem;
        private ToolStripMenuItem CloseStatusMenu;
        private ToolStripMenuItem OpenStatusMenu;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage createInvoice;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView AvailableProductDataGridView;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private Panel panel2;
        private Button AddBtn;
        private TextBox searchTextBox;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView InvoiceDetailDataGridView;
        private Label TotalLabel;
        private Label label2;
        private Panel panel3;
        private Button resetBtn;
        private Button deleteItemBtn;
        private Button payBtn;
        private DataGridViewTextBoxColumn InvoiceProductID;
        private DataGridViewTextBoxColumn InvoiceProductName;
        private DataGridViewTextBoxColumn InvoicePrice;
        private DataGridViewTextBoxColumn InvoiceQuantity;
        private DataGridViewTextBoxColumn InvoiceTotal;
        private Label label3;
        private ComboBox EmployeeComboBox;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}