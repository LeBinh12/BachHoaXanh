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
            this.sippliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelbody = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteSippliers = new System.Windows.Forms.Button();
            this.btnUpdateSippliers = new System.Windows.Forms.Button();
            this.btnAddSippliers = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).BeginInit();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sippliersBindingSource
            // 
            this.sippliersBindingSource.DataMember = "Sippliers";
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.dtgvStaff);
            this.panelbody.Location = new System.Drawing.Point(0, 255);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(1674, 675);
            this.panelbody.TabIndex = 19;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(55, 6);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.RowTemplate.Height = 24;
            this.dtgvStaff.Size = new System.Drawing.Size(1607, 510);
            this.dtgvStaff.TabIndex = 5;
            this.dtgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1674, 76);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDeleteSippliers);
            this.groupBox2.Controls.Add(this.btnUpdateSippliers);
            this.groupBox2.Controls.Add(this.btnAddSippliers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(889, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(571, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 63);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteSippliers
            // 
            this.btnDeleteSippliers.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSippliers.Location = new System.Drawing.Point(386, 63);
            this.btnDeleteSippliers.Name = "btnDeleteSippliers";
            this.btnDeleteSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteSippliers.TabIndex = 2;
            this.btnDeleteSippliers.Text = "Xóa";
            this.btnDeleteSippliers.UseVisualStyleBackColor = false;
            this.btnDeleteSippliers.Click += new System.EventHandler(this.btnDeleteSippliers_Click);
            // 
            // btnUpdateSippliers
            // 
            this.btnUpdateSippliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateSippliers.Location = new System.Drawing.Point(201, 63);
            this.btnUpdateSippliers.Name = "btnUpdateSippliers";
            this.btnUpdateSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnUpdateSippliers.TabIndex = 1;
            this.btnUpdateSippliers.Text = "Sửa";
            this.btnUpdateSippliers.UseVisualStyleBackColor = false;
            this.btnUpdateSippliers.Click += new System.EventHandler(this.btnUpdateSippliers_Click);
            // 
            // btnAddSippliers
            // 
            this.btnAddSippliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddSippliers.Location = new System.Drawing.Point(16, 63);
            this.btnAddSippliers.Name = "btnAddSippliers";
            this.btnAddSippliers.Size = new System.Drawing.Size(179, 63);
            this.btnAddSippliers.TabIndex = 0;
            this.btnAddSippliers.Text = "Thêm";
            this.btnAddSippliers.UseVisualStyleBackColor = false;
            this.btnAddSippliers.Click += new System.EventHandler(this.btnAddSippliers_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSearchId.Location = new System.Drawing.Point(348, 52);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(278, 38);
            this.txtSearchId.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(662, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(348, 112);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(278, 38);
            this.txtSearchName.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.groupBox2);
            this.panelTop.Location = new System.Drawing.Point(0, 76);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1674, 179);
            this.panelTop.TabIndex = 18;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 930);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sippliersBindingSource)).EndInit();
            this.panelbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sippliersBindingSource;
        private Guna.UI2.WinForms.Guna2Panel panelbody;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeleteSippliers;
        private System.Windows.Forms.Button btnUpdateSippliers;
        private System.Windows.Forms.Button btnAddSippliers;
    }
}