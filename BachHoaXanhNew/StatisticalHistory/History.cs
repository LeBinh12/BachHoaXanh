using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using OfficeOpenXml;
using System.IO;

namespace BachHoaXanhNew
{
    public partial class History : Form
    {
        private Form parentForm;

        ApplicationDbContext data = new ApplicationDbContext();
        public History(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;

        }

        public void LoadProduct()
        {
            var product = data.BillDetails.ToList();
            dgvProduct.DataSource = product;
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idSearch = 0;
            if (int.TryParse(txtIDSearch.Text, out idSearch))
            {
                // idSearch đã được gán giá trị từ txtIDSearch
            }


            var productSearch = data.BillDetails.Where(p =>
                (idSearch == 0 || p.ID_BILL == idSearch)
            ).ToList();

            dgvProduct.DataSource = productSearch;



        }

        private void dtpProductBill_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnProductSellWell_Click(object sender, EventArgs e)
        {
            try
            {
                var bestSellingProducts = data.BillDetails
                    .GroupBy(bd => bd.ID_PRODUCT) 
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY) 
                    })
                    .OrderByDescending(p => p.TotalQuantitySold) 
                    .Take(10) 
                    .ToList();


                var productList = bestSellingProducts
                    .Select(p => data.Products.FirstOrDefault(product => product.ID_PRODUCT == p.ProductId))
                    .ToList();

                dgvProduct.DataSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi hiển thị sản phẩm bán chạy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMonthRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

