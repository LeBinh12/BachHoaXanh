using BachHoaXanhNew.Branchss.Function;
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

namespace BachHoaXanhNew.Branchss
{
    public partial class Branchs : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        int idBranch;
        public Branchs()
        {
            InitializeComponent();
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
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddBranch(this));
        }

        private void btnUpdateBranch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateBranch(this, idBranch));
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteBranch(this, idBranch));
        }

        private void Branchs_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        public void LoadPage()
        {
            var branch = data.Branches.ToList();

            dtgvBranch.DataSource = branch;
        }

        private void dtgvBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtgvBranch.Rows[e.RowIndex];
                idBranch = Convert.ToInt32(selectedRow.Cells["ID_BRANCH"].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int idSearch = 0;
            if (int.TryParse(txtIDSearch.Text, out idSearch))
            {
            }
            string nameSearch = "";
            if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
            {
                nameSearch += txtNameSearch.Text;
            }


            var productSearch = data.Branches.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.NAME_BRANCH.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_BRANCH == idSearch)
            ).ToList();

            dtgvBranch.DataSource = productSearch;
        }
    }
}
