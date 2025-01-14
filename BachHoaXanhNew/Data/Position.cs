using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew
{
    public class Position
    {
        [Key]
        public int ID_POSITION { get; set; }
        public string NAME_POSITION { get; set; }
        public int WAGE { get; set; }
        public string DESCRIBE { get; set; }

        // Điều hướng tới Employee
        public virtual ICollection<Employee> Employees { get; set; }
    }

}
