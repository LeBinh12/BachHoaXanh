using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Supplier
    {
        [Key]
        public int ID_SUPPLIER { get; set; }
        public string NAME_SUPPLIER { get; set; }
        public string ADDRESS_SUPPLIER { get; set; }
        public string PHONE_SUPPLIER { get; set; }
        public string EMAIL_SUPPLIER { get; set; }
        public DateTime CONTRACT_START_DATE { get; set; }
        public DateTime CONTRACT_END_DATE { get; set; }
        public string CONTACT { get; set; }
        public string NOTE { get; set; }    
    }
}
