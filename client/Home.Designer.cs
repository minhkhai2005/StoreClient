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
            tạoHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            khoHàngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, myAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(954, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(88, 24);
            homeToolStripMenuItem.Text = "Hệ Thống";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // myAccountToolStripMenuItem
            // 
            myAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoHóaĐơnToolStripMenuItem, nhânViênToolStripMenuItem, khoHàngToolStripMenuItem });
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(75, 24);
            myAccountToolStripMenuItem.Text = "Quản Lý";
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            tạoHóaĐơnToolStripMenuItem.Size = new Size(176, 26);
            tạoHóaĐơnToolStripMenuItem.Text = "Tạo hóa đơn";
            tạoHóaĐơnToolStripMenuItem.Click += tạoHóaĐơnToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(176, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // khoHàngToolStripMenuItem
            // 
            khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            khoHàngToolStripMenuItem.Size = new Size(176, 26);
            khoHàngToolStripMenuItem.Text = "Kho hàng";
            khoHàngToolStripMenuItem.Click += khoHàngToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 566);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem khoHàngToolStripMenuItem;
    }
}