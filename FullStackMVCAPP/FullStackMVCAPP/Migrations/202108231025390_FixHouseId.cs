namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixHouseId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Characters", new[] { "HouseID_Id" });
            CreateIndex("dbo.Characters", "HouseId_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Characters", new[] { "HouseId_Id" });
            CreateIndex("dbo.Characters", "HouseID_Id");
        }
    }
}
