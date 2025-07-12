namespace InvoiceDetailForm
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
            this.invoice_Detail1 = new InvoiceDetailForm.Invoice_Detail();
            this.SuspendLayout();
            // 
            // invoice_Detail1
            // 
            this.invoice_Detail1.BackColor = System.Drawing.Color.White;
            this.invoice_Detail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoice_Detail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoice_Detail1.Location = new System.Drawing.Point(0, 0);
            this.invoice_Detail1.Margin = new System.Windows.Forms.Padding(2);
            this.invoice_Detail1.Name = "invoice_Detail1";
            this.invoice_Detail1.Size = new System.Drawing.Size(482, 645);
            this.invoice_Detail1.TabIndex = 0;
            this.invoice_Detail1.CancelClicked += new System.EventHandler(this.invoice_Detail1_CancelClicked);
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 645);
            this.Controls.Add(this.invoice_Detail1);
            this.Name = "InvoiceDetail";
            this.Text = "Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private Invoice_Detail invoice_Detail1;
    }
}