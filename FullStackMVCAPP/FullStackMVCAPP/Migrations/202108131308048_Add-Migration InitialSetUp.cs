namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationInitialSetUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Castles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Region = c.String(nullable: false),
                        Words = c.String(),
                        CastleId_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.CastleId_Id, cascadeDelete: true)
                .Index(t => t.CastleId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "CastleId_Id", "dbo.Castles");
            DropIndex("dbo.Houses", new[] { "CastleId_Id" });
            DropTable("dbo.Houses");
            DropTable("dbo.Castles");
        }
    }
}
