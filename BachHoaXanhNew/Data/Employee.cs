using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Employee
    {
        [Key]
        public int ID_EMPLOYEE { get; set; }
        public string FULLNAME_EMPLOYEE { get; set; }
        public string PHONE_EMPLOYEE { get; set; }
        public string EMAIL_EMPLOYEE { get; set; }

        public string PASSWORD { get; set; }

        // Khóa ngoại
        public int ID_BRANCH { get; set; }
        public string ID_POSITION { get; set; }

        public virtual Branch Branch { get; set; }

    }

}
