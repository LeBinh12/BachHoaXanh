using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Customer
    {
        [Key]
        public int ID_CUSTOMER { get; set; }
        public string FULLNAME_CUSTOMER { get; set; }
        public string PHONE_CUSTOMER { get; set; }
        public string ADDRESS_CUSTOMER { get; set; }
        public string EMAIL_CUSTOMER { get; set; }
        public int POINT { get; set; }

        // Điều hướng tới Bill
        public virtual ICollection<Bill> Bills { get; set; }
    }

}
