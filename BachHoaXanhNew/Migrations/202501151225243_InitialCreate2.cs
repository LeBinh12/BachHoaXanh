namespace BachHoaXanhNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BillDetails", newName: "HistoryBillDetails");
            AddColumn("dbo.HistoryBillDetails", "TimeBill", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HistoryBillDetails", "TimeBill");
            RenameTable(name: "dbo.HistoryBillDetails", newName: "BillDetails");
        }
    }
}
