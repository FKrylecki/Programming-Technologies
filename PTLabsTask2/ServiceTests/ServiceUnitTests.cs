
using Data.API;
using Data.CodeImplementation;
using Services.API;
using Services.CodeImplementation;
using System.Data.SqlTypes;

namespace ServiceTests
{
    [TestClass]
    public class ServiceUnitTests
    {
       
        private const string defaultConnectionString = "Data Source = (localdb) Local;Initial Catalog = PTLabdb; Integrated Security = True";
        private static IDataRepository dataRepository = new DataRepository(defaultConnectionString);
        private Service s = new Service(dataRepository);

        [TestMethod]
        public void TestProductAsync()
        {
            s.AddCatalog(7, "Potato", 222);
            Task<IEnumerable<ICatalog>> a = s.GetCatalogsList();
            Assert.IsNotNull(s.GetCatalogsList());
            s.RemoveCatalog(7);
            Assert.AreNotEqual(a, s.GetCatalogsList());
            s.RemoveCatalog(7);
        }

        //[TestMethod]
        //public void CatalogTest()
        //{
        //    IService serviceRepo = IService.CreateNewService(defaultConnectionString);
        //    serviceRepo.AddCatalog(1, "Sofa", 199);
        //    Assert.IsNotNull(serviceRepo.GetCatalogsList());
        //    IEnumerable<ICatalog> compare = (IEnumerable<ICatalog>)serviceRepo.GetCatalogsList();
        //    serviceRepo.RemoveCatalog(1);
        //    Assert.AreNotEqual(compare, serviceRepo.GetCatalogsList());
        //}
        //[TestMethod]

        //public void UserTests()
        //{
        //    IService serviceRepo = IService.CreateNewService(defaultConnectionString);
        //    serviceRepo.AddUser(1, "Filip", "Testt", "Testing");
        //    Assert.IsNotNull(serviceRepo.GetUsersList());
        //    IEnumerable<IUser> compare = (IEnumerable<IUser>)serviceRepo.GetUsersList();
        //    serviceRepo.RemoveUser(1);
        //    Assert.AreNotEqual(compare, serviceRepo.GetUsersList());
        //}

        //[TestMethod]
        //public void EventsTest()
        //{
        //    IService serviceRepo = IService.CreateNewService(defaultConnectionString);
        //    serviceRepo.AddUser(1, "Filip", "Test", "Test 1");
        //    serviceRepo.AddCatalog(1, "Sofa", 199);
        //    serviceRepo.AddState(1, 5, 1);

        //    IEnumerable<IEvent> compare = (IEnumerable<IEvent>)serviceRepo.GetEventsList();

        //    serviceRepo.SellItem(1, 1, 1, 3);
        //    serviceRepo.ReturnItem(2, 1, 1, 2);
        //    serviceRepo.SupplyItem(3, 1, 1, 1);

        //    Assert.AreNotEqual(compare, serviceRepo.GetEventsList());

        //    serviceRepo.RemoveEvent(1);
        //    serviceRepo.RemoveEvent(2);
        //    serviceRepo.RemoveEvent(3);
        //    serviceRepo.RemoveState(1);
        //    serviceRepo.RemoveCatalog(1);
        //    serviceRepo.RemoveUser(1);
        //}

    }
}