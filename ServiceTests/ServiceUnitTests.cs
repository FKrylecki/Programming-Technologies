
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

        }
        [TestMethod]

        public void UserTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddUser(1, "Filip", "Testt", "Testing");
            Assert.IsNotNull(serviceRepo.GetUsersList());

        }

        [TestMethod]
        public void StateTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddCatalog(2, "Sofa", 199);
            serviceRepo.AddState(1, 5, 2);
            Assert.IsNotNull(serviceRepo.GetStatesList());
        }

        [TestMethod]
        public void EventTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddCatalog(2, "Sofa", 199);
            serviceRepo.AddState(1, 5, 2);
            serviceRepo.AddUser(1, "Filip", "Testt", "Testing");
            serviceRepo.SellItem(1, 1, 1, 2);
            Assert.IsNotNull(serviceRepo.GetEventsList());
        }

    }
}