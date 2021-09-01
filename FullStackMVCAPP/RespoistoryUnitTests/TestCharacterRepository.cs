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
        public IQueryable<House> _TestHouseData;
        public IQueryable<Character> _TestCharacterData;


        [TestInitialize]
        public void SetUp()
        {   
            //Arrange
            var testDataHouse = new List<House>
            {
                new House{ Id=1, Name="Stark", Region="The North", Words="Winter is coming"},
                new House{ Id=2, Name="Lannister", Region="The Westnerlands", Words="A lannister Always Pays His Debts"},
                new House{ Id=3, Name="Grey Joy", Region="The Iron Islands", Words="What is dead my never die"}
            }.AsQueryable();

            _TestHouseData = testDataHouse;

            var testDataCharacters = new List<Character>
            {
                new Character{Id=1, FirstName="Jon", LastName = "Snow", Alive=true, House=_TestHouseData.First()},
                new Character{Id=2, FirstName="Jamie", LastName = "Lannister", Alive=false, House=_TestHouseData.ElementAt(1)},
                new Character{Id=3, FirstName="Theon", LastName = "Greyjoy", Alive=false, House=_TestHouseData.Last()}
            }.AsQueryable();

            _TestCharacterData = testDataCharacters;

            _MockGOTContext = new Mock<GOTContext>();
            _MockCharacterSet = new Mock<DbSet<Character>>();
            _MockHouseSet = new Mock<DbSet<House>>();

            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(_TestHouseData.Provider);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(_TestHouseData.Expression);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(_TestHouseData.ElementType);
            _MockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(_TestHouseData.GetEnumerator());

            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Provider).Returns(_TestCharacterData.Provider);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Expression).Returns(_TestCharacterData.Expression);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.ElementType).Returns(_TestCharacterData.ElementType);
            _MockCharacterSet.As<IQueryable<Character>>().Setup(m => m.GetEnumerator()).Returns(_TestCharacterData.GetEnumerator());
        }
        [TestMethod]
        public void TestEntityList()
        {   
            //Arrange
            SetUp();
            //Act
            var characterRepository = new CharacterRepository();
            var listOfCharacters = characterRepository.EntityList(_MockGOTContext.Object);

            //Assert
            Assert.AreEqual("Jon", listOfCharacters.First().FirstName);
            Assert.AreEqual("Jamie", listOfCharacters.ElementAt(1).FirstName);
            Assert.AreEqual("Theon", listOfCharacters.Last().FirstName);
            Assert.AreEqual(1, 1);
        }
    }
}
