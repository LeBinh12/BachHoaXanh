using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew.Properties
{
    public class Admin
    {
        public int ID_ADMIN { get; set; }
        public string FULLNAME_ADMIN { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_ADMIN { get; set; }

        // Khóa ngoại
        public int ID_BRANCH { get; set; }
        public virtual Branch Branch { get; set; }
    }

}
