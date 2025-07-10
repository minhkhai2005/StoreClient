using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static client.Home;
using DatabaseClass;
using Microsoft.VisualBasic.Devices;

namespace client
{
    public partial class Inventory : Form
    {
        public List<DatabaseAccess.Inventory> inventoryList { get; set; } = new List<DatabaseAccess.Inventory>();
        public Dictionary<string, DatabaseAccess.Product> productDictionary { get; set; } = new Dictionary<string, DatabaseAccess.Product>();
        List<DataGridViewRow> rowsSoruce = new List<DataGridViewRow>();
        public Inventory()
        {
            InitializeComponent();
            TypeComboBox.Text = "Tất cả";
            Text = "Kho hàng";
        }
        // update data to dataGridview method
        public void UpdateData()
        {
            foreach (var inventory in inventoryList)
            {
                var product = productDictionary[inventory.Product_ID];
                InventoryDataGridView.Rows.Add(
                    inventory.Product_ID,
                    productDictionary[inventory.Product_ID].Product_Name,
                    productDictionary[inventory.Product_ID].Product_Price.ToString(),
                    inventory.Inventory_Stock.ToString(),
                    inventory.Inventory_AlertQuantity.ToString(),
                    inventory.Inventory_Status ? "Available" : "Unavailable"
                );
            }
            rowsSoruce = InventoryDataGridView.Rows.Cast<DataGridViewRow>().ToList();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {

            string filter = TypeComboBox.Text;
            string keyword = SearchTextBox.Text.ToLower();
            List<DataGridViewRow> filteredRows = rowsSoruce
                .Where(row =>
                    !row.IsNewRow && // Bỏ dòng trống
                    (filter == "Tất cả" || row.Cells[5].Value?.ToString() == filter) &&
                    (
                        row.Cells[1].Value?.ToString().ToLower().Contains(keyword) == true ||
                        row.Cells[0].Value?.ToString().ToLower().Contains(keyword) == true ||
                        keyword == ""
                    )
                )
                .ToList();
            InventoryDataGridView.Rows.Clear();
            InventoryDataGridView.Rows.AddRange(filteredRows.ToArray());
        }
    }
}
