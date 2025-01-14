using BachHoaXanhNew.Data;
using BachHoaXanhNew.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh.QuanLySupplier.Function
{
    public partial class DeleteSupplier : Form
    {

        ApplicationDbContext data = new ApplicationDbContext();
        private Form parentForm;
        int idSupplier;
        public DeleteSupplier(Form parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            idSupplier = id;
        }

        private void LoadPageUpdate(int id)
        {
            var supplier = data.Suppliers.SingleOrDefault(p => p.ID_SUPPLIER == id);

            if (supplier == null)
            {
                MessageBox.Show("Mã công ty này không tồn tại!");
                return;
            }

            txtAddress.Text = supplier.ADDRESS_SUPPLIER.ToString();
            txtEmail.Text = supplier.EMAIL_SUPPLIER ?? "##";
            txtNameSuplier.Text = supplier.NAME_SUPPLIER.ToString();
            txtNameContact.Text = supplier.CONTACT.ToString();
            txtPhone.Text = supplier.PHONE_SUPPLIER.ToString();
            dtpContractStartDate.Value = supplier.CONTRACT_START_DATE;
            dtpcontractEndDate.Value = supplier.CONTRACT_END_DATE;
            txtNote.Text = supplier.NOTE.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }



        private void DeleteSupplier_Load(object sender, EventArgs e)
        {
            LoadPageDelete(idSupplier);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            
        }

        private void LoadPageDelete(int id)
        {
            var supplier = data.Suppliers.SingleOrDefault(p => p.ID_SUPPLIER == id);

            if (supplier == null)
            {
                MessageBox.Show("Mã công ty này không tồn tại!");
                return;
            }

            txtAddress.Text = supplier.ADDRESS_SUPPLIER.ToString();
            txtEmail.Text = supplier.EMAIL_SUPPLIER ?? "##";
            txtNameSuplier.Text = supplier.NAME_SUPPLIER.ToString();
            txtNameContact.Text = supplier.CONTACT.ToString();
            txtPhone.Text = supplier.PHONE_SUPPLIER.ToString();
            dtpcontractEndDate.Value = supplier.CONTRACT_START_DATE;
            dtpcontractEndDate.Value = supplier.CONTRACT_END_DATE;
            txtNote.Text = supplier.NOTE.ToString();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Bạn cần nhập mã để tìm");
                return;
            }
            int id = int.Parse(txtId.Text);

            LoadPageDelete(id);


        }

        private void DeleteSuppliers(int id)
        {
            var checkId = data.Suppliers.SingleOrDefault(p => p.ID_SUPPLIER == id);

            if (checkId != null)
            {
                data.Suppliers.Remove(checkId);
                data.SaveChanges();
            }
            else
            {
                MessageBox.Show("Mã công ty này không tồn tại!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DeleteSuppliers(id);

            if (parentForm is FormSuppliers mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
