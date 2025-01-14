using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Bill
    {
        [Key]
        public int ID_BILL { get; set; }
        public DateTime BILL_DATE { get; set; }
        public int ID_EMPLOYEE { get; set; }
        public int ID_CUSTOMER { get; set; }
        public decimal TOTAL { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }

}
