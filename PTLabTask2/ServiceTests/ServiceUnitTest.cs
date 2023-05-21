using Data.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ServiceUnitTest
    {
        private IService servrepo;
        [TestMethod]
        public void UserService()
        {
            servrepo = IService.CreateNewService();
            servrepo.AddUser(1, "Filip", "Testt", "Testing");
            Assert.AreEqual(servrepo.GetUser(1).FirstName, "Filip");
            Assert.IsNotNull(servrepo.GetUser(1));
            Assert.IsTrue(servrepo.GetUser(1).FirstName == "Filip");
            Assert.IsTrue(servrepo.GetUser(1).LastName == "Testt");
            Assert.IsTrue(servrepo.GetUser(1).Address == "Testing");
            servrepo.UpdateUser(1, "Filip", "Changed", "Testing");
            Assert.IsTrue(servrepo.GetUser(1).LastName == "Changed");
            Assert.IsNotNull(servrepo.GetUsersList());
            servrepo.RemoveUser(1);
            Assert.IsNull(servrepo.GetUser(1));
        }
        [TestMethod]
        public void CatalogService()
        {
            servrepo = IService.CreateNewService();
            servrepo.AddCatalog(1, "Sofa", 199);
            Assert.IsNotNull(servrepo.GetCatalog(1));
            Assert.IsTrue(servrepo.GetCatalog(1).Name == "Sofa");
            Assert.IsTrue(servrepo.GetCatalog(1).Price == 199);
            servrepo.UpdateCatalog(1, "Chair", 199);
            Assert.IsTrue(servrepo.GetCatalog(1).Name == "Chair");
            Assert.IsNotNull(servrepo.GetCatalogsList());
            servrepo.RemoveCatalog(1);
            Assert.IsNull(servrepo.GetCatalog(1));
        }
        [TestMethod]
        public void StateService()
        {
            servrepo = IService.CreateNewService();
            servrepo.AddCatalog(1, "Sofa", 199);
            servrepo.AddState(1, 5, 1);
            Assert.IsNotNull(servrepo.GetState(1));
            Assert.IsTrue(servrepo.GetState(1).Catalog == 1);
            Assert.IsTrue(servrepo.GetState(1).Quantity == 5);
            Assert.IsNotNull(servrepo.GetStatesList());
            servrepo.RemoveState(1);
            servrepo.RemoveCatalog(1);
            Assert.IsNull(servrepo.GetState(1));
        }
        [TestMethod]
        public void SellReturnSupplyService()
        {
            servrepo = IService.CreateNewService();
            servrepo.AddUser(1, "Filip", "Test", "Test 1");
            servrepo.AddCatalog(1, "Sofa", 199);
            servrepo.AddState(1, 5, 1);
            servrepo.SellItem(1, 1, 1, 3);
            Assert.IsTrue(servrepo.GetState(1).Quantity == 2);
            servrepo.ReturnItem(2, 1, 1, 2);
            Assert.IsTrue(servrepo.GetState(1).Quantity == 4);
            servrepo.SupplyItem(3, 1, 1, 1);
            Assert.IsTrue(servrepo.GetState(1).Quantity == 5);
            servrepo.RemoveEvent(1);
            servrepo.RemoveEvent(2);
            servrepo.RemoveEvent(3);
            servrepo.RemoveState(1);
            servrepo.RemoveCatalog(1);
            servrepo.RemoveUser(1);
        }
    }
}
