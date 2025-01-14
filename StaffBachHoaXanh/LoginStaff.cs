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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StaffBachHoaXanh
{
    public partial class LoginStaff : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();

        public LoginStaff()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return;
            }

            string user = txtUser.Text;
            string password = HashPassword(txtPassword.Text);

            var employee = data.Employees.SingleOrDefault(p =>
                (p.EMAIL_EMPLOYEE == user || p.PHONE_EMPLOYEE == user) &&
                p.PASSWORD == password);


            if (employee != null)
            {
                HomeStaff home = new HomeStaff();
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");

        }
    }
}
