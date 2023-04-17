using Data.API;
using Data.CodeImplementation;

namespace Test
{
    [TestClass]
    public class PresetDataGenerationTest
    {
        [TestMethod]
        public void TestPresetDataGeneration()
        {
            IDataRepository DR = new DataRepository(null);
            IDataGenerator DG = new PresetDataGeneration();
            DG.genrate(DR); 

            Assert.AreEqual(DR.GetUser("C0001").Id, "C0001");
            Assert.AreEqual(DR.GetUser("C0002").FirstName, "Anna");
            Assert.AreEqual(DR.GetUser("C0003").LastName, "White");
            Assert.AreEqual(DR.GetUser("C0004").Address, "101 Willson St. New York");
            Assert.AreEqual(DR.GetUsersList().Count(), 5);
            DR.RemoveUser("C0001");
            Assert.AreEqual(DR.GetUsersList().Count(), 4);

            Assert.AreEqual(DR.GetCatalog("S01A").Id, "S01A");
            Assert.AreEqual(DR.GetCatalog("S02A").Name, "Night Table Panama");
            Assert.AreEqual(DR.GetCatalog("S03A").Price, 359.99f);
            Assert.AreEqual(DR.GetCatalogsList().Count(), 7);
            DR.RemoveCatalog("S01A");
            Assert.AreEqual(DR.GetCatalogsList().Count(), 6);

            Assert.AreEqual(DR.GetState("Q1").ItemId, "S01A");
            Assert.AreEqual(DR.GetState("Q2").Quantity, 44);
            Assert.AreEqual(DR.GetState("Q3").StateId, "Q3");
            Assert.AreEqual(DR.GetStatesList().Count(), 7);
            DR.RemoveState(DR.GetState("Q1"));
            Assert.AreEqual(DR.GetStatesList().Count(), 6);

            Assert.AreEqual(DR.GetEventsList().Count(), 5);
        }
    }
}
