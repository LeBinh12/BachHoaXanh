namespace BachHoaXanhNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PASSWORD", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "PASSWORD");
        }
    }
}
