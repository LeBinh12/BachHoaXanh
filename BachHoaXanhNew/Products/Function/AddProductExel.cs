using BachHoaXanhNew.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Products.Function
{
    public partial class AddProductExel : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        public AddProductExel()
        {
            InitializeComponent();
        }

        private DataTable ReadExcelToDataTable(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                DataTable dt = new DataTable();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                    int rowCount = worksheet.Dimension.Rows; // Số hàng trong sheet
                    int colCount = worksheet.Dimension.Columns; // Số cột trong sheet

                    // Tạo cột cho DataTable từ hàng tiêu đề (hàng 1)
                    for (int col = 1; col <= colCount; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value?.ToString()?.Trim());
                    }

                    // Lấy dữ liệu từ file Excel, bắt đầu từ hàng 2 (dữ liệu)
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            dr[col - 1] = worksheet.Cells[row, col].Value?.ToString()?.Trim();
                        }
                        dt.Rows.Add(dr);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void DisplayExcelOnDataGridView(string filePath)
        {
            DataTable dt = ReadExcelToDataTable(filePath);

            if (dt != null && dt.Rows.Count > 0)
            {
                dtgvProduct.DataSource = dt; // Hiển thị dữ liệu lên DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ImportProductsFromExcel(string filePath)
        {
            
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DisplayExcelOnDataGridView(filePath);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgvProduct.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string productName = row.Cells["Tên sản phẩm"].Value?.ToString()?.Trim();
                        int quantity = int.Parse(row.Cells["Số lượng"].Value?.ToString()?.Trim());
                        string supplierName = row.Cells["Nhà cung cấp"].Value?.ToString()?.Trim();
                        decimal price = decimal.Parse(row.Cells["Giá"].Value?.ToString()?.Trim());
                        string categoryName = row.Cells["Loại sản phẩm"].Value?.ToString()?.Trim();

                        // Lấy ID của nhà cung cấp
                        var supplier = data.Suppliers.SingleOrDefault(s => s.NAME_SUPPLIER == supplierName);
                        if (supplier == null)
                        {
                            MessageBox.Show($"Nhà cung cấp '{supplierName}' không tồn tại. Bỏ qua sản phẩm: {productName}");
                            continue;
                        }

                        // Lấy ID của loại sản phẩm
                        var category = data.Categories.SingleOrDefault(c => c.NAME_CATEGORY == categoryName);
                        if (category == null)
                        {
                            MessageBox.Show($"Loại sản phẩm '{categoryName}' không tồn tại. Bỏ qua sản phẩm: {productName}");
                            continue;
                        }

                        // Thêm sản phẩm mới vào cơ sở dữ liệu
                        Product product = new Product
                        {
                            NAME_PRODUCT = productName,
                            QUANTITY_STOCK = quantity,
                            ID_SUPPLIER = supplier.ID_SUPPLIER,
                            PRICE = price,
                            ID_CATEGORY = category.ID_CATEGORY
                        };

                        data.Products.Add(product);
                    }
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                data.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