                var bestSellingProducts = data.BillDetails
                    .Where(bd => bd.TimeBill.Month == currentMonth && bd.TimeBill.Year == currentYear)
                    .GroupBy(bd => bd.ID_PRODUCT)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY),
                        TotalRevenue = g.Sum(bd => bd.QUANTITY * bd.UNIT_PRICE)
                    })
                    .OrderByDescending(p => p.TotalRevenue)
                    .Take(10)
                    .ToList();

                // Lấy thông tin chi tiết sản phẩm từ bảng Products
                var productList = bestSellingProducts
                    .Select(p => new
                    {
                        ProductName = data.Products.FirstOrDefault(product => product.ID_PRODUCT == p.ProductId)?.NAME_PRODUCT,
                        p.TotalQuantitySold,
                        p.TotalRevenue
                    })
                    .ToList();
                dgvProduct.DataSource = productList;

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYearRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

                var bestSellingProducts = data.BillDetails
                    .Where(bd => bd.TimeBill.Year == currentYear)
                    .GroupBy(bd => bd.ID_PRODUCT)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY),
                        TotalRevenue = g.Sum(bd => bd.QUANTITY * bd.UNIT_PRICE)
                    })
                    .OrderByDescending(p => p.TotalRevenue)
                    .Take(10)
                    .ToList();

                // Lấy thông tin chi tiết sản phẩm từ bảng Products
                var productList = bestSellingProducts
                    .Select(p => new
                    {
                        ProductName = data.Products.FirstOrDefault(product => product.ID_PRODUCT == p.ProductId)?.NAME_PRODUCT,
                        p.TotalQuantitySold,
                        p.TotalRevenue
                    })
                    .ToList();
                dgvProduct.DataSource = productList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExportToExcel(List<Product> productList)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    worksheet.Cells[1, 1].Value = "Product Name";
                    worksheet.Cells[1, 2].Value = "Total Quantity Sold";
                    worksheet.Cells[1, 3].Value = "Total Revenue";

                    for (int i = 0; i < productList.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = productList[i].NAME_PRODUCT;
                        worksheet.Cells[i + 2, 2].Value = productList[i].QUANTITY_STOCK;
                        worksheet.Cells[i + 2, 3].Value = productList[i].PRICE;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;
                        FileInfo fi = new FileInfo(filePath);
                        package.SaveAs(fi);  // Lưu file tại đường dẫn người dùng chọn

                        MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductSellWellExel_Click(object sender, EventArgs e)
        {
            try
            {
                var bestSellingProducts = data.BillDetails
                    .GroupBy(bd => bd.ID_PRODUCT)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY),
                        TotalRevenue = g.Sum(bd => bd.QUANTITY * bd.UNIT_PRICE) 
                    })
                    .OrderByDescending(p => p.TotalRevenue) 
                    .Take(10) 
                    .ToList();

                var productIds = bestSellingProducts.Select(p => p.ProductId).ToList();
                var products = data.Products
                    .Where(p => productIds.Contains(p.ID_PRODUCT))
                    .ToList();

                var productList = bestSellingProducts
                    .Join(products,
                        bd => bd.ProductId,
                        p => p.ID_PRODUCT,
                        (bd, p) => new
                        {
                            ProductName = p.NAME_PRODUCT,
                            bd.TotalQuantitySold,
                            bd.TotalRevenue
                        })
                    .ToList();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                using (ExcelPackage excel = new ExcelPackage())
                {
                    var sheet = excel.Workbook.Worksheets.Add("Sheet1");
                    sheet.Cells[1, 1].Value = "Tên sản phẩm";
                    sheet.Cells[1, 2].Value = "Số lượng đã bán";
                    sheet.Cells[1, 3].Value = "Doanh thu";

                    int row = 2;
                    foreach (var item in productList)
                    {
                        sheet.Cells[row, 1].Value = item.ProductName;
                        sheet.Cells[row, 2].Value = item.TotalQuantitySold;
                        sheet.Cells[row, 3].Value = item.TotalRevenue;

                        row++;
                    }

                    sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                    string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string filePath = Path.Combine(downloadPath, "Top10Products.xlsx");
                    File.WriteAllBytes(filePath, excel.GetAsByteArray());

                    MessageBox.Show($"File Excel đã được lưu tại: {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnMonthRevenueExel_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

                var bestSellingProducts = data.BillDetails
                    .Where(bd => bd.TimeBill.Month == currentMonth && bd.TimeBill.Year == currentYear)
                    .GroupBy(bd => bd.ID_PRODUCT)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY),
                        TotalRevenue = g.Sum(bd => bd.QUANTITY * bd.UNIT_PRICE)
                    })
                    .OrderByDescending(p => p.TotalRevenue)
                    .Take(10)
                    .ToList();

                // Lấy thông tin chi tiết sản phẩm từ bảng Products
                var productList = bestSellingProducts
                    .Select(p => new
                    {
                        ProductName = data.Products.FirstOrDefault(product => product.ID_PRODUCT == p.ProductId)?.NAME_PRODUCT,
                        p.TotalQuantitySold,
                        p.TotalRevenue
                    })
                    .ToList();

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
                using (var excelPackage = new ExcelPackage())
                {
                    var worksheet = excelPackage.Workbook.Worksheets.Add("BestSellingProducts");

                    worksheet.Cells[1, 1].Value = "Tên sản phẩm";
                    worksheet.Cells[1, 2].Value = "Số lượng bán";
                    worksheet.Cells[1, 3].Value = "Doanh thu";

                    int row = 2;
                    foreach (var product in productList)
                    {
                        worksheet.Cells[row, 1].Value = product.ProductName;
                        worksheet.Cells[row, 2].Value = product.TotalQuantitySold;
                        worksheet.Cells[row, 3].Value = product.TotalRevenue;
                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "TopProductsMonth.xlsx");

                    FileInfo file = new FileInfo(filePath);
                    excelPackage.SaveAs(file);

                    // Thông báo hoàn tất
                    MessageBox.Show($"Đã xuất file Excel thành công tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYearRevenueExel_Click(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;

                var bestSellingProducts = data.BillDetails
                    .Where(bd => bd.TimeBill.Year == currentYear)
                    .GroupBy(bd => bd.ID_PRODUCT)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalQuantitySold = g.Sum(bd => bd.QUANTITY),
                        TotalRevenue = g.Sum(bd => bd.QUANTITY * bd.UNIT_PRICE)
                    })
                    .OrderByDescending(p => p.TotalRevenue)
                    .Take(10)
                    .ToList();

                var productList = bestSellingProducts
                    .Select(p => new
                    {
                        ProductName = data.Products.FirstOrDefault(product => product.ID_PRODUCT == p.ProductId)?.NAME_PRODUCT,
                        p.TotalQuantitySold,
                        p.TotalRevenue
                    })
                    .ToList();

                using (var excelPackage = new ExcelPackage())
                {
                    var worksheet = excelPackage.Workbook.Worksheets.Add("BestSellingProducts");

                    worksheet.Cells[1, 1].Value = "Tên sản phẩm";
                    worksheet.Cells[1, 2].Value = "Số lượng bán";
                    worksheet.Cells[1, 3].Value = "Doanh thu";

                    int row = 2;
                    foreach (var product in productList)
                    {
                        worksheet.Cells[row, 1].Value = product.ProductName;
                        worksheet.Cells[row, 2].Value = product.TotalQuantitySold;
                        worksheet.Cells[row, 3].Value = product.TotalRevenue;
                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "TopProductsYear.xlsx");

                    FileInfo file = new FileInfo(filePath);
                    excelPackage.SaveAs(file);

                    MessageBox.Show($"Đã xuất file Excel thành công tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
