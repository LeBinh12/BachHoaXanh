using BachHoaXanhNew.Data;
using BachHoaXanhNew.Products.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Products
{
    public partial class Productss : Form
    {
        int id_product;
        ApplicationDbContext data = new ApplicationDbContext();

        public Productss()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadProduct()
        {
            var product = data.Products.ToList();
            dtgvProduct.DataSource = product;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddProducts(this));
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateProducts(this,id_product));

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteProducts(this, id_product));

        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột ID (giả sử ID nằm ở cột đầu tiên)
                var selectedRow = dtgvProduct.Rows[e.RowIndex];
                id_product = Convert.ToInt32(selectedRow.Cells["ID_PRODUCT"].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
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

        private void btnLoadPage_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
