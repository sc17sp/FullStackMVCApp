namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
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
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Region = c.String(nullable: false),
                        Words = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Alive = c.Boolean(nullable: false),
                        House_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .Index(t => t.House_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Houses", "Id", "dbo.Castles");
            DropIndex("dbo.Characters", new[] { "House_Id" });
            DropIndex("dbo.Houses", new[] { "Id" });
            DropTable("dbo.Characters");
            DropTable("dbo.Houses");
            DropTable("dbo.Castles");
        }
    }
}
