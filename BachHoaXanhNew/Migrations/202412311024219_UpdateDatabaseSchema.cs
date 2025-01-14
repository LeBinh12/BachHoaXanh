namespace BachHoaXanhNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "ID_POSITION", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "ID_POSITION" });
            AddColumn("dbo.Employees", "Position_ID_POSITION", c => c.Int());
            AlterColumn("dbo.Employees", "ID_POSITION", c => c.String());
            CreateIndex("dbo.Employees", "Position_ID_POSITION");
            AddForeignKey("dbo.Employees", "Position_ID_POSITION", "dbo.Positions", "ID_POSITION");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_ID_POSITION", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "Position_ID_POSITION" });
            AlterColumn("dbo.Employees", "ID_POSITION", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Position_ID_POSITION");
            CreateIndex("dbo.Employees", "ID_POSITION");
            AddForeignKey("dbo.Employees", "ID_POSITION", "dbo.Positions", "ID_POSITION", cascadeDelete: true);
        }
    }
}
