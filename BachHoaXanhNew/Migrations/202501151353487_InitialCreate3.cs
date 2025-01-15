namespace BachHoaXanhNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HistoryBillDetails", "ID_BILL", "dbo.Bills");
            DropIndex("dbo.HistoryBillDetails", new[] { "ID_BILL" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.HistoryBillDetails", "ID_BILL");
            AddForeignKey("dbo.HistoryBillDetails", "ID_BILL", "dbo.Bills", "ID_BILL", cascadeDelete: true);
        }
    }
}
