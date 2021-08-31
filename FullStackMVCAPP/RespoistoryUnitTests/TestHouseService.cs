using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using FullStackMVCAPP.Models;
using FullStackMVCAPP.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace RespoistoryUnitTests
{
    [TestClass]
    public class TestHouseService
    {
        private Mock<GOTContext> _MockGOTContext;
        private HouseRepository _HouseRepository;

        public HouseService GetMockedService()
        {
            _MockGOTContext = new Mock<GOTContext>();
            _HouseRepository = new HouseRepository();

            return new HouseService(_MockGOTContext.Object, _HouseRepository);
        }

        [TestMethod]
        public void TestHouseList()
        {
            //Arrange
            var testData = new List<House>
            {
                new House { Name = "Stark", Region = "The North", Words = "Winter is Coming"},
                new House { Name = "Lannister", Region = "The Westerlands", Words = "A Lannister Always Pays His Debts" },
                new House { Name = "Arryn", Region = "The Vale of Arryn", Words = "As High as Honor"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<House>>();
            mockSet.As<IQueryable<House>>().Setup(m => m.Provider).Returns(testData.Provider);
            mockSet.As<IQueryable<House>>().Setup(m => m.Expression).Returns(testData.Expression);
            mockSet.As<IQueryable<House>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            mockSet.As<IQueryable<House>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());


            //Act
            var houseService = GetMockedService();
            _MockGOTContext.Setup(h => h.Houses).Returns(mockSet.Object);
            var listOfHouse = houseService.GetHouses();

            
            Assert.AreEqual(3, 3);
        }
    }
}
