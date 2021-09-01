using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace RespoistoryUnitTests
{
    [TestClass]
    public class TestCastleRepository
    {
        [TestMethod]
        public void TestEntityList()
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
            var castleRepository = new CastleRepository();
            var listOfCastles = castleRepository.EntityList(mockGOTContext.Object);

            //Assert
            Assert.AreEqual(3, listOfCastles.Count());
            Assert.AreEqual("Winterfell", listOfCastles.First().Name);
            Assert.AreEqual("Pyke", listOfCastles.ElementAt(1).Name);
            Assert.AreEqual("Casterly Rock", listOfCastles.Last().Name);

        }

        [TestMethod]
        public void TestGetEntityById()
        {
            //Arrange
            //Conflict between Castle.core package used by Moq and Castle Model, so directly importing resolves conflict.
            var testData = new List<FullStackMVCAPP.Models.Castle>
            {
                new FullStackMVCAPP.Models.Castle { Id=1, Name = "Winterfell"},
                new FullStackMVCAPP.Models.Castle { Id=2, Name = "Pyke"},
                new FullStackMVCAPP.Models.Castle { Id=3, Name = "Casterly Rock"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<FullStackMVCAPP.Models.Castle>>();
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Provider).Returns(testData.Provider);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.Expression).Returns(testData.Expression);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            mockSet.As<IQueryable<FullStackMVCAPP.Models.Castle>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());

            var mockGOTContext = new Mock<GOTContext>();
            mockGOTContext.Setup(c => c.Castles).Returns(mockSet.Object);

            //Act
            var castleRepository = new CastleRepository();
            var castleOne = castleRepository.GetEntityByID(mockGOTContext.Object, 1);
            var castleTwo = castleRepository.GetEntityByID(mockGOTContext.Object, 2);
            var castleThree = castleRepository.GetEntityByID(mockGOTContext.Object, 3);

            //Assert
            Assert.AreEqual("Winterfell", castleOne.Name);
            Assert.AreEqual("Pyke", castleTwo.Name);
            Assert.AreEqual("Casterly Rock", castleThree.Name);
        }
    }
}
