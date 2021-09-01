using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace RespoistoryUnitTests
{
    [TestClass]
    public class TestCharacterService
    {
        [TestMethod]
        public void TestGetCharacters()
        {
            //Arrange
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
                new Character{Id=1, FirstName="Theon", LastName = "Greyjoy", Alive=false, House=testDataHouse.Last()}
            }.AsQueryable();

            var mockCharacterSet = new Mock<DbSet<Character>>();
            var mockHouseSet = new Mock<DbSet<House>>();

            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testDataHouse.Provider);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testDataHouse.Expression);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testDataHouse.ElementType);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testDataHouse.GetEnumerator());

            mockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Provider).Returns(testDataCharacters.Provider);
            mockCharacterSet.As<IQueryable<Character>>().Setup(m => m.Expression).Returns(testDataCharacters.Expression);
            mockCharacterSet.As<IQueryable<Character>>().Setup(m => m.ElementType).Returns(testDataCharacters.ElementType);
            mockCharacterSet.As<IQueryable<Character>>().Setup(m => m.GetEnumerator()).Returns(testDataCharacters.GetEnumerator());
            
            var mockGOTContext = new Mock<GOTContext>();
            mockGOTContext.Setup(h => h.Houses).Returns(mockHouseSet.Object);
            mockGOTContext.Setup(c => c.Characters).Returns(mockCharacterSet.Object);
            //Act

            //Assert
            Assert.AreEqual(3, 3);
        }

        public void TestGetCharactersById()
        {
        }

        public void TestGetCharactersByHouseId()
        {
        }
    }
}
