using Data.API;
using Logic.API;
using Data.CodeImplementation;
using Logic.CodeImplementation;

namespace Test
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestSellMethod()
        {
        var DR = IDataRepository.CreateNewRepository(null);
        var logicDR = IBusinessLogic.CreateNewLogic(DR);
        DR.AddUser(new User("C0001", "Bill", "Nickolson", "219 Grove St. New York"));
        ICatalog c1 = new Catalog("S01A", "Night Table Aga", 299.99f);
        DR.AddCatalog(c1);
        DR.AddState(new State("Q1", 24, c1));
        logicDR.SellItem("C0001", "Q1", 2);
        Assert.AreEqual(DR.GetState("Q1").Quantity, 22);
        }

        [TestMethod]
        public void TestSupplyMethod()
        {
            var DR = IDataRepository.CreateNewRepository(null);
            var logicDR = IBusinessLogic.CreateNewLogic(DR);
            DR.AddUser(new User("C0001", "Bill", "Nickolson", "219 Grove St. New York"));
            ICatalog c1 = new Catalog("S01A", "Night Table Aga", 299.99f);
            DR.AddCatalog(c1);
            DR.AddState(new State("Q1", 24, c1));
            logicDR.SupplyItem("C0001", "Q1", 20);
            Assert.AreEqual(DR.GetState("Q1").Quantity, 44);
        }

        [TestMethod]
        public void TestReturnMethod()
        {
            var DR = IDataRepository.CreateNewRepository(null);
            var logicDR = IBusinessLogic.CreateNewLogic(DR);
            DR.AddUser(new User("C0001", "Bill", "Nickolson", "219 Grove St. New York"));
            ICatalog c1 = new Catalog("S01A", "Night Table Aga", 299.99f);
            DR.AddCatalog(c1);
            DR.AddState(new State("Q1", 24, c1));
            logicDR.SellItem("C0001", "Q1", 2);
            logicDR.ReturnItem("C0001", "Q1", 1);

            Assert.AreEqual(DR.GetState("Q1").Quantity, 23);

            Assert.ThrowsException<Exception>(() => logicDR.ReturnItem("C0001", "Q2", 1));
        }
    }
}
