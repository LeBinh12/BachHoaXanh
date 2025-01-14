using BachHoaXanhNew;
using BachHoaXanhNew.Data;
using BachHoaXanhNew.Suppliers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh.QuanLySupplier.Function
{
    public partial class AddSupplier : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();

        private Form parentForm;

        public AddSupplier(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddSuppliers(string name, string address, string phone,
            string email, DateTime contactStart, DateTime contactEnd, string contact, string note)
        {
            var checkEmail = data.Suppliers.SingleOrDefault(p => p.EMAIL_SUPPLIER == email);
            if (checkEmail != null)
            {
                MessageBox.Show("Email này đã tồn tại");
                return;
            }
            Supplier supplier = new Supplier{
                NAME_SUPPLIER = name,
                ADDRESS_SUPPLIER = address,
                PHONE_SUPPLIER = phone,
                CONTRACT_START_DATE = contactStart,
                CONTRACT_END_DATE = contactEnd,
                CONTACT = contact,
                NOTE = note,
                EMAIL_SUPPLIER = email
            };

            data.Suppliers.Add(supplier);
            data.SaveChanges();
        }

        private void btnAddSuplier_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtNameSuplier.Text) || string.IsNullOrWhiteSpace(txtNameContact.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                return;
            }


            string nameSupplier = txtNameSuplier.Text;
            string addressSupplier = txtAddress.Text;
            string phoneSupplier = txtPhone.Text;
            string email = txtEmail.Text;
            string contact = txtNameContact.Text;
            DateTime contactStart = dtpContractStartDate.Value;
            DateTime contactEnd = dtpcontractEndDate.Value;
            string note = " " + txtNote.Text;

            AddSuppliers(nameSupplier, addressSupplier, phoneSupplier, email, contactStart, contactEnd, contact, note);



            if (parentForm is FormSuppliers mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
