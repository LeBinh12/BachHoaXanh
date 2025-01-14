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

namespace BachHoaXanhNew
{
    public partial class ChangePassword : Form
    {
        int idUser;
        ApplicationDbContext data = new ApplicationDbContext();
        public ChangePassword(int id)
        {
            InitializeComponent();
            idUser = id;
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtChangePasswordNew.Text) || string.IsNullOrWhiteSpace(txtPasswordOld.Text)
                || string.IsNullOrWhiteSpace(txtPasswordNew.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                return;
            }
            string passwordOld = txtPasswordOld.Text;
            string passwordNew = txtPasswordNew.Text;
            string changePasswordNew = txtChangePasswordNew.Text;

            if(passwordNew == changePasswordNew)
            {
                var checkAdmin = data.Admins.SingleOrDefault(p => p.ID_ADMIN == idUser);
                if(checkAdmin != null)
                {
                    if(checkAdmin.PASSWORD == passwordOld)
                    {
                        checkAdmin.PASSWORD = passwordNew;
                        data.SaveChanges();
                        txtMessage.Text = "Thay đổi mật khẩu thành công";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không trùng khớp!");
                        return;
                    }
                } else
                {
                    var checkEmployee = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == idUser);
                    if(checkEmployee != null)
                    {
                        string passwordOldHash = HashPassword(passwordOld);
                        if(passwordOldHash == checkEmployee.PASSWORD)
                        {
                            string passwordNewHash = HashPassword(passwordNew);
                            checkEmployee.PASSWORD = passwordNewHash;
                            data.SaveChanges();
                            MessageBox.Show("Thay đổi mật khẩu thành công!");
                            return;
                        } else
                        {
                            MessageBox.Show("Mật khẩu cũ của bạn không trùng khớp!");
                            return;
                        }
                    } else
                    {
                        MessageBox.Show("Tài khoản của bạn có thể đã bị xóa!");
                        return;
                    }
                } 
            } else
            {
                MessageBox.Show("Mật khẩu của bạn không trùng khớp!");
            }

        }
    }
}
