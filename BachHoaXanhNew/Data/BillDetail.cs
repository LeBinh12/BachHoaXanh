﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class BillDetail
    {
        [Key]
        public int ID_BILLDETAIL { get; set; }
        public int ID_BILL { get; set; }
        public int ID_PRODUCT { get; set; }
        public int QUANTITY { get; set; }
        public decimal UNIT_PRICE { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }

}
