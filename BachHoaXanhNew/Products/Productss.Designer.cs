namespace BachHoaXanhNew.Products
{
    partial class Productss
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
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadPage = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Location = new System.Drawing.Point(807, 263);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(923, 577);
            this.panelBody.TabIndex = 10;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Location = new System.Drawing.Point(5, 12);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1725, 100);
            this.guna2Panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // btnLoadPage
            // 
            this.btnLoadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPage.Location = new System.Drawing.Point(416, 37);
            this.btnLoadPage.Name = "btnLoadPage";
            this.btnLoadPage.Size = new System.Drawing.Size(179, 63);
            this.btnLoadPage.TabIndex = 3;
            this.btnLoadPage.Text = "Tải lại";
            this.btnLoadPage.UseVisualStyleBackColor = false;
            this.btnLoadPage.Click += new System.EventHandler(this.btnLoadPage_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Location = new System.Drawing.Point(617, 37);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateProduct.Location = new System.Drawing.Point(214, 37);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(179, 63);
            this.btnUpdateProduct.TabIndex = 1;
            this.btnUpdateProduct.Text = "Sửa";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Location = new System.Drawing.Point(15, 37);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(179, 63);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadPage);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.btnUpdateProduct);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(2, 263);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 24;
            this.dtgvProduct.Size = new System.Drawing.Size(799, 574);
            this.dtgvProduct.TabIndex = 9;
            this.dtgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.groupBox2);
            this.guna2Panel2.Location = new System.Drawing.Point(807, 119);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(923, 143);
            this.guna2Panel2.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(466, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(125, 73);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(294, 38);
            this.txtNameSearch.TabIndex = 3;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(125, 28);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(294, 38);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtNameSearch);
            this.groupBox1.Controls.Add(this.txtIDSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 119);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(799, 143);
            this.guna2Panel1.TabIndex = 6;
            // 
            // Productss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 1055);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Productss";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPage;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}