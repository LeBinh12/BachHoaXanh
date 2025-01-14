using BachHoaXanhNew;
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
using System.Xml.Linq;

namespace BachHoaXanh.QuanLySupplier.Function
{
    public partial class UpdateSupplier : Form
    {

        ApplicationDbContext data = new ApplicationDbContext();
        private Form parentForm;
        int idSupllier;

        public UpdateSupplier(Form parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            idSupllier = id;

        }


        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            LoadPageUpdate(idSupllier);
        }

        private void UpdateSuppliers(int supplierID, string supplierName, string phoneNumber, string email, string address, string contactName, DateTime contractStartDate, DateTime contractEndDate, string note)
        {

        }

        private void button1_Update(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox7_Leave(object sender, EventArgs e)
        {

        }

        private void LoadPageUpdate(int id)
        {
            var supplier = data.Suppliers.SingleOrDefault(p => p.ID_SUPPLIER == id);

            if(supplier == null)
            {
                MessageBox.Show("Mã công ty này không tồn tại!");
                return;
            }

            txtAddressSupplier.Text = supplier.ADDRESS_SUPPLIER.ToString();
            txtEmailSupplier.Text = supplier.EMAIL_SUPPLIER ?? "##";
            txtSupplierName.Text = supplier.NAME_SUPPLIER.ToString();
            txtSupplierContact.Text = supplier.CONTACT.ToString();
            txtSupplierPhone.Text = supplier.PHONE_SUPPLIER.ToString();
            dtpContractStartDates.Value = supplier.CONTRACT_START_DATE;
            dtpcontractEndDates.Value = supplier.CONTRACT_END_DATE;
            txtNoteSupplier.Text = supplier.NOTE.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


        }
        private void txtSupplierId_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateSupplier(int id, string name, string address, string phone,
            string email, DateTime contactStart, DateTime contactEnd, string contact, string note)
        {
            var checkEmail = data.Suppliers.SingleOrDefault(p => p.EMAIL_SUPPLIER == email);
            var checkId = data.Suppliers.SingleOrDefault(p => p.ID_SUPPLIER == id);

            if(checkId != null )
            {
                // Nếu email mới đã tồn tại và không phải email cũ, thì thông báo lỗi
                if (checkEmail != null && checkEmail.ID_SUPPLIER != id)
                {
                    MessageBox.Show("Email này đã tồn tại!");
                    return;
                }
                checkId.NAME_SUPPLIER = name;
                checkId.ADDRESS_SUPPLIER = address;
                checkId.PHONE_SUPPLIER = phone;
                checkId.CONTRACT_START_DATE = contactStart;
                checkId.CONTRACT_END_DATE = contactEnd;
                checkId.CONTACT = contact;
                checkId.NOTE = note;
                // Nếu email mới khác email cũ, thì cập nhật email
                if (checkId.EMAIL_SUPPLIER != email)
                {
                    checkId.EMAIL_SUPPLIER = email;
                }
                data.SaveChanges();
            } else
            {
                MessageBox.Show("Mã công ty này không tồn tại!");
                return;
            }
        }

        private void btnUpdateSuplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierId.Text))
            {
                MessageBox.Show("Bạn cần nhập mã để tìm");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddressSupplier.Text) || string.IsNullOrWhiteSpace(txtEmailSupplier.Text)
                || string.IsNullOrWhiteSpace(txtSupplierName.Text) || string.IsNullOrWhiteSpace(txtSupplierContact.Text)
                || string.IsNullOrWhiteSpace(txtSupplierPhone.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                return;
            }

            int id = int.Parse(txtSupplierId.Text);

            string nameSupplier = txtSupplierContact.Text;
            string addressSupplier = txtAddressSupplier.Text;
            string phoneSupplier = txtSupplierPhone.Text;
            string email = txtEmailSupplier.Text;
            string contact = txtSupplierContact.Text;
            DateTime contactStart = dtpContractStartDates.Value;
            DateTime contactEnd = dtpcontractEndDates.Value;
            string note = " " + txtNoteSupplier.Text;

            updateSupplier(id, nameSupplier, addressSupplier, phoneSupplier, email, contactStart, contactEnd, contact, note);
            if (parentForm is FormSuppliers mainForm)
            {
                mainForm.LoadPage(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
