using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace BachHoaXanhNew.Data
{
    public class EmloyeeRolePermission
    {
        [Key]
        [Column(Order = 0)]
        public int roleId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int emloyeeId { get; set; }

        public virtual EmloyeeRole EmloyeeRole { get; set; }
        public virtual Employee  Employee { get; set; }

    }
}
