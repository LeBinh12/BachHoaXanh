using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Branch
    {
        [Key]
        public int ID_BRANCH { get; set; }
        public string NAME_BRANCH { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE_BRANCH { get; set; }

        // Điều hướng tới các bảng khác
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }

}
