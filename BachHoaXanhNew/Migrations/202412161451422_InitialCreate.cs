namespace BachHoaXanhNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID_ADMIN = c.Int(nullable: false, identity: true),
                        FULLNAME_ADMIN = c.String(),
                        PASSWORD = c.String(),
                        EMAIL = c.String(),
                        PHONE_ADMIN = c.String(),
                        ID_BRANCH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ADMIN)
                .ForeignKey("dbo.Branches", t => t.ID_BRANCH, cascadeDelete: true)
                .Index(t => t.ID_BRANCH);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        ID_BRANCH = c.Int(nullable: false, identity: true),
                        NAME_BRANCH = c.String(),
                        ADDRESS = c.String(),
                        PHONE_BRANCH = c.String(),
                    })
                .PrimaryKey(t => t.ID_BRANCH);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID_EMPLOYEE = c.Int(nullable: false, identity: true),
                        FULLNAME_EMPLOYEE = c.String(),
                        PHONE_EMPLOYEE = c.String(),
                        EMAIL_EMPLOYEE = c.String(),
                        ID_BRANCH = c.Int(nullable: false),
                        ID_POSITION = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_EMPLOYEE)
                .ForeignKey("dbo.Branches", t => t.ID_BRANCH, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.ID_POSITION, cascadeDelete: true)
                .Index(t => t.ID_BRANCH)
                .Index(t => t.ID_POSITION);
            
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        ID_BILLDETAIL = c.Int(nullable: false, identity: true),
                        ID_BILL = c.Int(nullable: false),
                        ID_PRODUCT = c.Int(nullable: false),
                        QUANTITY = c.Int(nullable: false),
                        UNIT_PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_BILLDETAIL)
                .ForeignKey("dbo.Bills", t => t.ID_BILL, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ID_PRODUCT, cascadeDelete: true)
                .Index(t => t.ID_BILL)
                .Index(t => t.ID_PRODUCT);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        ID_BILL = c.Int(nullable: false, identity: true),
                        BILL_DATE = c.DateTime(nullable: false),
                        ID_EMPLOYEE = c.Int(nullable: false),
                        ID_CUSTOMER = c.Int(nullable: false),
                        TOTAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_BILL)
                .ForeignKey("dbo.Customers", t => t.ID_CUSTOMER, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.ID_EMPLOYEE, cascadeDelete: true)
                .Index(t => t.ID_EMPLOYEE)
                .Index(t => t.ID_CUSTOMER);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID_CUSTOMER = c.Int(nullable: false, identity: true),
                        FULLNAME_CUSTOMER = c.String(),
                        PHONE_CUSTOMER = c.String(),
                        ADDRESS_CUSTOMER = c.String(),
                        EMAIL_CUSTOMER = c.String(),
                        POINT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CUSTOMER);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID_PRODUCT = c.Int(nullable: false, identity: true),
                        NAME_PRODUCT = c.String(),
                        ID_CATEGORY = c.Int(nullable: false),
                        ID_SUPPLIER = c.Int(nullable: false),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTITY_STOCK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PRODUCT)
                .ForeignKey("dbo.Categories", t => t.ID_CATEGORY, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.ID_SUPPLIER, cascadeDelete: true)
                .Index(t => t.ID_CATEGORY)
                .Index(t => t.ID_SUPPLIER);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID_CATEGORY = c.Int(nullable: false, identity: true),
                        NAME_CATEGORY = c.String(),
                        DESCRIBE = c.String(),
                    })
                .PrimaryKey(t => t.ID_CATEGORY);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID_SUPPLIER = c.Int(nullable: false, identity: true),
                        NAME_SUPPLIER = c.String(),
                        ADDRESS_SUPPLIER = c.String(),
                        PHONE_SUPPLIER = c.String(),
                        EMAIL_SUPPLIER = c.String(),
                        CONTRACT_START_DATE = c.DateTime(nullable: false),
                        CONTRACT_END_DATE = c.DateTime(nullable: false),
                        CONTACT = c.String(),
                        NOTE = c.String(),
                    })
                .PrimaryKey(t => t.ID_SUPPLIER);
            
            CreateTable(
                "dbo.EmloyeeRoles",
                c => new
                    {
                        roleID = c.Int(nullable: false, identity: true),
                        roleName = c.String(),
                    })
                .PrimaryKey(t => t.roleID);
            
            CreateTable(
                "dbo.EmloyeeRolePermissions",
                c => new
                    {
                        roleId = c.Int(nullable: false),
                        emloyeeId = c.Int(nullable: false),
                        Employee_ID_EMPLOYEE = c.Int(),
                    })
                .PrimaryKey(t => new { t.roleId, t.emloyeeId })
                .ForeignKey("dbo.EmloyeeRoles", t => t.roleId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_ID_EMPLOYEE)
                .Index(t => t.roleId)
                .Index(t => t.Employee_ID_EMPLOYEE);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        ID_POSITION = c.Int(nullable: false, identity: true),
                        NAME_POSITION = c.String(),
                        WAGE = c.Int(nullable: false),
                        DESCRIBE = c.String(),
                    })
                .PrimaryKey(t => t.ID_POSITION);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ID_POSITION", "dbo.Positions");
            DropForeignKey("dbo.EmloyeeRolePermissions", "Employee_ID_EMPLOYEE", "dbo.Employees");
            DropForeignKey("dbo.EmloyeeRolePermissions", "roleId", "dbo.EmloyeeRoles");
            DropForeignKey("dbo.BillDetails", "ID_PRODUCT", "dbo.Products");
            DropForeignKey("dbo.Products", "ID_SUPPLIER", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "ID_CATEGORY", "dbo.Categories");
            DropForeignKey("dbo.Bills", "ID_EMPLOYEE", "dbo.Employees");
            DropForeignKey("dbo.Bills", "ID_CUSTOMER", "dbo.Customers");
            DropForeignKey("dbo.BillDetails", "ID_BILL", "dbo.Bills");
            DropForeignKey("dbo.Employees", "ID_BRANCH", "dbo.Branches");
            DropForeignKey("dbo.Admins", "ID_BRANCH", "dbo.Branches");
            DropIndex("dbo.EmloyeeRolePermissions", new[] { "Employee_ID_EMPLOYEE" });
            DropIndex("dbo.EmloyeeRolePermissions", new[] { "roleId" });
            DropIndex("dbo.Products", new[] { "ID_SUPPLIER" });
            DropIndex("dbo.Products", new[] { "ID_CATEGORY" });
            DropIndex("dbo.Bills", new[] { "ID_CUSTOMER" });
            DropIndex("dbo.Bills", new[] { "ID_EMPLOYEE" });
            DropIndex("dbo.BillDetails", new[] { "ID_PRODUCT" });
            DropIndex("dbo.BillDetails", new[] { "ID_BILL" });
            DropIndex("dbo.Employees", new[] { "ID_POSITION" });
            DropIndex("dbo.Employees", new[] { "ID_BRANCH" });
            DropIndex("dbo.Admins", new[] { "ID_BRANCH" });
            DropTable("dbo.Positions");
            DropTable("dbo.EmloyeeRolePermissions");
            DropTable("dbo.EmloyeeRoles");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Branches");
            DropTable("dbo.Admins");
        }
    }
}
