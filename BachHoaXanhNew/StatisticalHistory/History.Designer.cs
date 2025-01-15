namespace BachHoaXanhNew
{
    partial class History
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYearRevenue = new System.Windows.Forms.Button();
            this.btnMonthRevenue = new System.Windows.Forms.Button();
            this.btnProductSellWell = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnProductSellWellExel = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthRevenueExel = new Guna.UI2.WinForms.Guna2Button();
            this.btnYearRevenueExel = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1693, 74);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thống Kê Và Lịch Sử Đơn Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtIDSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Lịch Sử";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(130, 56);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(236, 38);
            this.txtIDSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYearRevenue);
            this.groupBox2.Controls.Add(this.btnMonthRevenue);
            this.groupBox2.Controls.Add(this.btnProductSellWell);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(606, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // btnYearRevenue
            // 
            this.btnYearRevenue.Location = new System.Drawing.Point(636, 38);
            this.btnYearRevenue.Name = "btnYearRevenue";
            this.btnYearRevenue.Size = new System.Drawing.Size(244, 63);
            this.btnYearRevenue.TabIndex = 2;
            this.btnYearRevenue.Text = "Doanh thu năm";
            this.btnYearRevenue.UseVisualStyleBackColor = true;
            this.btnYearRevenue.Click += new System.EventHandler(this.btnYearRevenue_Click);
            // 
            // btnMonthRevenue
            // 
            this.btnMonthRevenue.Location = new System.Drawing.Point(341, 38);
            this.btnMonthRevenue.Name = "btnMonthRevenue";
            this.btnMonthRevenue.Size = new System.Drawing.Size(269, 63);
            this.btnMonthRevenue.TabIndex = 1;
            this.btnMonthRevenue.Text = "Doanh thu tháng";
            this.btnMonthRevenue.UseVisualStyleBackColor = true;
            this.btnMonthRevenue.Click += new System.EventHandler(this.btnMonthRevenue_Click);
            // 
            // btnProductSellWell
            // 
            this.btnProductSellWell.Location = new System.Drawing.Point(15, 37);
            this.btnProductSellWell.Name = "btnProductSellWell";
            this.btnProductSellWell.Size = new System.Drawing.Size(310, 63);
            this.btnProductSellWell.TabIndex = 0;
            this.btnProductSellWell.Text = "Đơn hàng bán chạy";
            this.btnProductSellWell.UseVisualStyleBackColor = true;
            this.btnProductSellWell.Click += new System.EventHandler(this.btnProductSellWell_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(7, 348);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1523, 469);
            this.dgvProduct.TabIndex = 12;
            // 
            // btnProductSellWellExel
            // 
            this.btnProductSellWellExel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSellWellExel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSellWellExel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductSellWellExel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductSellWellExel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductSellWellExel.ForeColor = System.Drawing.Color.White;
            this.btnProductSellWellExel.Location = new System.Drawing.Point(681, 215);
            this.btnProductSellWellExel.Name = "btnProductSellWellExel";
            this.btnProductSellWellExel.Size = new System.Drawing.Size(137, 48);
            this.btnProductSellWellExel.TabIndex = 13;
            this.btnProductSellWellExel.Text = "Xuất exel";
            this.btnProductSellWellExel.Click += new System.EventHandler(this.btnProductSellWellExel_Click);
            // 
            // btnMonthRevenueExel
            // 
            this.btnMonthRevenueExel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthRevenueExel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthRevenueExel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthRevenueExel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthRevenueExel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonthRevenueExel.ForeColor = System.Drawing.Color.White;
            this.btnMonthRevenueExel.Location = new System.Drawing.Point(1004, 215);
            this.btnMonthRevenueExel.Name = "btnMonthRevenueExel";
            this.btnMonthRevenueExel.Size = new System.Drawing.Size(137, 48);
            this.btnMonthRevenueExel.TabIndex = 14;
            this.btnMonthRevenueExel.Text = "Xuất exel";
            this.btnMonthRevenueExel.Click += new System.EventHandler(this.btnMonthRevenueExel_Click);
            // 
            // btnYearRevenueExel
            // 
            this.btnYearRevenueExel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYearRevenueExel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYearRevenueExel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYearRevenueExel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYearRevenueExel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYearRevenueExel.ForeColor = System.Drawing.Color.White;
            this.btnYearRevenueExel.Location = new System.Drawing.Point(1305, 215);
            this.btnYearRevenueExel.Name = "btnYearRevenueExel";
            this.btnYearRevenueExel.Size = new System.Drawing.Size(137, 48);
            this.btnYearRevenueExel.TabIndex = 15;
            this.btnYearRevenueExel.Text = "Xuất exel";
            this.btnYearRevenueExel.Click += new System.EventHandler(this.btnYearRevenueExel_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 1055);
            this.Controls.Add(this.btnYearRevenueExel);
            this.Controls.Add(this.btnMonthRevenueExel);
            this.Controls.Add(this.btnProductSellWellExel);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYearRevenue;
        private System.Windows.Forms.Button btnMonthRevenue;
        private System.Windows.Forms.Button btnProductSellWell;
        private System.Windows.Forms.DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2Button btnProductSellWellExel;
        private Guna.UI2.WinForms.Guna2Button btnMonthRevenueExel;
        private Guna.UI2.WinForms.Guna2Button btnYearRevenueExel;
    }
}