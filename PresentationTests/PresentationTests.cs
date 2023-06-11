using Microsoft.EntityFrameworkCore.Metadata;
using Presentation.WPF.Model.API;
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
            //model.AddUser(1, "Test", "Test", "Test");
            //Assert.AreEqual(model.GetUsersList().Count(), 1);
            //model.RemoveCatalog(1);
            //Assert.AreEqual(model.GetUsersList().Count(), 0);
        }
    }
}
