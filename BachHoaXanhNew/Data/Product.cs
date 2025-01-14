using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Product
    {
        [Key]
        public int ID_PRODUCT { get; set; }
        public string NAME_PRODUCT { get; set; }
        public int ID_CATEGORY { get; set; }
        public int ID_SUPPLIER { get; set; }
        public decimal PRICE { get; set; }
        public int QUANTITY_STOCK { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }

}
