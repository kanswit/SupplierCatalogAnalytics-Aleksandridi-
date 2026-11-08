using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SupplierCatalogAnalytics
{
    public partial class FormMain : Form
    {
        private List<Product> supplierA;
        private List<Product> supplierB;
        private List<Product> currentData;

        public FormMain()
        {
            InitializeComponent();

            
            this.Text = "Аналитика каталогов (Supplier Catalog Analytics)";

            btnExcept.Text = "Только Поставщик А (Except)";
            btnIntersect.Text = "Общие товары (Intersect)";
            btnUnionSorted.Text = "Единый каталог (Union)";
            btnConcatDistinct.Text = "Сырой реестр (Concat)";

            rdbAsc.Text = "По возрастанию";
            rdbDesc.Text = "По убыванию";
            btnIntersect.Text = "Применить сортировку";
            

            InitializeData();
        }

        private void InitializeData()
        {
            supplierA = new List<Product>
            {
                new Product(1, "ThinkPad T14", "Laptops", 1200m, "Supplier A"),
                new Product(2, "Logitech MX Master 3", "Accessories", 100m, "Supplier A"),
                new Product(3, "Dell UltraSharp", "Monitors", 450m, "Supplier A"),
                new Product(4, "HDMI Cable", "Cables", 15m, "Supplier A")
            };

            supplierB = new List<Product>
            {
                new Product(5, "ThinkPad T14", "Laptops", 1150m, "Supplier B"),
                new Product(6, "Razer DeathAdder", "Accessories", 60m, "Supplier B"),
                new Product(7, "Dell UltraSharp", "Monitors", 440m, "Supplier B"),
                new Product(8, "Mechanical Keyboard", "Accessories", 120m, "Supplier B")
            };
        }

        private void UpdateUI(IEnumerable<Product> data)
        {
            currentData = data.ToList();
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = currentData;

            int count = currentData.Count;
            decimal avg = count > 0 ? currentData.Average(p => p.Price) : 0;
            lblStatus.Text = $"Записей: {count} | Средняя стоимость: {avg:C2}";
        }

        private void btnExcept_Click(object sender, EventArgs e)
        {
            var result = supplierA.Except(supplierB);
            UpdateUI(result);
        }

        private void btnIntersect_Click(object sender, EventArgs e)
        {
            var result = supplierA.Intersect(supplierB);
            UpdateUI(result);
        }

        private void btnUnionSorted_Click(object sender, EventArgs e)
        {
            var result = supplierA.Union(supplierB)
                                  .OrderBy(p => p.Category)
                                  .ThenByDescending(p => p.Price);
            UpdateUI(result);
        }

        private void btnConcatDistinct_Click(object sender, EventArgs e)
        {
            var result = supplierA.Concat(supplierB).Distinct();
            UpdateUI(result);
        }

        private void btnApplySort_Click(object sender, EventArgs e)
        {
            if (currentData == null || currentData.Count == 0) return;

            IEnumerable<Product> sortedResult;

            if (rdbAsc.Checked)
            {
                sortedResult = currentData.OrderBy(p => p.Category)
                                          .ThenBy(p => p.Price);
            }
            else
            {
                sortedResult = currentData.OrderBy(p => p.Category)
                                          .ThenByDescending(p => p.Price);
            }

            UpdateUI(sortedResult);
        }

        
        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rdbAsc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbDesc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }
    }
}