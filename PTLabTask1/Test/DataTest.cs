using Data.API;
using Data.CodeImplementation;

namespace Test
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestNullEmptyGeneration()
        {
            IDataRepository DR = new DataRepository(null);
            Assert.IsNotNull(DR);           
        }
        [TestMethod]
        public void TestCatalog()
        {
            IDataRepository DR = new DataRepository(null);
            ICatalog testCatalog = new Catalog("0", "Szafa Robert", 126.26f);
            DR.AddCatalog(testCatalog);
            Assert.AreEqual(DR.GetCatalog("0").Id, "0");
            Assert.AreEqual(DR.GetCatalog("0").Name, "Szafa Robert");
            Assert.AreEqual(DR.GetCatalog("0").Price, 126.26f);
            Assert.IsTrue(DR.GetCatalogsList().Count() == 1);
            DR.RemoveCatalog("0");
            Assert.IsTrue(DR.GetCatalogsList().Count() == 0);
        }
        [TestMethod]
        public void TestUser()
        {
            IDataRepository DR = new DataRepository(null);
            IUser user = new User("C0001", "Bill", "Nickolson", "219 Grove St. New York");
            DR.AddUser(user);
            Assert.AreEqual(DR.GetUser("C0001").Id, "C0001");
            Assert.AreEqual(DR.GetUser("C0001").FirstName, "Bill");
            Assert.AreEqual(DR.GetUser("C0001").LastName, "Nickolson");
            Assert.AreEqual(DR.GetUser("C0001").Address, "219 Grove St. New York");
            Assert.IsTrue(DR.GetUsersList().Count() == 1);
            DR.RemoveUser("C0001");
            Assert.IsTrue(DR.GetUsersList().Count() == 0);
        }
    }
}