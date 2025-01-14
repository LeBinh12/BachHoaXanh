using BachHoaXanhNew.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanhNew.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }

        public DbSet<EmloyeeRole> emloyeeRoles { get; set; }
        public DbSet<EmloyeeRolePermission> emloyeeRolesPermission { get; set;}
    }

}
