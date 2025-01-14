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
    public partial class DeleteBranch : Form
    {
        private Form parentForm;
        ApplicationDbContext data = new ApplicationDbContext();
        int idBranch;
        public DeleteBranch(Form parent, int idBranch)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.idBranch = idBranch;
        }

        private void LoadSearch(int id)
        {
            var checkBranchId = data.Branches.SingleOrDefault(p => p.ID_BRANCH == id);
            if (checkBranchId == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại!");
                return;
            }
            txtBranchId.Text = checkBranchId.ID_BRANCH.ToString();
            txtAddress.Text = checkBranchId.ADDRESS.ToString();
            txtBranchName.Text = checkBranchId.NAME_BRANCH.ToString();
            txtPhone.Text = checkBranchId.PHONE_BRANCH.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBranchs(int id)
        {
            var checkBranchId = data.Branches.SingleOrDefault(p => p.ID_BRANCH == id);
            if (checkBranchId == null)
            {
                MessageBox.Show("Dữ liệu này không tồn tại!");
                return;
            }

            data.Branches.Remove(checkBranchId);
            data.SaveChanges();
            MessageBox.Show("Dữu liệu này đã được xóa");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBranchId.Text))
            {
                MessageBox.Show("Bạn cần nhập mã chi nhánh");
                return;
            }

            int id = int.Parse(txtBranchId.Text);

            DeleteBranchs(id);

            if (parentForm is Branchs mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void txtBranchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DeleteBranch_Load(object sender, EventArgs e)
        {
            LoadSearch(idBranch);
        }
    }
}
