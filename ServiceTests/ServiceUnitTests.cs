
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
            List<IUserServiceData> compare = serviceRepo.GetUsersList();
            serviceRepo.RemoveUser(1);
            Assert.AreNotEqual(compare, serviceRepo.GetUsersList());
        }

        [TestMethod]
        public void StateTests()
        {
            IService serviceRepo = IService.CreateNewService(new MockDataLayer());
            serviceRepo.AddCatalog(2, "Sofa", 199);
            serviceRepo.AddState(1, 5, 2);
            List<IStateServiceData> compare = serviceRepo.GetStatesList();
            serviceRepo.RemoveState(1); 
            serviceRepo.RemoveCatalog(1);
            Assert.AreNotEqual(compare, serviceRepo.GetUsersList());
        }

    }
}