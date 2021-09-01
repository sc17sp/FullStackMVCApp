namespace FullStackMVCAPP.Migrations
{
    using FullStackMVCAPP.Models;
    using System;
    using System.Collections.Generic;
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
                new Models.House()
                {
                    Id = 1,
                    Name = "Arryn",
                    Region = "The Vale of Arryn",
                    Words = "As High as Honor",
                    Castle = context.Castles.Find(4),
                    Characters = new List<Character>()
                },
                new Models.House()
                {
                    Id = 2,
                    Name = "Greyjoy",
                    Region = "Iron Islands",
                    Words = "What is Dead May Never Die",
                    Castle = context.Castles.Find(2),
                    Characters = new List<Character>()
                },
                new Models.House()
                {
                    Id = 3,
                    Name = "Lannister",
                    Region = "The Western Islands",
                    Words = "A Lannister Always Pays His Debts",
                    Castle = context.Castles.Find(3),
                    Characters = new List<Character>()
                },
                new Models.House()
                {
                    Id = 4,
                    Name = "Stark",
                    Region = "The North",
                    Words = "Winter is Coming",
                    Castle = context.Castles.Find(1),
                    Characters = new List<Character>()
                },
                new Models.House()
                {
                    Id = 5,
                    Name = "Targaryen",
                    Region = "The Crownlands",
                    Words = "Fire and Blood",
                    Castle = context.Castles.Find(6),
                    Characters = new List<Character>()
                },
                new Models.House()
                {
                    Id = 6,
                    Name = "Frey",
                    Region = "The Riverlands",
                    Words = "We Stand together",
                    Castle = context.Castles.Find(5),
                    Characters = new List<Character>()
                }
                );
            context.Characters.AddOrUpdate(x => x.Id,
                new Models.Character()
                {
                    Id = 1,
                    FirstName = "Jon",
                    LastName = "Snow",
                    Alive = true,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 2,
                    FirstName = "Arya",
                    LastName = "Stark",
                    Alive = true,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 3,
                    FirstName = "Sansa",
                    LastName = "Stark",
                    Alive = true,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 4,
                    FirstName = "Eddard",
                    LastName = "Stark",
                    Alive = false,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 5,
                    FirstName = "Bran",
                    LastName = "Stark",
                    Alive = true,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 6,
                    FirstName = "Robb",
                    LastName = "Stark",
                    Alive = false,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 7,
                    FirstName = "Catelyn",
                    LastName = "Stark",
                    Alive = false,
                    House = context.Houses.Find(4)
                },
                new Models.Character()
                {
                    Id = 8,
                    FirstName = "Robin",
                    LastName = "Arryn",
                    Alive = true,
                    House = context.Houses.Find(1)
                },
                new Models.Character()
                {
                    Id = 9,
                    FirstName = "Lysa",
                    LastName = "Arryn",
                    Alive = false,
                    House = context.Houses.Find(1)
                },
                new Models.Character()
                {
                    Id = 10,
                    FirstName = "Yara",
                    LastName = "Greyjoy",
                    Alive = false,
                    House = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 11,
                    FirstName = "Theon",
                    LastName = "Greyjoy",
                    Alive = false,
                    House = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 12,
                    FirstName = "Balon",
                    LastName = "Greyjoy",
                    Alive = false,
                    House = context.Houses.Find(2)
                },
                new Models.Character()
                {
                    Id = 13,
                    FirstName = "Cersei",
                    LastName = "Lannister",
                    Alive = false,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 14,
                    FirstName = "Tyrion",
                    LastName = "Lannister",
                    Alive = true,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 15,
                    FirstName = "Jamie",
                    LastName = "Lannister",
                    Alive = false,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 16,
                    FirstName = "Tywin",
                    LastName = "Lannister",
                    Alive = false,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 17,
                    FirstName = "Joffrey",
                    LastName = "Lannister",
                    Alive = false,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 18,
                    FirstName = "Tommen",
                    LastName = "Lannister",
                    Alive = false,
                    House = context.Houses.Find(3)
                },
                new Models.Character()
                {
                    Id = 19,
                    FirstName = "Daenerys",
                    LastName = "Targaryen",
                    Alive = false,
                    House = context.Houses.Find(5)
                },
                new Models.Character()
                {
                    Id = 20,
                    FirstName = "Rhaegar",
                    LastName = "Targaryen",
                    Alive = false,
                    House = context.Houses.Find(5)
                },
                new Models.Character()
                {
                    Id = 21,
                    FirstName = "Walder",
                    LastName = "Frey",
                    Alive = false,
                    House = context.Houses.Find(6)
                },
                new Models.Character()
                {
                    Id = 22,
                    FirstName = "Walda",
                    LastName = "Frey",
                    Alive = false,
                    House = context.Houses.Find(6)
                }
            );

            //adding characters to their houses

            //Stark
            context.Houses.Find(1).Characters.Add(context.Characters.Find(1));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(2));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(3));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(4));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(5));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(6));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(7));

            //Arryn
            context.Houses.Find(2).Characters.Add(context.Characters.Find(8));
            context.Houses.Find(1).Characters.Add(context.Characters.Find(9));

            //Greyjoy
            context.Houses.Find(3).Characters.Add(context.Characters.Find(10));
            context.Houses.Find(3).Characters.Add(context.Characters.Find(11));
            context.Houses.Find(3).Characters.Add(context.Characters.Find(12));

            //Lannister
            context.Houses.Find(4).Characters.Add(context.Characters.Find(13));
            context.Houses.Find(4).Characters.Add(context.Characters.Find(14));
            context.Houses.Find(4).Characters.Add(context.Characters.Find(15));
            context.Houses.Find(4).Characters.Add(context.Characters.Find(16));
            context.Houses.Find(4).Characters.Add(context.Characters.Find(17));

            //Targaryen
            context.Houses.Find(5).Characters.Add(context.Characters.Find(18));
            context.Houses.Find(5).Characters.Add(context.Characters.Find(19));

            //Frey
            context.Houses.Find(6).Characters.Add(context.Characters.Find(20));
            context.Houses.Find(6).Characters.Add(context.Characters.Find(21));

            //Adding castles to houses
            ////The Eyrie
            //context.Castles.Find(1).House = context.Houses.Find(4);

            ////Pyke
            //context.Castles.Find(2).House = context.Houses.Find(2);

            ////Casterly Rock
            //context.Castles.Find(3).House = context.Houses.Find(3);

            ////Winterfell
            //context.Castles.Find(4).House = context.Houses.Find(1);

            ////The Twins
            //context.Castles.Find(5).House = context.Houses.Find(6);

            ////DragonStone
            //context.Castles.Find(6).House = context.Houses.Find(5);

            context.SaveChanges();
        }
    }
}
