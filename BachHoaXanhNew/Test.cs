using BachHoaXanhNew.Data;
using OfficeOpenXml.Export.HtmlExport.StyleCollectors.StyleContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew
{
    public partial class Test : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();

        public Test()
        {
            InitializeComponent();
        }

        public void LoadProduct()
        {
            var product = data.Products.ToList();
            dtgvProduct.DataSource = product;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnAddRight_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;
                if (dtgvProduct.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dtgvProduct.SelectedRows)
                    {
                        if (selectedRow.Cells["NAME_PRODUCT"].Value != null &&
                            selectedRow.Cells["PRICE"].Value != null)
                        {
                            string productId = selectedRow.Cells["ID_PRODUCT"].Value.ToString();
                            string productName = selectedRow.Cells["NAME_PRODUCT"].Value.ToString();
                            decimal price = Convert.ToDecimal(selectedRow.Cells["PRICE"].Value);
                            int quantity = 1;

                            bool isProductExists = false;

                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                if (row.Cells["NAME_PRODUCT"].Value != null &&
                                    row.Cells["NAME_PRODUCT"].Value.ToString() == productName)
                                {
                                    row.Cells["QUANTITY"].Value = Convert.ToInt32(row.Cells["QUANTITY"].Value ?? 0) + 1;
                                    isProductExists = true;
                                    break;
                                }
                            }

                            if (!isProductExists)
                            {
                                dtgvBill.Rows.Add(productId, productName, quantity, price);
                            }

                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                if (row.Cells["PRICE"].Value != null && row.Cells["QUANTITY"].Value != null)
                                {
                                    decimal rowPrice = Convert.ToDecimal(row.Cells["PRICE"].Value);
                                    int rowQuantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);
                                    totalPrice += rowPrice * rowQuantity;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtTotalPrice.Text = string.Format("{0:N0} VNĐ", totalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idSearch = 0;
            if (int.TryParse(txtIDSearch.Text, out idSearch))
            {
            }
            string nameSearch = "";
            if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
            {
                nameSearch += txtNameSearch.Text;
            }


            var productSearch = data.Products.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.NAME_PRODUCT.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_PRODUCT == idSearch)
            ).ToList();

            dtgvProduct.DataSource = productSearch;
        }

        private void UpdateProductStockInDatabase(int productId, int newStock)
        {
            using (var context = new ApplicationDbContext())
            {
                var product = context.Products.SingleOrDefault(p => p.ID_PRODUCT == productId);
                if (product != null)
                {
                    product.QUANTITY_STOCK = newStock;
                    context.SaveChanges();
                }
            }
        }

        private void RefreshProductGrid()
        {
            using (var context = new ApplicationDbContext())
            {
                var products = context.Products.ToList();
                dtgvProduct.DataSource = products;
            }
        }


        private void SaveBillDetails(int billId, decimal totalPrice)
        {
            try
            {
                foreach (DataGridViewRow row in dtgvBill.Rows)
                {
                    if (row.Cells["ID_PRODUCT"].Value != null && row.Cells["QUANTITY"].Value != null)
                    {
                        int productId = Convert.ToInt32(row.Cells["ID_PRODUCT"].Value);
                        int quantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);

                        // Lấy giá sản phẩm từ cơ sở dữ liệu
                        decimal unitPrice = GetProductPrice(productId);

                        var billDetail = new HistoryBillDetail
                        {
                            ID_BILL = billId,
                            ID_PRODUCT = productId,
                            QUANTITY = quantity,
                            UNIT_PRICE = unitPrice,
                            TimeBill = DateTime.Now
                        };

                        data.BillDetails.Add(billDetail);
                    }
                }

                data.SaveChanges();

                MessageBox.Show("Thông tin hóa đơn chi tiết đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu hóa đơn chi tiết: {ex.Message}\n" +
                                $"Chi tiết lỗi: {ex.InnerException?.Message}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal GetProductPrice(int productId)
        {
            var product = data.Products.FirstOrDefault(p => p.ID_PRODUCT == productId);
            return product != null ? product.PRICE : 0; // Trả về giá của sản phẩm hoặc 0 nếu không tìm thấy
        }


        private int GenerateUniqueBillId()
        {
            Random random = new Random();
            int billId;

            do
            {
                billId = random.Next(100000, 999999); 
            }
            while (data.BillDetails.Any(b => b.ID_BILL == billId));

            return billId;
        }


        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                int idBill = GenerateUniqueBillId();
                decimal totalPrice;

                string rawTotalPrice = txtTotalPrice.Text.Replace("VNĐ", "").Replace(",", "").Trim();

                if (string.IsNullOrWhiteSpace(rawTotalPrice) || !decimal.TryParse(rawTotalPrice, out totalPrice) || totalPrice <= 0)
                {
                    MessageBox.Show("Tổng tiền không hợp lệ! Vui lòng nhập giá trị hợp lệ (lớn hơn 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtgvBill.Rows.Count > 0 && dtgvBill.Rows[0].IsNewRow)
                {
                    dtgvBill.Rows.RemoveAt(0);
                }

                foreach (DataGridViewRow row in dtgvBill.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["ID_PRODUCT"].Value == null || row.Cells["QUANTITY"].Value == null)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ trong bảng hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int productId = Convert.ToInt32(row.Cells["ID_PRODUCT"].Value);
                    int quantityToBuy = Convert.ToInt32(row.Cells["QUANTITY"].Value);

                    var productRow = dtgvProduct.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID_PRODUCT"].Value) == productId);
                    if (productRow != null)
                    {
                        int currentStock = Convert.ToInt32(productRow.Cells["QUANTITY_STOCK"].Value);

                        if (currentStock >= quantityToBuy)
                        {
                            int newStock = currentStock - quantityToBuy;
                            productRow.Cells["QUANTITY_STOCK"].Value = newStock;
                            UpdateProductStockInDatabase(productId, newStock);
                        }
                        else
                        {
                            MessageBox.Show($"Sản phẩm {row.Cells["NAME_PRODUCT"].Value} không đủ số lượng trong kho!",
                                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                SaveBillDetails(idBill, totalPrice);

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dtgvBill.Rows.Clear();
                RefreshProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBill.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dtgvBill.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            dtgvBill.Rows.Remove(selectedRow);
                        }
                    }

                    decimal totalPrice = 0;
                    foreach (DataGridViewRow row in dtgvBill.Rows)
                    {
                        if (row.Cells["PRICE"].Value != null && row.Cells["QUANTITY"].Value != null)
                        {
                            decimal price = Convert.ToDecimal(row.Cells["PRICE"].Value);
                            int quantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);
                            totalPrice += price * quantity;
                        }
                    }

                    txtTotalPrice.Text = string.Format("{0:N0} VNĐ", totalPrice);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
