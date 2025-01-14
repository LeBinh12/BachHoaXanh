namespace BachHoaXanhNew.Staffs.Functions
{
    partial class UpdateStaff
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
            this.label6 = new System.Windows.Forms.Label();
            this.gbRoleEmployee = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            this.cbPostion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbBrands = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(784, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 38);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quyền nhân viên";
            // 
            // gbRoleEmployee
            // 
            this.gbRoleEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRoleEmployee.ForeColor = System.Drawing.Color.Black;
            this.gbRoleEmployee.Location = new System.Drawing.Point(782, 126);
            this.gbRoleEmployee.Name = "gbRoleEmployee";
            this.gbRoleEmployee.Size = new System.Drawing.Size(656, 409);
            this.gbRoleEmployee.TabIndex = 30;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStaff.ForeColor = System.Drawing.Color.Black;
            this.btnAddStaff.Location = new System.Drawing.Point(1249, 547);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(180, 45);
            this.btnAddStaff.TabIndex = 29;
            this.btnAddStaff.Text = "Sửa";
            this.btnAddStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // cbPostion
            // 
            this.cbPostion.BackColor = System.Drawing.Color.Transparent;
            this.cbPostion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPostion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPostion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPostion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPostion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPostion.ItemHeight = 30;
            this.cbPostion.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cbPostion.Location = new System.Drawing.Point(280, 325);
            this.cbPostion.Name = "cbPostion";
            this.cbPostion.Size = new System.Drawing.Size(334, 36);
            this.cbPostion.TabIndex = 28;
            // 
            // cbBrands
            // 
            this.cbBrands.BackColor = System.Drawing.Color.Transparent;
            this.cbBrands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrands.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBrands.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBrands.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBrands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBrands.ItemHeight = 30;
            this.cbBrands.Location = new System.Drawing.Point(280, 388);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(334, 36);
            this.cbBrands.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Chi nhánh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chức vụ:";
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailEmployee.DefaultText = "";
            this.txtEmailEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailEmployee.Location = new System.Drawing.Point(280, 257);
            this.txtEmailEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.PasswordChar = '\0';
            this.txtEmailEmployee.PlaceholderText = "";
            this.txtEmailEmployee.SelectedText = "";
            this.txtEmailEmployee.Size = new System.Drawing.Size(334, 39);
            this.txtEmailEmployee.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email:";
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneEmployee.DefaultText = "";
            this.txtPhoneEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneEmployee.Location = new System.Drawing.Point(280, 194);
            this.txtPhoneEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.PasswordChar = '\0';
            this.txtPhoneEmployee.PlaceholderText = "";
            this.txtPhoneEmployee.SelectedText = "";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(334, 39);
            this.txtPhoneEmployee.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số điện thoại: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên nhân viên";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameEmployee.DefaultText = "";
            this.txtNameEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEmployee.Location = new System.Drawing.Point(280, 126);
            this.txtNameEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.PasswordChar = '\0';
            this.txtNameEmployee.PlaceholderText = "";
            this.txtNameEmployee.SelectedText = "";
            this.txtNameEmployee.Size = new System.Drawing.Size(334, 39);
            this.txtNameEmployee.TabIndex = 19;
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 677);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbRoleEmployee);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.cbPostion);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameEmployee);
            this.Name = "UpdateStaff";
            this.Text = "UpdateStaff";
            this.Load += new System.EventHandler(this.UpdateStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GroupBox gbRoleEmployee;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private Guna.UI2.WinForms.Guna2ComboBox cbPostion;
        private Guna.UI2.WinForms.Guna2ComboBox cbBrands;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailEmployee;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNameEmployee;
    }
}