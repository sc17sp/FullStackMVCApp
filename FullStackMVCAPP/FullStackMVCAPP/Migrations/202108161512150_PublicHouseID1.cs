namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PublicHouseID1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Characters", "HouseID_Id", "dbo.Houses");
            DropIndex("dbo.Characters", new[] { "HouseID_Id" });
            AlterColumn("dbo.Characters", "HouseID_Id", c => c.Int());
            CreateIndex("dbo.Characters", "HouseID_Id");
            AddForeignKey("dbo.Characters", "HouseID_Id", "dbo.Houses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "HouseID_Id", "dbo.Houses");
            DropIndex("dbo.Characters", new[] { "HouseID_Id" });
            AlterColumn("dbo.Characters", "HouseID_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Characters", "HouseID_Id");
            AddForeignKey("dbo.Characters", "HouseID_Id", "dbo.Houses", "Id", cascadeDelete: true);
        }
    }
}
