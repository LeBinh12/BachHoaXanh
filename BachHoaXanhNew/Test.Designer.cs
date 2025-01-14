namespace BachHoaXanhNew
{
    partial class Test
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
            this.btnDeleteBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBill.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.Location = new System.Drawing.Point(646, 492);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteBill.TabIndex = 31;
            this.btnDeleteBill.Text = "X";
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnAddRight
            // 
            this.btnAddRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddRight.ForeColor = System.Drawing.Color.White;
            this.btnAddRight.Location = new System.Drawing.Point(646, 384);
            this.btnAddRight.Name = "btnAddRight";
            this.btnAddRight.Size = new System.Drawing.Size(180, 45);
            this.btnAddRight.TabIndex = 30;
            this.btnAddRight.Text = "-->";
            this.btnAddRight.Click += new System.EventHandler(this.btnAddRight_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Location = new System.Drawing.Point(1362, 713);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(180, 45);
            this.btnAddBill.TabIndex = 29;
            this.btnAddBill.Text = "Thanh Toán";
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Lọc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtNameSearch);
            this.groupBox1.Controls.Add(this.txtIDSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 132);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1554, 100);
            this.guna2Panel4.TabIndex = 25;
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(0, 244);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 24;
            this.dtgvProduct.Size = new System.Drawing.Size(506, 490);
            this.dtgvProduct.TabIndex = 32;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCT,
            this.NAME_PRODUCT,
            this.QUANTITY,
            this.PRICE});
            this.dtgvBill.Location = new System.Drawing.Point(986, 244);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(556, 439);
            this.dtgvBill.TabIndex = 33;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(1030, 713);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(315, 48);
            this.txtTotalPrice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(880, 732);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tổng tiền:";
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.HeaderText = "Mã sản phẩm";
            this.ID_PRODUCT.MinimumWidth = 6;
            this.ID_PRODUCT.Name = "ID_PRODUCT";
            this.ID_PRODUCT.Width = 125;
            // 
            // NAME_PRODUCT
            // 
            this.NAME_PRODUCT.HeaderText = "Tên sản phẩm";
            this.NAME_PRODUCT.MinimumWidth = 6;
            this.NAME_PRODUCT.Name = "NAME_PRODUCT";
            this.NAME_PRODUCT.Width = 125;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "Số lượng";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 125;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "Giá";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 125;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 911);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnAddRight);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2Panel4);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDeleteBill;
        private Guna.UI2.WinForms.Guna2Button btnAddRight;
        private Guna.UI2.WinForms.Guna2Button btnAddBill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.DataGridView dtgvBill;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}