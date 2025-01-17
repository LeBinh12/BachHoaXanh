using BachHoaXanhNew.Categories.Function;
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

namespace BachHoaXanhNew.Categories
{
    public partial class Categoriess : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        int idCategory;
        private Form parentForm;


        public Categoriess(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;

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
            panalBody.Controls.Add(childForm);
            panalBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadCategories()
        {

            var catrgories = data.Categories.ToList();
            dtgvCategories.DataSource = catrgories;

        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCategory((this)));
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateCategory(this, idCategory));

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteCategory(this,idCategory));
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void dtgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


            var productSearch = data.Categories.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.NAME_CATEGORY.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_CATEGORY == idSearch)
            ).ToList();

            dtgvCategories.DataSource = productSearch;
        }

        private void dtgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột ID (giả sử ID nằm ở cột đầu tiên)
                var selectedRow = dtgvCategories.Rows[e.RowIndex];
                idCategory = Convert.ToInt32(selectedRow.Cells["ID_CATEGORY"].Value);
            }
        }

        private void btnDeleteCategory_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (parentForm is Home mainForm)
            {
                mainForm.LoadCategories(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
