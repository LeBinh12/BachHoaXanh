using BachHoaXanhNew.Data;
using BachHoaXanhNew.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Staffs.Functions
{
    public partial class AddStaff : Form
    {
        private Form parentForm;

        ApplicationDbContext data = new ApplicationDbContext();
        public AddStaff(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;

        }


        private string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);

                    // Mã hóa
                    byte[] hash = sha256.ComputeHash(bytes);

                    StringBuilder result = new StringBuilder();
                    foreach (byte b in hash)
                    {
                        result.Append(b.ToString("x2")); 
                    }

                    return result.ToString();
                }
            }


        private void LoadBrands()
            {
                var categories = data.Branches.ToList();
                foreach (var item in categories)
                {
                    cbBrands.Items.Add(new KeyValuePair<int, string>(item.ID_BRANCH, item.NAME_BRANCH));
                }
                cbBrands.DisplayMember = "Value";
                cbBrands.ValueMember = "Key";
            }

        private void LoadRoleEmployee()
        {
            try
            {
                var roles = data.emloyeeRoles.ToList(); 

                int yPosition = 20; 
                int xPosition = 20; 
                int maxPerColumn = 5; 
                int counter = 0; 

                foreach (var role in roles)
                {
                    CheckBox checkBox = new CheckBox
                    {
                        Text = role.roleName,
                        Name = $"chk{role.roleID}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(xPosition, yPosition),
                        Tag = role.roleID
                    };

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

        private void AddEmployeePermission(int employee)
        {
            try
            {
                foreach (Control control in gbRoleEmployee.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        int roleId = (int)checkBox.Tag;
                        var permission = new EmloyeeRolePermission
                        {
                            roleId = roleId,
                            emloyeeId = employee
                        };
                        data.emloyeeRolesPermission.Add(permission);
                    }
                }
                data.SaveChanges();
                MessageBox.Show("Quyền đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool AddEmployee(string name, string phone, string email, int branch,string postion, string password)
        {
            var check_Email = data.Employees.SingleOrDefault(p => p.EMAIL_EMPLOYEE == email);
            if (check_Email == null)
            {
                string hashedPassword = HashPassword(password);

                Employee employee = new Employee
                {
                    FULLNAME_EMPLOYEE = name,
                    PHONE_EMPLOYEE = phone,
                    EMAIL_EMPLOYEE = email,
                    ID_POSITION = postion,
                    PASSWORD= hashedPassword,
                    ID_BRANCH= branch,
                };
                data.Employees.Add(employee);
                data.SaveChanges();

                AddEmployeePermission(employee.ID_EMPLOYEE);
                return true;
            }
            else
                return false;
        }


            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtEmailEmployee.Text) || string.IsNullOrWhiteSpace(txtNameEmployee.Text)
                || string.IsNullOrWhiteSpace(txtPhoneEmployee.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtChangePassword.Text))
            {
                MessageBox.Show("Bạn cần phải điền đầy đủ thông tin");
                return;
            }


            var selected_Branch = (KeyValuePair<int, string>)cbBrands.SelectedItem;
            string name_Employee = txtNameEmployee.Text;
            string phone_Employee = txtPhoneEmployee.Text;
            string email_Employee = txtEmailEmployee.Text;
            string postion = cbPostion.Text;
            string password = txtPassword.Text;
            int branch = selected_Branch.Key;
            string changePassword = txtChangePassword.Text;

            if(password == changePassword)
            {
                if (AddEmployee(name_Employee, phone_Employee, email_Employee, branch, postion, password))
                {

                }
            } else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                password = string.Empty;
                changePassword= string.Empty;
                return;
            }





/*
            if (parentForm is Productss mainForm)
            {
                mainForm.LoadProduct(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();*/
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            LoadRoleEmployee();
            LoadBrands();
        }

        private void gbRoleEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
