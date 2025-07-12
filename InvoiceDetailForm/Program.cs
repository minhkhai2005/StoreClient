using System;
using System.Windows.Forms;

namespace Invoice_Detail
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InvoiceDetailForm.InvoiceDetail()); // <- Replace with your Form's class
        }
    }
}