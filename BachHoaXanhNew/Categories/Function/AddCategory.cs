using BachHoaXanhNew.Data;
using BachHoaXanhNew.Suppliers;
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
    public partial class AddCategory : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        private Form parentForm;

        public AddCategory(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;

        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void AddCategories(string name, string description)
        {
            var categories = data.Categories.SingleOrDefault(p => p.NAME_CATEGORY == name);
            if (categories == null)
            {
                Category category= new Category 
                {
                    NAME_CATEGORY = name,
                    DESCRIBE = description
                };
                data.Categories.Add(category);
                data.SaveChanges();
                MessageBox.Show("Dữ liệu đã thêm thành công với id là: " + category.ID_CATEGORY);
            } else
            {
                MessageBox.Show("Loại này đã tồn tại!");
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtCategoryDesription.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                return;
            }

            string name = txtCategoryName.Text;
            string description = txtCategoryDesription.Text;

            AddCategories(name, description);

            if (parentForm is Categoriess mainForm)
            {
                mainForm.LoadCategories(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
