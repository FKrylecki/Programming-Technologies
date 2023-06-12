using IModel = Presentation.WPF.Model.API.IModel;

namespace PresentationTests
{
    [TestClass]
    public class PresentationLayersTests
    {
        private readonly IModel model = IModel.CreateNewModel();

        [TestMethod]
        public void UserModelTest()
        {
            model.AddUser(10, "Test", "Test", "Test");
            Assert.IsNotNull(model);
            model.RemoveUser(10);
        }
        [TestMethod]
        public void CatalogModelTest()
        {
            model.AddCatalog(10, "Test", 200);
            Assert.IsNotNull(model);
            model.RemoveCatalog(10);
        }
        [TestMethod]
        public void StateModelTest()
        {
            model.AddState(10, 10, 10);
            Assert.IsNotNull(model);
            model.RemoveState(10);
        }
        [TestMethod]
        public void EventModelTest()
        {
            model.ReturnItem(10, 10, 10, 10);
            Assert.IsNotNull(model);
            model.RemoveEvent(10);
        }
    }
}
