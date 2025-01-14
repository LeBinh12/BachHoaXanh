using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Category
    {
        [Key]
        public int ID_CATEGORY { get; set; }
        public string NAME_CATEGORY { get; set; }
        public string DESCRIBE { get; set; }

    }

}
