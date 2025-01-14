namespace BachHoaXanhNew.Staffs
{
    partial class Staff
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSippliers = new System.Windows.Forms.Button();
            this.btnUpdateSippliers = new System.Windows.Forms.Button();
            this.btnAddSippliers = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbody = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.sippliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.groupBox2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 66);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1924, 140);
            this.panelTop.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(427, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(185, 76);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(236, 38);
            this.txtSearchName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSippliers);
            this.groupBox2.Controls.Add(this.btnUpdateSippliers);
            this.groupBox2.Controls.Add(this.btnAddSippliers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(756, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnDeleteSippliers
            // 
            this.btnDeleteSippliers.Location = new System.Drawing.Point(409, 37);
            this.btnDeleteSippliers.Name = "btnDeleteSippliers";
            this.btnDeleteSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteSippliers.TabIndex = 2;
            this.btnDeleteSippliers.Text = "Xóa";
            this.btnDeleteSippliers.UseVisualStyleBackColor = true;
            this.btnDeleteSippliers.Click += new System.EventHandler(this.btnDeleteSippliers_Click);
            // 
            // btnUpdateSippliers
            // 
            this.btnUpdateSippliers.Location = new System.Drawing.Point(214, 37);
            this.btnUpdateSippliers.Name = "btnUpdateSippliers";
            this.btnUpdateSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnUpdateSippliers.TabIndex = 1;
            this.btnUpdateSippliers.Text = "Sửa";
            this.btnUpdateSippliers.UseVisualStyleBackColor = true;
            this.btnUpdateSippliers.Click += new System.EventHandler(this.btnUpdateSippliers_Click);
            // 
            // btnAddSippliers
            // 
            this.btnAddSippliers.Location = new System.Drawing.Point(15, 37);
            this.btnAddSippliers.Name = "btnAddSippliers";
            this.btnAddSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnAddSippliers.TabIndex = 0;
            this.btnAddSippliers.Text = "Thêm";
            this.btnAddSippliers.UseVisualStyleBackColor = true;
            this.btnAddSippliers.Click += new System.EventHandler(this.btnAddSippliers_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1924, 66);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.dtgvStaff);
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(0, 206);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(1924, 724);
            this.panelbody.TabIndex = 16;
            this.panelbody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbody_Paint);
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(15, 112);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.RowTemplate.Height = 24;
            this.dtgvStaff.Size = new System.Drawing.Size(1668, 485);
            this.dtgvStaff.TabIndex = 5;
            this.dtgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sippliersBindingSource
            // 
            this.sippliersBindingSource.DataMember = "Sippliers";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(185, 32);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(236, 38);
            this.txtSearchId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 930);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSippliers;
        private System.Windows.Forms.Button btnUpdateSippliers;
        private System.Windows.Forms.Button btnAddSippliers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource sippliersBindingSource;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelbody;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchId;
    }
}