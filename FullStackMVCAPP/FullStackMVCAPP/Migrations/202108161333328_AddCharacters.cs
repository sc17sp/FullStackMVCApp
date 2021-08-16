namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Alive = c.Boolean(nullable: false),
                        HouseID_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.HouseID_Id, cascadeDelete: true)
                .Index(t => t.HouseID_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "HouseID_Id", "dbo.Houses");
            DropIndex("dbo.Characters", new[] { "HouseID_Id" });
            DropTable("dbo.Characters");
        }
    }
}
