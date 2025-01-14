using BachHoaXanhNew.Categories;
using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BachHoaXanhNew.Products.Function
{
    public partial class AddProducts : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();

        public AddProducts(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSupplier();
        }

        private void LoadCategories()
        {
            var categories = data.Categories.ToList();
            foreach (var item in categories)
            {
                cbCategories.Items.Add(new KeyValuePair<int, string>(item.ID_CATEGORY, item.NAME_CATEGORY));
            }
            cbCategories.DisplayMember = "Value";  
            cbCategories.ValueMember = "Key";      
        } 

        private void LoadSupplier()
        {
            var categories = data.Suppliers.ToList();
            foreach (var item in categories)
            {
                cbSuppliers.Items.Add(new KeyValuePair<int, string>(item.ID_SUPPLIER, item.NAME_SUPPLIER));

            }
            cbSuppliers.DisplayMember = "Value";  
            cbSuppliers.ValueMember = "Key";      
        }

        private void AddProduct(string name, int category, int idsupplier, decimal price, int quantity)
        {
            var checkName = data.Products.SingleOrDefault(p => p.NAME_PRODUCT == name);
            if(checkName != null)
            {
                checkName.QUANTITY_STOCK += quantity;
            } else
            {
                Product product = new Product 
                {
                    NAME_PRODUCT = name,
                    ID_CATEGORY= category,
                    ID_SUPPLIER= idsupplier,
                    PRICE = price,
                    QUANTITY_STOCK = quantity
                };
                data.Products.Add(product);
            }
            data.SaveChanges();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text)
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

            AddProduct(name, idCategory, idSupplier, price, quantity);
            if (parentForm is Productss mainForm)
            {
                mainForm.LoadProduct(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProductExel_Click(object sender, EventArgs e)
        {
            AddProductExel addProductExel = new AddProductExel();
            addProductExel.ShowDialog();
        }
    }
}
