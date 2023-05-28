using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.WPF.ViewModel;
using Presentation.WPF.Model.API;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PresentationTests
{
    [TestClass]
    public class PresentationTests
    {
        private readonly Presentation.WPF.Model.API.IModel model = Presentation.WPF.Model.API.IModel.CreateNewModel();
        [TestMethod]
        public void UserPresentation()
        {
            VMUserList list = new VMUserList(model);
            VMUsers User = new VMUsers(1, "Test", "Test", "Test");
            list.UserView.Add(User);
            model.AddUser(1, "Test", "Test", "Test");
            Assert.AreEqual(list.UserView.Count(), 1);
            Assert.AreEqual(User.Id, 1);
            Assert.AreEqual(User.firstName, "Test");
            model.RemoveUser(1);
            list.UserView.Remove(User);
        }
        [TestMethod]
        public void CatalogPresentation()
        {
            VMCatalogList list = new VMCatalogList(model);
            VMCatalogs Cat = new VMCatalogs(1, "Test", 200);
            list.CatView.Add(Cat);
            model.AddCatalog(1, "Test", 200);
            Assert.AreEqual(list.CatView.Count(), 1);
            Assert.AreEqual(Cat.Id, 1);
            Assert.AreEqual(Cat.Name, "Test");
            model.RemoveCatalog(1);
            list.CatView.Remove(Cat);
        }
    }
}