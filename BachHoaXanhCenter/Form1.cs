﻿using BachHoaXanhNew;
using StaffBachHoaXanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginStaff loginStaff = new LoginStaff();
            this.Hide();
            loginStaff.Show();
        }
    }
}
