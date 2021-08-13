namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FullStackMVCAPP.Models.GOTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FullStackMVCAPP.Models.GOTContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Castles.AddOrUpdate(x => x.Id,
                new Models.Castle() { Id = 1, Name = "Winterfell" },
                new Models.Castle() { Id = 2, Name = "Pyke" },
                new Models.Castle() { Id = 3, Name = "Casterly Rock" },
                new Models.Castle() { Id = 4, Name = "The Eyrie" },
                new Models.Castle() { Id = 5, Name = "The Twins" },
                new Models.Castle() { Id = 6, Name = "DragonStone" }
                );

            context.Houses.AddOrUpdate(x => x.Id,
                new Models.House() {
                    Id = 1,
                    Name = "Arryn",
                    Region = "The Vale of Arryn",
                    Words = "As High as Honor",
                    CastleId = context.Castles.Find(4) 
                },
                new Models.House() {
                    Id = 2,
                    Name = "Greyjoy",
                    Region = "Iron Islands",
                    Words = "What is Dead May Never Die",
                    CastleId = context.Castles.Find(2) 
                },
                new Models.House() {
                    Id = 3,
                    Name = "Lannister",
                    Region = "The Western Islands",
                    Words = "A Lannister Always Pays His Debts",
                    CastleId = context.Castles.Find(3)
                },
                new Models.House() { 
                    Id = 4,
                    Name = "Stark",
                    Region = "The North",
                    Words = "Winter is Coming",
                    CastleId = context.Castles.Find(1)
                },
                new Models.House() { 
                    Id = 5,
                    Name = "Targaryen",
                    Region = "The Crownlands",
                    Words = "Fire and Blood",
                    CastleId = context.Castles.Find(6)
                },
                new Models.House() { 
                    Id = 6,
                    Name = "Frey",
                    Region = "The Riverlands",
                    Words = "We Stand together",
                    CastleId = context.Castles.Find(5)
                }
                );
        }
    }
}
