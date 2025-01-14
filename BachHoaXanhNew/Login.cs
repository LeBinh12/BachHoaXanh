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

namespace BachHoaXanhNew
{
    public partial class Login : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        public Login()
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


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Bạn cần Nhập đầy đủ dữ liệu!");
                return;
            }

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (checkAdmin.Checked == true)
            {
                var check = data.Admins.SingleOrDefault(p => p.EMAIL == email && p.PASSWORD == password);

                if (check != null)
                {
                    Home home = new Home(check.ID_ADMIN, 1);
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không chính xác!");
                }
            } else
            {
                string passworHash = HashPassword(password);
                 var check = data.Employees.SingleOrDefault(p => p.EMAIL_EMPLOYEE == email && p.PASSWORD == passworHash);
                if (check != null)
                {
                    Home home = new Home(check.ID_EMPLOYEE, 2);
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không chính xác!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
