namespace FullStackMVCAPP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FullStackMVCAPP.DataContext.GOTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FullStackMVCAPP.DataContext.GOTContext context)
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
            context.Characters.AddOrUpdate(x => x.Id,
                new Models.Character() { 
                    Id = 1,
                    FirstName = "Jon",
                    LastName = "Snow",
                    Alive = true,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 2,
                    FirstName = "Arya",
                    LastName = "Stark",
                    Alive = true,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 3,
                    FirstName = "Sansa",
                    LastName = "Stark",
                    Alive = true,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 4,
                    FirstName = "Eddard",
                    LastName = "Stark",
                    Alive = false,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 5,
                    FirstName = "Bran",
                    LastName = "Stark",
                    Alive = true,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 6,
                    FirstName = "Robb",
                    LastName = "Stark",
                    Alive = false,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 7,
                    FirstName = "Catelyn",
                    LastName = "Stark",
                    Alive = false,
                    HouseID = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 8,
                    FirstName = "Robin",
                    LastName = "Arryn",
                    Alive = true,
                    HouseID = context.Houses.Find(1)
                },
                new Models.Character()
                {
                    Id = 9,
                    FirstName = "Lysa",
                    LastName = "Arryn",
                    Alive = false,
                    HouseID = context.Houses.Find(1)
                },
                new Models.Character()
                {
                    Id = 10,
                    FirstName = "Yara",
                    LastName = "Greyjoy",
                    Alive = false,
                    HouseID = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 11,
                    FirstName = "Theon",
                    LastName = "Greyjoy",
                    Alive = false,
                    HouseID = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 12,
                    FirstName = "Balon",
                    LastName = "Greyjoy",
                    Alive = false,
                    HouseID = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 13,
                    FirstName = "Cersei",
                    LastName = "Lannister",
                    Alive = false,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 14,
                    FirstName = "Tyrion",
                    LastName = "Lannister",
                    Alive = true,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 15,
                    FirstName = "Jamie",
                    LastName = "Lannister",
                    Alive = false,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 16,
                    FirstName = "Tywin",
                    LastName = "Lannister",
                    Alive = false,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 17,
                    FirstName = "Joffrey",
                    LastName = "Lannister",
                    Alive = false,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 18,
                    FirstName = "Tommen",
                    LastName = "Lannister",
                    Alive = false,
                    HouseID = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 19,
                    FirstName = "Daenerys",
                    LastName = "Targaryen",
                    Alive = false,
                    HouseID = context.Houses.Find(5)
                },
                new Models.Character()
                {
                    Id = 20,
                    FirstName = "Rhaegar",
                    LastName = "Targaryen",
                    Alive = false,
                    HouseID = context.Houses.Find(5)
                },
                new Models.Character()
                {
                    Id = 21,
                    FirstName = "Walder",
                    LastName = "Frey",
                    Alive = false,
                    HouseID = context.Houses.Find(6)
                },
                new Models.Character()
                {
                    Id = 22,
                    FirstName = "Walda",
                    LastName = "Frey",
                    Alive = false,
                    HouseID = context.Houses.Find(6)
                }
            );
        }
    }
}
