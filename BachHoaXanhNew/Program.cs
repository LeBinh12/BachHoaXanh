using BachHoaXanh.QuanLySupplier.Function;
using BachHoaXanhNew.Data;
using BachHoaXanhNew.Products.Function;
using BachHoaXanhNew.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

    }
}
