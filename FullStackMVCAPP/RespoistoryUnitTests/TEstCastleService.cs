using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.Services;

namespace RespoistoryUnitTests
{
    [TestClass]
    public class TestCastleService
    {
        [TestMethod]
        public void TestCastleList()
        {   
            //Arrange
            //Conflict between Castle.core package used by Moq and Castle Model, so directly importing resolves conflict.
            var testData = new List<FullStackMVCAPP.Models.Castle>
            {
                new FullStackMVCAPP.Models.Castle { Name = "Winterfell"},
                new FullStackMVCAPP.Models.Castle { Name = "Pyke"},
                new FullStackMVCAPP.Models.Castle { Name = "Casterly Rock"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<FullStackMVCAPP.Models.Castle>>();
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Provider).Returns(testData.Provider);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Expression).Returns(testData.Expression);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());

            var mockGOTContext = new Mock<GOTContext>();
            mockGOTContext.Setup(c => c.Castles).Returns(mockSet.Object);

            //Act
            //Need to add additional constructor to CastleService that accepts a DbContext as a parameter
            var castleService = new CastleService(mockGOTContext.Object);
            var listOfCastles = castleService.GetCastles();

            //Assert
            //Assert.AreEqual(3, 3);
            Assert.AreEqual(3, listOfCastles.Count());
            Assert.AreEqual("Winterfell", listOfCastles.First().Name);
            Assert.AreEqual("Pyke", listOfCastles.ElementAt(1).Name);
            Assert.AreEqual("Casterly Rock", listOfCastles.Last().Name);
        }


    }
}
