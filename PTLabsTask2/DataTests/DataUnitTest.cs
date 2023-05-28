using Data.API;

namespace DataTests
{
    [TestClass]
    public class DataUnitTest
    {
        private const string defaultConnectionString = "Data Source = (localdb) Local;Initial Catalog = PTLabdb; Integrated Security = True";

        [TestMethod]
        public void CatalogTests()
        {
            IDataRepository repo = IDataRepository.CreateNewRepository(defaultConnectionString);
            repo.ClearAll();
            repo.AddCatalog(1, "Sofa", 199);
            Assert.IsNotNull(repo.GetCatalog(1));
            Assert.IsTrue(repo.GetCatalog(1).Name == "Sofa");
            Assert.IsTrue(repo.GetCatalog(1).Price == 199);
            Assert.IsNotNull(repo.GetCatalogsList());
            repo.RemoveCatalog(1);
            Assert.IsNull(repo.GetCatalog(1));
        }

        [TestMethod]
        public void UserTests()
        {
            IDataRepository repo = IDataRepository.CreateNewRepository(defaultConnectionString);
            repo.ClearAll();
            repo.AddUser(1, "Filip", "Test", "Test 1");
            Assert.IsNotNull(repo.GetUser(1));
            Assert.IsTrue(repo.GetUser(1).FirstName == "Filip");
            Assert.IsTrue(repo.GetUser(1).LastName == "Test");
            Assert.IsTrue(repo.GetUser(1).Address == "Test 1");
            Assert.IsNotNull(repo.GetUsersList());
            repo.RemoveUser(1);
            Assert.IsNull(repo.GetUser(1));
        }

        [TestMethod]
        public void EventTests()
        {
            IDataRepository repo = IDataRepository.CreateNewRepository(defaultConnectionString);
            repo.ClearAll();
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
        public void StateTests()
        {
            IDataRepository repo = IDataRepository.CreateNewRepository(defaultConnectionString);
            repo.ClearAll();
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
    }
}