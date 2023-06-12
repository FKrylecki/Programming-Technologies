using Presentation.WPF.ViewModel;

namespace PresentationTests
{
    [TestClass]
    public class PresentationViewModelTests
    {
        MockModel model = new MockModel();
        [TestMethod]
        public void UserPresentation()
        {
            VMUserList list = new VMUserList(model);
            VMUsers User = new VMUsers(1, "Test", "Test", "Test");
            model.AddUser(2, "Test", "Test", "Test");
            list.UserView.Add(User);
            Assert.IsTrue(list.UserView.Count == 1);
            Assert.IsTrue(list.UserView[0].Id == 1);
            Assert.IsTrue(list.UserView[0].firstName == "Test");
            Assert.IsTrue(list.UserView[0].lastName == "Test");
            Assert.IsTrue(list.UserView[0].Address == "Test");
            model.RemoveUser(2);
            list.UserView.Remove(User);
            Assert.IsTrue(list.UserView.Count == 0);
        }
        [TestMethod]
        public void CatalogPresentation()
        {
            VMCatalogList list = new VMCatalogList(model);
            VMCatalogs Cat = new VMCatalogs(1, "Test", 200);
            model.AddCatalog(2, "Test", 100);
            list.SelectedVM.Add(Cat);
            Assert.IsTrue(list.SelectedVM.Count == 1);
            Assert.IsTrue(list.SelectedVM[0].Id == 1);
            Assert.IsTrue(list.SelectedVM[0].Name == "Test");
            Assert.IsTrue(list.SelectedVM[0].Price == 200);
            model.RemoveCatalog(2);
            list.SelectedVM.Remove(Cat);
            Assert.IsTrue(list.SelectedVM.Count == 0);
        }
        [TestMethod]
        public void StatePresentation()
        {
            VMStateList list = new VMStateList(model);
            VMCatalogs Cat = new VMCatalogs(1, "Test", 200);
            VMStates State = new VMStates(1, 10, 1);
            model.AddState(2, 10, 1);
            list.StateView.Add(State);
            Assert.IsTrue(list.StateView.Count == 1);
            Assert.IsTrue(list.StateView[0].Id == 1);
            Assert.IsTrue(list.StateView[0].Quantity == 10);
            Assert.IsTrue(list.StateView[0].CatalogId == 1);
            model.RemoveState(2);
            list.StateView.Remove(State);
            Assert.IsTrue(list.StateView.Count == 0);
        }
        [TestMethod]
        public void EventPresentation()
        {
            VMEventList list = new VMEventList(model);
            VMCatalogs Cat = new VMCatalogs(1, "Test", 200);
            VMStates State = new VMStates(1, 10, 1);
            VMUsers User = new VMUsers(1, "Test", "Test", "Test");
            VMEvents Event = new VMEvents(1, 1, 1, 5);
            model.SellItem(2, 1, 1, 0);
            list.SelectedVM.Add(Event);
            Assert.IsTrue(list.SelectedVM.Count == 1);
            Assert.IsTrue(list.SelectedVM[0].Id == 1);
            Assert.IsTrue(list.SelectedVM[0].UserID == 1);
            Assert.IsTrue(list.SelectedVM[0].StateId == 1);
            Assert.IsTrue(list.SelectedVM[0].QuantityChanged == 5);
            model.RemoveState(2);
            list.SelectedVM.Remove(Event);
            Assert.IsTrue(list.SelectedVM.Count == 0);
        }
    }
}