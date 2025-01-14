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
using System.Xml.Serialization;

namespace BachHoaXanhNew.Branchss.Function
{
    public partial class UpdateBranch : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();
        int idBranch;
        public UpdateBranch(Form parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            idBranch = id;

        }

        private void LoadSearch(int id)
        {
            var checkBranchId = data.Branches.SingleOrDefault(p => p.ID_BRANCH == id);
            if(checkBranchId == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại!");
                return;
            }
            txtBranchId.Text = checkBranchId.ID_BRANCH.ToString();
            txtAddress.Text = checkBranchId.ADDRESS.ToString();
            txtBranchName.Text = checkBranchId.NAME_BRANCH.ToString();
            txtPhone.Text = checkBranchId.PHONE_BRANCH.ToString() ;
        }

        private void UpdateBranchs(int id,string name, string address, string phone)
        {
            var checkBranchId = data.Branches.SingleOrDefault(p => p.ID_BRANCH == id);
            if (checkBranchId == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại!");
                return;
            }

            checkBranchId.NAME_BRANCH = name;
            checkBranchId.PHONE_BRANCH = phone;
            checkBranchId.ADDRESS = address;

            data.SaveChanges();
            MessageBox.Show("Dữ liệu cập nhật thành công!");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBranchId.Text))
            {
                MessageBox.Show("Bạn cần nhập mã chi nhánh");
                return;
            }

            int id = int.Parse(txtBranchId.Text);


            if (string.IsNullOrWhiteSpace(txtBranchName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return;
            }

            string name = txtBranchName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;

            UpdateBranchs(id, name, address, phone);

            if (parentForm is Branchs mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void UpdateBranch_Load(object sender, EventArgs e)
        {
            LoadSearch(idBranch);
        }
    }
}
