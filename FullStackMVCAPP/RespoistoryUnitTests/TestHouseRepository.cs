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
    public class TestHouseRepository
    {
        [TestMethod]
        public void TestEntityList()
        {
            //Arrange
            var testDataHouses = new List<House>
            {
                new House { Name = "Stark", Region = "The North", Words = "Winter is Coming"},
                new House { Name = "Lannister", Region = "The Westerlands", Words = "A Lannister Always Pays His Debts" },
                new House { Name = "Arryn", Region = "The Vale of Arryn", Words = "As High as Honor"}
            }.AsQueryable();

            var mockHouseSet = new Mock<DbSet<House>>();
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testDataHouses.Provider);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testDataHouses.Expression);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testDataHouses.ElementType);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testDataHouses.GetEnumerator());

            var testDataCastles = new List<FullStackMVCAPP.Models.Castle>
            {
                new FullStackMVCAPP.Models.Castle { Name = "Winterfell"},
                new FullStackMVCAPP.Models.Castle { Name = "Pyke"},
                new FullStackMVCAPP.Models.Castle { Name = "Casterly Rock"}
            }.AsQueryable();

            var mockCastleSet = new Mock<DbSet<FullStackMVCAPP.Models.Castle>>();
            mockCastleSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Provider).Returns(testDataCastles.Provider);
            mockCastleSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Expression).Returns(testDataCastles.Expression);
            mockCastleSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.ElementType).Returns(testDataCastles.ElementType);
            mockCastleSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.GetEnumerator()).Returns(testDataCastles.GetEnumerator());

            var mockContext = new Mock<GOTContext>();
            mockContext.Setup(h => h.Houses).Returns(mockHouseSet.Object);
            mockContext.Setup(c => c.Castles).Returns(mockCastleSet.Object);


            //Act
            var houseRepository = new HouseRepository();
            var listOfHouses = houseRepository.EntityList(mockContext.Object);

            //Assert
            Assert.AreEqual(3, listOfHouses.Count());
            Assert.AreEqual("Stark",listOfHouses.First().Name);
            Assert.AreEqual("Lannister",listOfHouses.ElementAt(1).Name);
            Assert.AreEqual("Arryn",listOfHouses.Last().Name);
        }

        [TestMethod]
        public void TestGetEntityById()
        {
            //Arrange
            var testDataHouses = new List<House>
            {
                new House { Id=1, Name = "Stark", Region = "The North", Words = "Winter is Coming"},
                new House { Id=2, Name = "Lannister", Region = "The Westerlands", Words = "A Lannister Always Pays His Debts" },
                new House { Id=3, Name = "Arryn", Region = "The Vale of Arryn", Words = "As High as Honor"}
            }.AsQueryable();

            var mockHouseSet = new Mock<DbSet<House>>();
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testDataHouses.Provider);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testDataHouses.Expression);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testDataHouses.ElementType);
            mockHouseSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testDataHouses.GetEnumerator());

            var mockContext = new Mock<GOTContext>();
            mockContext.Setup(h => h.Houses).Returns(mockHouseSet.Object);

            //Act
            var houseRepository = new HouseRepository();
            var houseOne = houseRepository.GetEntityByID(mockContext.Object,1);
            var houseTwo = houseRepository.GetEntityByID(mockContext.Object, 2);
            var houseThree = houseRepository.GetEntityByID(mockContext.Object, 3);

            //Assert
            Assert.AreEqual("Stark", houseOne.Name);
            Assert.AreEqual("Lannister", houseTwo.Name);
            Assert.AreEqual("Arryn", houseThree.Name);
        }
    }
}
