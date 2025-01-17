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

namespace BachHoaXanhNew.Categories.Function
{
    public partial class DeleteCategory : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        private Form parentForm;
        int idCategory;
        public DeleteCategory(Form parent, int idCategory)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.idCategory = idCategory;
        }

        void Loadcategories(int id)
        {
            var categories = data.Categories.SingleOrDefault(p => p.ID_CATEGORY == id);
            if (categories == null) MessageBox.Show("Dữ liệu không tồn tại");
            else
            {
                txtCategoryID.Text = categories.ID_CATEGORY.ToString();
                txtCategoryName.Text = categories.NAME_CATEGORY.ToString();
                txtCategoryDesription.Text = categories.DESCRIBE.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtCategoryID.Text);

            var categories = data.Categories.SingleOrDefault(p => p.ID_CATEGORY == id);

            if (categories == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại");
                return;
            }


            data.Categories.Remove(categories);
            data.SaveChanges();
            MessageBox.Show("Dữ liệu đã xóa thành công!");

            if (parentForm is Categoriess mainForm)
            {
                mainForm.LoadCategories(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryID.Text))
            {
                MessageBox.Show("Bạn cần nhạp mã để tìm kiếm!");
                return;
            }

            int id = int.Parse(txtCategoryID.Text);

            var categories = data.Categories.SingleOrDefault(p => p.ID_CATEGORY == id);

            if (categories == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại");
                return;
            }

            txtCategoryDesription.Text = categories.DESCRIBE.ToString();
            txtCategoryName.Text = categories.NAME_CATEGORY.ToString();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {
            Loadcategories(idCategory);
        }
    }
}
