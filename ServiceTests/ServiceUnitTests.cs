
using Data.API;
using Data.CodeImplementation;
using Services.API;


namespace ServiceTests
{
    [TestClass]
    public class ServiceUnitTests
    {
        

        [TestMethod]
        public void CatalogTest()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddCatalog(1, "Sofa", 199);
            Assert.IsNotNull(serviceRepo.GetCatalogsList());
            List<ICatalogServiceData> compare = serviceRepo.GetCatalogsList();
            serviceRepo.RemoveCatalog(1);
            Assert.AreNotEqual(compare, serviceRepo.GetCatalogsList());
        }
        [TestMethod]

        public void UserTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddUser(1, "Filip", "Testt", "Testing");
            Assert.IsNotNull(serviceRepo.GetUsersList());
            IEnumerable<IUserServiceData> compare = serviceRepo.GetUsersList();
            serviceRepo.RemoveUser(1);
            Assert.AreNotEqual(compare, serviceRepo.GetUsersList());
        }

        [TestMethod]
        public void EventsTest()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddUser(1, "Filip", "Test", "Test 1");
            serviceRepo.AddCatalog(1, "Sofa", 199);
            serviceRepo.AddState(1, 5, 1);

            List<IEventServiceData> compare = serviceRepo.GetEventsList();

            serviceRepo.SellItem(1, 1, 1, 3);
            serviceRepo.ReturnItem(2, 1, 1, 2);
            serviceRepo.SupplyItem(3, 1, 1, 1);

            Assert.AreNotEqual(compare, serviceRepo.GetEventsList());

            serviceRepo.RemoveEvent(1);
            serviceRepo.RemoveEvent(2);
            serviceRepo.RemoveEvent(3);
            serviceRepo.RemoveState(1);
            serviceRepo.RemoveCatalog(1);
            serviceRepo.RemoveUser(1);
        }

        [TestMethod]
        public void StateTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddCatalog(1, "Sofa", 199);
            serviceRepo.AddState(1, 5, 1);

            List<IStateServiceData> compare = serviceRepo.GetStatesList();
        }

    }
}