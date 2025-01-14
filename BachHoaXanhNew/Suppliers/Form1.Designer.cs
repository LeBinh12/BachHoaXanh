namespace BachHoaXanhNew.Suppliers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sippliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnDeleteSippliers = new System.Windows.Forms.Button();
            this.btnUpdateSippliers = new System.Windows.Forms.Button();
            this.btnAddSippliers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBodySupplier = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBodySupplier.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sippliersBindingSource
            // 
            this.sippliersBindingSource.DataMember = "Sippliers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNameSearch);
            this.groupBox1.Controls.Add(this.txtIDSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(125, 73);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(236, 38);
            this.txtNameSearch.TabIndex = 3;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(125, 28);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(236, 38);
            this.txtIDSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnDeleteSippliers
            // 
            this.btnDeleteSippliers.Location = new System.Drawing.Point(409, 37);
            this.btnDeleteSippliers.Name = "btnDeleteSippliers";
            this.btnDeleteSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteSippliers.TabIndex = 2;
            this.btnDeleteSippliers.Text = "Xóa";
            this.btnDeleteSippliers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSippliers
            // 
            this.btnUpdateSippliers.Location = new System.Drawing.Point(214, 37);
            this.btnUpdateSippliers.Name = "btnUpdateSippliers";
            this.btnUpdateSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnUpdateSippliers.TabIndex = 1;
            this.btnUpdateSippliers.Text = "Sửa";
            this.btnUpdateSippliers.UseVisualStyleBackColor = true;
            // 
            // btnAddSippliers
            // 
            this.btnAddSippliers.Location = new System.Drawing.Point(15, 37);
            this.btnAddSippliers.Name = "btnAddSippliers";
            this.btnAddSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnAddSippliers.TabIndex = 0;
            this.btnAddSippliers.Text = "Thêm";
            this.btnAddSippliers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSippliers);
            this.groupBox2.Controls.Add(this.btnUpdateSippliers);
            this.groupBox2.Controls.Add(this.btnAddSippliers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1693, 148);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Nhà Cung Cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 148);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(554, 907);
            this.guna2Panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.SupplierName,
            this.ContactName,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.ContractStartDate,
            this.ContractEndDate,
            this.Notes});
            this.dataGridView1.Location = new System.Drawing.Point(7, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 485);
            this.dataGridView1.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Tên";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 125;
            // 
            // ContactName
            // 
            this.ContactName.HeaderText = "Tên người liên hệ";
            this.ContactName.MinimumWidth = 6;
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            this.ContactName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // ContractStartDate
            // 
            this.ContractStartDate.HeaderText = "Ngày bắt đầu hợp đồng";
            this.ContractStartDate.MinimumWidth = 6;
            this.ContractStartDate.Name = "ContractStartDate";
            this.ContractStartDate.ReadOnly = true;
            this.ContractStartDate.Width = 125;
            // 
            // ContractEndDate
            // 
            this.ContractEndDate.HeaderText = "Ngày kết thúc hợp đồng";
            this.ContractEndDate.MinimumWidth = 6;
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.ReadOnly = true;
            this.ContractEndDate.Width = 125;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Ghi chú";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 125;
            // 
            // panelBodySupplier
            // 
            this.panelBodySupplier.Controls.Add(this.panel1);
            this.panelBodySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodySupplier.Location = new System.Drawing.Point(554, 148);
            this.panelBodySupplier.Name = "panelBodySupplier";
            this.panelBodySupplier.Size = new System.Drawing.Size(1139, 907);
            this.panelBodySupplier.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 140);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 1055);
            this.Controls.Add(this.panelBodySupplier);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBodySupplier.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sippliersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSippliers;
        private System.Windows.Forms.Button btnUpdateSippliers;
        private System.Windows.Forms.Button btnAddSippliers;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private Guna.UI2.WinForms.Guna2Panel panelBodySupplier;
        private System.Windows.Forms.Panel panel1;
    }
}