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
            CreateInvoiceMenu = new ToolStripMenuItem();
            EmployeeMenu = new ToolStripMenuItem();
            StartShift = new ToolStripMenuItem();
            EndShift = new ToolStripMenuItem();
            InventoryMenu = new ToolStripMenuItem();
            trạngTháiCửaHàngToolStripMenuItem = new ToolStripMenuItem();
            CloseStatusMenu = new ToolStripMenuItem();
            OpenStatusMenu = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            myAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateInvoiceMenu, EmployeeMenu, InventoryMenu, trạngTháiCửaHàngToolStripMenuItem });
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(62, 20);
            myAccountToolStripMenuItem.Text = "Quản Lý";
            // 
            // CreateInvoiceMenu
            // 
            CreateInvoiceMenu.Name = "CreateInvoiceMenu";
            CreateInvoiceMenu.Size = new Size(179, 22);
            CreateInvoiceMenu.Text = "Tạo hóa đơn";
            CreateInvoiceMenu.Click += tạoHóaĐơnToolStripMenuItem_Click;
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
            // 
            // EndShift
            // 
            EndShift.Name = "EndShift";
            EndShift.Size = new Size(133, 22);
            EndShift.Text = "Kết thúc ca";
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
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 597);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem CreateInvoiceMenu;
        private ToolStripMenuItem EmployeeMenu;
        private ToolStripMenuItem InventoryMenu;
        private ToolStripMenuItem StartShift;
        private ToolStripMenuItem EndShift;
        private ToolStripMenuItem trạngTháiCửaHàngToolStripMenuItem;
        private ToolStripMenuItem CloseStatusMenu;
        private ToolStripMenuItem OpenStatusMenu;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}