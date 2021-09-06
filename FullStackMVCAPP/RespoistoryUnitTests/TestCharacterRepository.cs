using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using FullStackMVCAPP.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace RespoistoryUnitTests
{
    [TestClass]
    public class TestCharacterRepository
    {   
        public Mock<GOTContext> _MockGOTContext;
        public Mock<DbSet<Character>> _MockCharacterSet;
        public Mock<DbSet<House>> _MockHouseSet;


        [TestInitialize]
        public void SetUp()
        {   
            _MockGOTContext = new Mock<GOTContext>();
            _MockCharacterSet = new Mock<DbSet<Character>>();
            _MockHouseSet = new Mock<DbSet<House>>();
        }

        [TestMethod]
        public void TestEntityList()
        {   
            //Arrange
            SetUp();

            var testDataHouse = new List<House>
            {
                new House{ Id=1, Name="Stark", Region="The North", Words="Winter is coming"},
                new House{ Id=2, Name="Lannister", Region="The Westnerlands", Words="A lannister Always Pays His Debts"},
                new House{ Id=3, Name="Grey Joy", Region="The Iron Islands", Words="What is dead my never die"}
            }.AsQueryable();

            var testDataCharacters = new List<Character>
            {
                new Character{Id=1, FirstName="Jon", LastName = "Snow", Alive=true, House=testDataHouse.First()},
                new Character{Id=2, FirstName="Jamie", LastName = "Lannister", Alive=false, House=testDataHouse.ElementAt(1)},
                new Character{Id=3, FirstName="Theon", LastName = "Greyjoy", Alive=false, House=testDataHouse.Last()}
            }.AsQueryable();


            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testDataHouse.Provider);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testDataHouse.Expression);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testDataHouse.ElementType);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testDataHouse.GetEnumerator());

            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Provider).Returns(testDataCharacters.Provider);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Expression).Returns(testDataCharacters.Expression);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.ElementType).Returns(testDataCharacters.ElementType);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.GetEnumerator()).Returns(testDataCharacters.GetEnumerator());

            _MockGOTContext.Setup(h => h.Houses).Returns(_MockHouseSet.Object);
            _MockGOTContext.Setup(c => c.Characters).Returns(_MockCharacterSet.Object);
            //Act
            var characterRepository = new CharacterRepository();
            var listOfCharacters = characterRepository.EntityList(_MockGOTContext.Object);

            //Assert
            Assert.AreEqual("Jon", listOfCharacters.First().FirstName);
            Assert.AreEqual("Jamie", listOfCharacters.ElementAt(1).FirstName);
            Assert.AreEqual("Theon", listOfCharacters.Last().FirstName);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestGetEntityById()
        {
            //Arrange
            SetUp();

            var testDataCharacters = new List<Character>
            {
                new Character{Id=1, FirstName="Jon", LastName = "Snow", Alive=true},
                new Character{Id=2, FirstName="Jamie", LastName = "Lannister", Alive=false},
                new Character{Id=3, FirstName="Theon", LastName = "Greyjoy", Alive=false}
            }.AsQueryable();

            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Provider).Returns(testDataCharacters.Provider);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Expression).Returns(testDataCharacters.Expression);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.ElementType).Returns(testDataCharacters.ElementType);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.GetEnumerator()).Returns(testDataCharacters.GetEnumerator());
            _MockGOTContext.Setup(c => c.Characters).Returns(_MockCharacterSet.Object);

            //Act
            var characterRepository = new CharacterRepository();
            var characterOne = characterRepository.GetEntityByID(_MockGOTContext.Object, 1);
            var characterTwo = characterRepository.GetEntityByID(_MockGOTContext.Object, 2);
            var characterThree = characterRepository.GetEntityByID(_MockGOTContext.Object, 3);

            //Assert
            Assert.AreEqual("Jon", characterOne.FirstName);
            Assert.AreEqual("Jamie", characterTwo.FirstName);
            Assert.AreEqual("Theon", characterThree.FirstName);
        }

        [TestMethod]
        public void TestGetCharacterByHouseId()
        {   
            //Arrange
            SetUp();

            var testDataHouse = new List<House>
            {
                new House{ Id=1, Name="Stark", Region="The North", Words="Winter is coming"},
                new House{ Id=2, Name="Lannister", Region="The Westnerlands", Words="A lannister Always Pays His Debts"},
                new House{ Id=3, Name="Grey Joy", Region="The Iron Islands", Words="What is dead my never die"}
            }.AsQueryable();

            var testDataCharacters = new List<Character>
            {
                new Character{Id=1, FirstName="Jon", LastName = "Snow", Alive=true, House=testDataHouse.First()},
                new Character{Id=2, FirstName="Jamie", LastName = "Lannister", Alive=false, House=testDataHouse.ElementAt(1)},
                new Character{Id=3, FirstName="Theon", LastName = "Greyjoy", Alive=false, House=testDataHouse.Last()},
                new Character{Id=4, FirstName="Arya", LastName = "Stark", Alive=true, House=testDataHouse.First()},
                new Character{Id=5, FirstName="Cersei", LastName = "Lannister", Alive=false, House=testDataHouse.ElementAt(1)}
            }.AsQueryable();


            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testDataHouse.Provider);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testDataHouse.Expression);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testDataHouse.ElementType);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testDataHouse.GetEnumerator());

            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Provider).Returns(testDataCharacters.Provider);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Expression).Returns(testDataCharacters.Expression);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.ElementType).Returns(testDataCharacters.ElementType);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.GetEnumerator()).Returns(testDataCharacters.GetEnumerator());

            _MockGOTContext.Setup(h => h.Houses).Returns(_MockHouseSet.Object);
            _MockGOTContext.Setup(c => c.Characters).Returns(_MockCharacterSet.Object);

            //Act
            var characterRepository = new CharacterRepository();
            var listOfStarkCharacters = characterRepository.GetCharacterByHouseId(_MockGOTContext.Object, 1);
            var listOfLannisterCharacters = characterRepository.GetCharacterByHouseId(_MockGOTContext.Object, 2);

            //Assert
            Assert.AreEqual("Jon", listOfStarkCharacters.First().FirstName);
            Assert.AreEqual("Arya", listOfStarkCharacters.Last().FirstName);

            Assert.AreEqual("Jamie", listOfLannisterCharacters.First().FirstName);
            Assert.AreEqual("Cersei", listOfLannisterCharacters.Last().FirstName);
        }
    }
}
