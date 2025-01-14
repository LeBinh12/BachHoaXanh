namespace BachHoaXanhNew
{
    partial class Home
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBranch = new System.Windows.Forms.Label();
            this.btnBranch = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Controls.Add(this.btnBill);
            this.guna2Panel2.Controls.Add(this.lblUser);
            this.guna2Panel2.Controls.Add(this.btnBranch);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.btnProduct);
            this.guna2Panel2.Controls.Add(this.btnCategory);
            this.guna2Panel2.Controls.Add(this.btnSupplier);
            this.guna2Panel2.Controls.Add(this.btnStaff);
            this.guna2Panel2.Controls.Add(this.btnChangePassword);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(302, 1055);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(37, 39);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(177, 38);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Họ và Tên";
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(302, 145);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1622, 910);
            this.panelBody.TabIndex = 3;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.lblBranch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(302, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1622, 145);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblBranch
            // 
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(0, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(1630, 155);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "HỆ THỐNG QUẢN LÝ BÁCH HÓA XANH";
            this.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBranch.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBranch.BorderRadius = 10;
            this.btnBranch.BorderThickness = 1;
            this.btnBranch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBranch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBranch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBranch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBranch.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranch.ForeColor = System.Drawing.Color.Black;
            this.btnBranch.Image = global::BachHoaXanhNew.Properties.Resources.Bill;
            this.btnBranch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBranch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBranch.Location = new System.Drawing.Point(12, 741);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(273, 66);
            this.btnBranch.TabIndex = 8;
            this.btnBranch.Text = "Chi Nhánh";
            this.btnBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderThickness = 1;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::BachHoaXanhNew.Properties.Resources.logout_icon;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(12, 833);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(273, 66);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Đăng Xuất";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnProduct.BorderRadius = 10;
            this.btnProduct.BorderThickness = 1;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Image = global::BachHoaXanhNew.Properties.Resources.Product;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageSize = new System.Drawing.Size(40, 40);
            this.btnProduct.Location = new System.Drawing.Point(12, 565);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(273, 66);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCategory.BorderRadius = 10;
            this.btnCategory.BorderThickness = 1;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.Image = global::BachHoaXanhNew.Properties.Resources.Category;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCategory.Location = new System.Drawing.Point(12, 483);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(273, 66);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Loại Sản Phẩm";
            this.btnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSupplier.BorderRadius = 10;
            this.btnSupplier.BorderThickness = 1;
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnSupplier.Image = global::BachHoaXanhNew.Properties.Resources.supplier;
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSupplier.Location = new System.Drawing.Point(12, 402);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(273, 66);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Nhà Cung Cấp";
            this.btnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStaff.BorderRadius = 10;
            this.btnStaff.BorderThickness = 1;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = global::BachHoaXanhNew.Properties.Resources.User_Group_icon;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStaff.Location = new System.Drawing.Point(12, 318);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(273, 66);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Nhân Viên";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePassword.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChangePassword.BorderRadius = 10;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Image = global::BachHoaXanhNew.Properties.Resources.Loading;
            this.btnChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePassword.ImageSize = new System.Drawing.Size(40, 40);
            this.btnChangePassword.Location = new System.Drawing.Point(12, 236);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(273, 66);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePassword.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnBill
            // 
            this.btnBill.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBill.BorderRadius = 10;
            this.btnBill.BorderThickness = 1;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.PapayaWhip;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.Black;
            this.btnBill.Image = global::BachHoaXanhNew.Properties.Resources.Bill;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBill.Location = new System.Drawing.Point(12, 649);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(273, 66);
            this.btnBill.TabIndex = 10;
            this.btnBill.Text = "Thanh Toán";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private System.Windows.Forms.Label lblBranch;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBranch;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2Button btnBill;
    }
}