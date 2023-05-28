
using Data.API;
using Data.CodeImplementation;
using Services.API;


namespace ServiceTests
{
    [TestClass]
    public class ServiceUnitTests
    {
       
        private const string defaultConnectionString = "Data Source = (localdb) Local;Initial Catalog = PTLabdb; Integrated Security = True";
        IService serviceRepo = IService.CreateNewService(defaultConnectionString);

        [TestMethod]
        public void CatalogTest()
        {
            
            serviceRepo.AddCatalog(1, "Sofa", 199);
            Assert.IsNotNull(serviceRepo.GetCatalogsList());
            Task<IEnumerable<ICatalog>> compare = serviceRepo.GetCatalogsList();
            serviceRepo.RemoveCatalog(1);
            Assert.AreNotEqual(compare, serviceRepo.GetCatalogsList());
        }
        [TestMethod]

        public void UserTests()
        {
            serviceRepo.AddUser(1, "Filip", "Testt", "Testing");
            Assert.IsNotNull(serviceRepo.GetUsersList());
            Task<IEnumerable<IUser>> compare = serviceRepo.GetUsersList();
            serviceRepo.RemoveUser(1);
            Assert.AreNotEqual(compare, serviceRepo.GetUsersList());
        }

        [TestMethod]
        public void EventsTest()
        {
            serviceRepo.AddUser(1, "Filip", "Test", "Test 1");
            serviceRepo.AddCatalog(1, "Sofa", 199);
            serviceRepo.AddState(1, 5, 1);

            Task<IEnumerable<IEvent>> compare = serviceRepo.GetEventsList();

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

        public void StateTests()
        {
            serviceRepo.AddCatalog(1, "Sofa", 199);
            serviceRepo.AddState(1, 5, 1);

            Task<IEnumerable<IState>> compare = serviceRepo.GetStatesList();
        }

    }
}