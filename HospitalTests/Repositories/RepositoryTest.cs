using HospitalServer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using HospitalEntities.Models;

namespace HospitalTests.Repositories
{
    [TestClass]
    public class RepositoryTest
    {
        public class TestModel : IIdentifiable
        {
            public int Id { get; set; }
        }


        public Mock<ApplicationDatabaseContext> contextMock;
        public Mock<DbSet<TestModel>> dbSetMock;

        public TestModel TestObject;
        public List<TestModel> TestList;

        [TestInitialize()]
        public void SetUp()
        {
            TestObject = new TestModel() { Id = 1 };
            TestList = new List<TestModel>() { TestObject };

            dbSetMock = new Mock<DbSet<TestModel>>();
            dbSetMock.As<IQueryable<TestModel>>().Setup(x => x.Provider).Returns(TestList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<TestModel>>().Setup(x => x.Expression).Returns(TestList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<TestModel>>().Setup(x => x.ElementType).Returns(TestList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<TestModel>>().Setup(x => x.GetEnumerator()).Returns(TestList.AsQueryable().GetEnumerator());
            dbSetMock.Setup(x => x.AsQueryable()).Returns(TestList.AsQueryable());
            dbSetMock.Setup(x => x.Add(It.IsAny<TestModel>()));
            dbSetMock.Setup(x => x.Attach(It.IsAny<TestModel>()));
            dbSetMock.Setup(x => x.Remove(It.IsAny<TestModel>()));
            dbSetMock.Setup(x => x.Find(TestObject.Id)).Returns(TestObject);

            contextMock = new Mock<ApplicationDatabaseContext>();
            contextMock.Setup(s => s.Set<TestModel>()).Returns(dbSetMock.Object);
        }

        [TestMethod]
        public void InsertTest()
        {
            // Act
            var repository = new Repository<TestModel>(contextMock.Object);
            repository.Insert(TestObject);

            //Assert
            contextMock.Verify(x => x.Set<TestModel>());
            dbSetMock.Verify(x => x.Add(It.Is<TestModel>(y => y == TestObject)));
        }

        [TestMethod]
        public void UpdateTest()
        {
            dbSetMock.Setup(x => x.Find(TestObject.Id)).Returns(TestObject);
            var mockRepo = new Mock<Repository<TestModel>>(contextMock.Object);
            mockRepo.Setup(x => x.SetStateModified(It.IsAny<TestModel>()));
            mockRepo.Object.Update(TestObject);

            //Assert
            contextMock.Verify(x => x.Set<TestModel>());
            dbSetMock.Verify(x => x.Attach(It.Is<TestModel>(y => y == TestObject)));
            mockRepo.Verify(x => x.SetStateModified(It.Is<TestModel>(y => y == TestObject)), Times.Once);
        }

        [TestMethod]
        public void RemoveTest()
        {
            // Act
            var repository = new Repository<TestModel>(contextMock.Object);
            repository.Delete(TestObject.Id);

            //Assert
            contextMock.Verify(x => x.Set<TestModel>());
            dbSetMock.Verify(x => x.Remove(It.Is<TestModel>(y => y == TestObject)));
        }

        [TestMethod]
        public void GetByIdTest()
        {
            // Act
            var repository = new Repository<TestModel>(contextMock.Object);
            var result = repository.GetById(x => x.Id == 1);

            // Assert
            Assert.AreEqual(TestObject, result);
        }

        [TestMethod]
        public void GetAllTest()
        {
            // Act
            var repository = new Repository<TestModel>(contextMock.Object);
            var result = repository.GetAll();

            // Assert
            CollectionAssert.AreEquivalent(TestList.ToList(), result.ToList());
        }
    }
}
