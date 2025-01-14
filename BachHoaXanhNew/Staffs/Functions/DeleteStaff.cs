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

namespace BachHoaXanhNew.Staffs.Functions
{
    public partial class DeleteStaff : Form
    {
        int id_emloyee;
        ApplicationDbContext data = new ApplicationDbContext();

        public DeleteStaff(int id)
        {
            id_emloyee= id;
            InitializeComponent();
        }


        private void LoadRoleEmployee(int employeeId)
        {
            try
            {
                // Lấy danh sách quyền của nhân viên từ bảng liên kết
                var roles = (from er in data.emloyeeRolesPermission
                             join r in data.emloyeeRoles on er.roleId equals r.roleID
                             where er.emloyeeId == employeeId
                             select r).ToList();

                // Lấy danh sách tất cả các quyền (roles)
                var allRoles = data.emloyeeRoles.ToList();

                int yPosition = 20;
                int xPosition = 20;
                int maxPerColumn = 5;
                int counter = 0;

                foreach (var role in allRoles)
                {
                    // Tạo checkbox cho mỗi quyền
                    CheckBox checkBox = new CheckBox
                    {
                        Text = role.roleName,
                        Name = $"chk{role.roleID}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(xPosition, yPosition),
                        Tag = role.roleID
                    };

                    // Kiểm tra nếu nhân viên đã có quyền này
                    if (roles.Any(r => r.roleID == role.roleID))
                    {
                        checkBox.Checked = true; // Đánh dấu checkbox là checked
                    }

                    gbRoleEmployee.Controls.Add(checkBox);

                    yPosition += 30;
                    counter++;

                    if (counter >= maxPerColumn)
                    {
                        counter = 0;
                        yPosition = 20;
                        xPosition += 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải quyền: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrands(int id)
        {
            var categories = data.Branches.ToList();

            // Sắp xếp sao cho chi nhánh có ID = id sẽ xuất hiện đầu tiên
            categories = categories.OrderBy(c => c.ID_BRANCH == id ? 0 : 1).ThenBy(c => c.ID_BRANCH).ToList();

            // Thêm các item vào ComboBox
            cbBrands.Items.Clear(); // Đảm bảo ComboBox được làm mới
            foreach (var item in categories)
            {
                cbBrands.Items.Add(new KeyValuePair<int, string>(item.ID_BRANCH, item.NAME_BRANCH));
            }

            // Cài đặt các thuộc tính DisplayMember và ValueMember
            cbBrands.DisplayMember = "Value"; // Hiển thị tên chi nhánh
            cbBrands.ValueMember = "Key";    // Lưu trữ ID chi nhánh
        }

        private void LoadPageDelete(int id)
        {
            var employee = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == id);
            if (employee != null)
            {

                txtEmailEmployee.Text = employee.EMAIL_EMPLOYEE;
                txtNameEmployee.Text = employee.FULLNAME_EMPLOYEE.ToString();
                txtPhoneEmployee.Text = employee.PHONE_EMPLOYEE.ToString();
                cbPostion.Text = employee.ID_POSITION.ToString();

            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại");
                Staff staff = new Staff();
                this.Hide();
                staff.Show();
            }

        }


        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {
            LoadRoleEmployee(id_emloyee);
            LoadBrands(id_emloyee);
            LoadPageDelete(id_emloyee);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var staff = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == id_emloyee);
                    var role = data.emloyeeRolesPermission.Where(p => p.emloyeeId == id_emloyee);
                    var bill = data.Bills.Where(p => p.ID_EMPLOYEE == id_emloyee);

                    data.Employees.Remove(staff);
                    data.emloyeeRolesPermission.RemoveRange(role);
                    data.Bills.RemoveRange(bill);
                    data.SaveChanges();
                    MessageBox.Show("Dữ liệu đã xóa thành công");
                } catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: " + ex);
                }
            }
        }
    }
}
