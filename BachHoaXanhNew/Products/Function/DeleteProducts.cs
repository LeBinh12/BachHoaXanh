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

namespace BachHoaXanhNew.Products.Function
{
    public partial class DeleteProducts : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();
        int product_id;
        public DeleteProducts(Form parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            product_id= id;
        }

        private void LoadCategories(int id)
        {
            var categories = data.Categories.ToList();
            categories = categories.OrderBy(c => c.ID_CATEGORY == id).ThenBy(c => c.ID_CATEGORY).ToList();
            foreach (var item in categories)
            {
                cbCategories.Items.Add(new KeyValuePair<int, string>(item.ID_CATEGORY, item.NAME_CATEGORY));
            }
            cbCategories.DisplayMember = "Value";
            cbCategories.ValueMember = "Key";
        }

        private void LoadSupplier(int id)
        {
            var suppliers = data.Suppliers.ToList();
            suppliers = suppliers.OrderBy(c => c.ID_SUPPLIER == id ? 0 : 1).ThenBy(c => c.ID_SUPPLIER).ToList();
            foreach (var item in suppliers)
            {
                cbSuppliers.Items.Add(new KeyValuePair<int, string>(item.ID_SUPPLIER, item.NAME_SUPPLIER));

            }
            cbSuppliers.DisplayMember = "Value";
            cbSuppliers.ValueMember = "Key";
        }

        private void LoadProduct(int id)
        {
            var products = data.Products.SingleOrDefault(p => p.ID_PRODUCT == id);
            if (products == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }

            txtPrice.Text = products.PRICE.ToString();
            txtProductName.Text = products.NAME_PRODUCT.ToString();
            txtQuantity.Text = products.QUANTITY_STOCK.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sản phẩm!");
                return;
            }

            int id = int.Parse(txtProductID.Text);

            LoadCategories(id);
            LoadSupplier(id);
            LoadProduct(id);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var product = data.Products.SingleOrDefault(p => p.ID_PRODUCT == product_id);
            data.Products.Remove(product);
            data.SaveChanges();


            MessageBox.Show("Đã xóa dữ liệu thành công!");

            if (parentForm is Productss mainForm)
            {
                mainForm.LoadProduct(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void DeleteProducts_Load(object sender, EventArgs e)
        {
            LoadProduct(product_id);
            LoadCategories(product_id);
            LoadSupplier(product_id);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
