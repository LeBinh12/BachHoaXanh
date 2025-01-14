using BachHoaXanhNew.Data;
using BachHoaXanhNew.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Branchss.Function
{
    public partial class AddBranch : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();
        public AddBranch(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void AddBranchs(string name, string address, string phone)
        {
            var checkName = data.Branches.SingleOrDefault(p => p.NAME_BRANCH == name);
            if(checkName == null)
            {
                Branch branch = new Branch 
                {
                    NAME_BRANCH = name,
                    ADDRESS = address,
                    PHONE_BRANCH = phone
                };

                data.Branches.Add(branch);
                data.SaveChanges();

                MessageBox.Show("Dữ liệu đã được thêm thành công");

            }
            else
            {
                MessageBox.Show("Chi nhánh này đã tồn tại");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBranchName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text)){
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return;
            }

            string name = txtBranchName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;

            AddBranchs(name, address, phone);
            if (parentForm is Branchs mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
