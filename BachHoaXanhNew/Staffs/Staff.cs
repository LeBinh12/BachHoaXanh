using BachHoaXanhNew.Data;
using BachHoaXanhNew.Staffs.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Staffs
{
    public partial class Staff : Form
    {
        private int selectedEmployeeId;
        ApplicationDbContext data = new ApplicationDbContext();
        private Form parentForm;

        public Staff(Form parent)
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
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnAddSippliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStaff(this));
        }

        public void LoadPage()
        {
            var employeesWithBranch = (from employee in data.Employees
                                      join branch in data.Branches on employee.ID_BRANCH equals branch.ID_BRANCH
                                      select new
                                      {
                                          employee.ID_EMPLOYEE,
                                          employee.FULLNAME_EMPLOYEE,
                                          employee.EMAIL_EMPLOYEE,
                                          employee.PHONE_EMPLOYEE,
                                          BranchName = branch.NAME_BRANCH// Lấy tên chi nhánh từ bảng Branch
                                      }).ToList();
            dtgvStaff.DataSource = employeesWithBranch;

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void panelbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnUpdateSippliers_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId > 0) // Kiểm tra nếu ID hợp lệ
            {
                OpenChildForm(new UpdateStaff(selectedEmployeeId)); // Mở form cập nhật
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột ID (giả sử ID nằm ở cột đầu tiên)
                var selectedRow = dtgvStaff.Rows[e.RowIndex];
                selectedEmployeeId = Convert.ToInt32(selectedRow.Cells["ID_EMPLOYEE"].Value);
            }
        }

        private void btnDeleteSippliers_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId > 0) // Kiểm tra nếu ID hợp lệ
            {
                OpenChildForm(new DeleteStaff(selectedEmployeeId)); // Mở form cập nhật
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idSearch = 0;
            if (int.TryParse(txtSearchId.Text, out idSearch))
            {
            }
            string nameSearch = "";
            if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                nameSearch += txtSearchName.Text;
            }

            var productSearch = data.Employees.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.FULLNAME_EMPLOYEE.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_EMPLOYEE == idSearch)
            ).ToList();


            dtgvStaff.DataSource = productSearch;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (parentForm is Home mainForm)
            {
                mainForm.LoadSatff(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
