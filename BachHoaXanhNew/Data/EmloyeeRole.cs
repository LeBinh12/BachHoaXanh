using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew.Data
{
    public class EmloyeeRole
    {
        [Key]
        public int roleID { get; set; }
        public string roleName { get; set; }

    }
}
