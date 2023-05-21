using Data.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace DataTests
{
    [TestClass]
    public class DataUnitTest
    {
        private IDataRepository repo;
        [TestMethod]
        public void UserData()
        {
            repo = IDataRepository.CreateNewRepository();
            repo.Delete();
            repo.AddUser(1, "Filip", "Test", "Test 1");
            Assert.IsNotNull(repo.GetUser(1));
            Assert.IsTrue(repo.GetUser(1).FirstName == "Filip");
            Assert.IsTrue(repo.GetUser(1).LastName == "Test");
            Assert.IsTrue(repo.GetUser(1).Address == "Test 1");
            repo.UpdateUser(1, "Filip", "Changed", "Test 1");
            Assert.IsTrue(repo.GetUser(1).LastName == "Changed");
            Assert.IsNotNull(repo.GetUsersList());
            repo.RemoveUser(1);
            Assert.IsNull(repo.GetUser(1));
        }
        [TestMethod]
        public void CatalogData()
        {
            repo = IDataRepository.CreateNewRepository();
            repo.Delete();
            repo.AddCatalog(1, "Sofa", 199);
            Assert.IsNotNull(repo.GetCatalog(1));
            Assert.IsTrue(repo.GetCatalog(1).Name == "Sofa");
            Assert.IsTrue(repo.GetCatalog(1).Price == 199);
            repo.UpdateCatalog(1, "Chair", 199);
            Assert.IsTrue(repo.GetCatalog(1).Name == "Chair");
            Assert.IsNotNull(repo.GetCatalogsList());
            repo.RemoveCatalog(1);
            Assert.IsNull(repo.GetCatalog(1));
        }
        [TestMethod]
        public void StateData()
        {
            repo = IDataRepository.CreateNewRepository();
            repo.Delete();
            repo.AddCatalog(1, "Sofa", 199);
            repo.AddState(1, 5, 1);
            Assert.IsNotNull(repo.GetState(1));
            Assert.IsTrue(repo.GetState(1).Catalog == 1);
            Assert.IsTrue(repo.GetState(1).Quantity == 5);
            Assert.IsNotNull(repo.GetStatesList());
            repo.ChangeQuantity(1, 2);
            Assert.IsTrue(repo.GetState(1).Quantity == 7);
            repo.RemoveState(1);
            repo.RemoveCatalog(1);
            Assert.IsNull(repo.GetState(1));
        }
        [TestMethod]
        public void EventData()
        {
            repo = IDataRepository.CreateNewRepository();
            repo.Delete();
            repo.AddUser(1, "Filip", "Test", "Test 1");
            repo.AddCatalog(1, "Sofa", 199);
            repo.AddState(1, 5, 1);
            repo.AddEvent(1, 1, 1, 3);
            Assert.IsTrue(repo.GetEventsList().Count() == 1);
            repo.RemoveEvent(1);
            repo.RemoveState(1);
            repo.RemoveCatalog(1);
            repo.RemoveUser(1);
            Assert.IsTrue(repo.GetEventsList().Count() == 0);
        }
        [TestMethod]
        public void DeleteData()
        {
            repo = IDataRepository.CreateNewRepository();
            repo.Delete();
        }
    }
}
