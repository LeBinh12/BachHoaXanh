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
    public partial class UpdateProducts : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();
        int id_product;
        public UpdateProducts(Form parent, int id)
        {
            InitializeComponent();
            id_product= id;
            this.parentForm = parent;
        }

        private void LoadCategories(int id)
        {
            var categories = data.Categories.ToList();
            categories = categories.OrderBy(c => c.ID_CATEGORY == id ).ThenBy(c => c.ID_CATEGORY).ToList();
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
            if(products == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }
            txtProductID.Text = products.ID_PRODUCT.ToString();
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

        private void UpdateProduct(int id,string name, int category, int idsupplier, decimal price, int quantity)
        {
            var checkid = data.Products.SingleOrDefault(p => p.ID_PRODUCT == id);
            if (checkid == null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }


            checkid.NAME_PRODUCT = name;
            checkid.ID_CATEGORY = category;
            checkid.ID_SUPPLIER = idsupplier;
            checkid.PRICE = price;
            checkid.QUANTITY_STOCK = quantity;

            data.SaveChanges();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sản phẩm!");
                return;
            }

            int id = int.Parse(txtProductID.Text);


            if (string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text)
                || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ các thông tin");
                return;
            }
            var selectedSupplier = (KeyValuePair<int, string>)cbSuppliers.SelectedItem;
            var selectedCategory = (KeyValuePair<int, string>)cbCategories.SelectedItem;
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            int idCategory = selectedCategory.Key;
            int idSupplier = selectedSupplier.Key;

            UpdateProduct(id, name, idCategory, idSupplier, price, quantity);
            MessageBox.Show("Đã cập nhật dữ liệu thành công!");

            if (parentForm is Productss mainForm)
            {
                mainForm.LoadProduct(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadCategories(id_product);
            LoadSupplier(id_product);
            LoadProduct(id_product);
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
