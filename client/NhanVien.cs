using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;

namespace client
{

    public partial class NhanVien : Form
    {
        private List<DatabaseAccess.Employee> employees = new List<DatabaseAccess.Employee>();
        private List<DataGridViewRow> rowsSource = new List<DataGridViewRow>();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void FetchEmployeesList(string storeID)
        {
            employees = DatabaseAccess.GetEmployeesByStoreID(storeID);
        }
        public void UpdateEmployeeData()
        {
            EmployeeDataGridView.Rows.Clear();
            rowsSource.Clear();
            foreach (var employee in employees)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(EmployeeDataGridView);
                row.Cells[0].Value = employee.Employee_ID;
                row.Cells[1].Value = employee.Employee_Name;
                row.Cells[2].Value = employee.Employee_Gender ? "Nữ" : "Nam";
                row.Cells[3].Value = employee.Employee_Birth.ToShortDateString();
                row.Cells[4].Value = employee.Employee_PhoneNumber;
                row.Cells[5].Value = employee.Employee_Email;
                EmployeeDataGridView.Rows.Add(row);
                rowsSource.Add(row);
            }
        }
        private void NhanVien_Shown(object sender, EventArgs e)
        {
            UpdateEmployeeData();
        }
        private void search()
        {
            string keyword = SearchTextBox.Text.ToLower();
            List<DataGridViewRow> filteredRows = rowsSource
                .Where(row =>
                    !row.IsNewRow && // Bỏ dòng trống
                    (
                        row.Cells[1].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[0].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[4].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[5].Value?.ToString().ToLower().Contains(keyword) == true ||
                        keyword == ""
                    )
                )
                .ToList();
            EmployeeDataGridView.Rows.Clear();
            EmployeeDataGridView.Rows.AddRange(filteredRows.ToArray());
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
