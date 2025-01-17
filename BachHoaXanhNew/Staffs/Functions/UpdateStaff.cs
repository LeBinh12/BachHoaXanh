using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Staffs.Functions
{
    public partial class UpdateStaff : Form
    {
        private int employeeId;
        ApplicationDbContext data = new ApplicationDbContext();

        public UpdateStaff(int id)
        {
            InitializeComponent();
            employeeId = id;

        }

        private void LoadBrands(int id)
        {
            var categories = data.Branches.ToList();

            categories = categories.OrderBy(c => c.ID_BRANCH == id ? 0 : 1).ThenBy(c => c.ID_BRANCH).ToList();

            cbBrands.Items.Clear();
            foreach (var item in categories)
            {
                cbBrands.Items.Add(new KeyValuePair<int, string>(item.ID_BRANCH, item.NAME_BRANCH));
            }

            cbBrands.DisplayMember = "Value"; 
            cbBrands.ValueMember = "Key";
        }



        private void LoadRoleEmployee(int employeeId)
        {
            try
            {
                var roles = (from er in data.emloyeeRolesPermission
                             join r in data.emloyeeRoles on er.roleId equals r.roleID
                             where er.emloyeeId == employeeId
                             select r).ToList();

                var allRoles = data.emloyeeRoles.ToList();

                int yPosition = 20;
                int xPosition = 20;
                int maxPerColumn = 5;
                int counter = 0;

                foreach (var role in allRoles)
                {
                    CheckBox checkBox = new CheckBox
                    {
                        Text = role.roleName,
                        Name = $"chk{role.roleID}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(xPosition, yPosition),
                        Tag = role.roleID
                    };

                    if (roles.Any(r => r.roleID == role.roleID))
                    {
                        checkBox.Checked = true; 
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

        private void LoadPageUpdate(int id)
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
                this.Hide();
            }

        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            LoadPageUpdate(employeeId);
            LoadBrands(employeeId);
            LoadRoleEmployee(employeeId);
        }

        private void UpdateEmployeePermission(int employeeId)
        {
            try
            {
                var currentPermissions = data.emloyeeRolesPermission
                    .Where(p => p.emloyeeId == employeeId)
                    .ToList();

                foreach (Control control in gbRoleEmployee.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        int roleId = (int)checkBox.Tag;

                        if (checkBox.Checked)
                        {
                            if (!currentPermissions.Any(p => p.roleId == roleId))
                            {
                                var newPermission = new EmloyeeRolePermission
                                {
                                    roleId = roleId,
                                    emloyeeId = employeeId
                                };
                                data.emloyeeRolesPermission.Add(newPermission);
                            }
                        }
                        else
                        {
                            var permissionToRemove = currentPermissions
                                .FirstOrDefault(p => p.roleId == roleId);

                            if (permissionToRemove != null)
                            {
                                data.emloyeeRolesPermission.Remove(permissionToRemove);
                            }
                        }
                    }
                }

                data.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật quyền nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool UpdateEmployee(int employeeId, string name, string phone, string email, int branch, string position)
        {
            try
            {
                var employee = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == employeeId);

                if (employee != null)
                {
                    var check_Email = data.Employees
                        .SingleOrDefault(p => p.EMAIL_EMPLOYEE == email && p.ID_EMPLOYEE != employeeId);

                    if (check_Email != null)
                    {
                        MessageBox.Show("Email này đã được sử dụng bởi nhân viên khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    employee.FULLNAME_EMPLOYEE = name;
                    employee.PHONE_EMPLOYEE = phone;
                    employee.EMAIL_EMPLOYEE = email;
                    employee.ID_POSITION = position;
                    employee.ID_BRANCH = branch;

                    UpdateEmployeePermission(employeeId);

                    data.SaveChanges();

                    MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailEmployee.Text)
                || string.IsNullOrWhiteSpace(txtNameEmployee.Text)
                || string.IsNullOrWhiteSpace(txtPhoneEmployee.Text))
            {
                MessageBox.Show("Bạn cần phải điền đầy đủ thông tin");
                return;
            }

            // Lấy thông tin từ các điều khiển
            var selected_Branch = (KeyValuePair<int, string>)cbBrands.SelectedItem;
            string name_Employee = txtNameEmployee.Text;
            string phone_Employee = txtPhoneEmployee.Text;
            string email_Employee = txtEmailEmployee.Text;
            string postion = cbPostion.Text;
            int branch = selected_Branch.Key;
            try
            {

                bool success = UpdateEmployee(employeeId, name_Employee, phone_Employee, email_Employee, branch, postion);

                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thất bại. Vui lòng kiểm tra dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
