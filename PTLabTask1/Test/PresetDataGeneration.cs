using Data.API;
using Data.CodeImplementation;
using Logic.API;
using Logic.CodeImplementation;

namespace Test
{
    internal class PresetDataGeneration : IDataGenerator
    {
        public override void genrate(IDataRepository DR)
        {
            DR.AddUser(new User("C0001", "Bill", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User("C0002", "Anna", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User("C0003", "Hank", "White", "31 Blueberry St. New York"));
            DR.AddUser(new User("C0004", "Mark", "Robert", "101 Willson St. New York"));
            DR.AddUser(new User("W0001", "Bob", "Reves", "50 Colorado St. New York"));

            ICatalog c1 = new Catalog("S01A", "Night Table Aga", 299.99f);
            ICatalog c2 = new Catalog("S02A", "Night Table Panama", 269.99f);
            ICatalog c3 = new Catalog("S03A", "Night Table Besta", 359.99f);
            ICatalog c4 = new Catalog("S01B", "Wardrobe Dąb", 999.99f);
            ICatalog c5 = new Catalog("S02B", "Double Wardrobe Aga", 1299.99f);
            ICatalog c6 = new Catalog("B02B", "Desk Hawana", 699.99f);
            ICatalog c7 = new Catalog("B02C", "Desk Lozana", 399.99f);

            DR.AddCatalog(c1);
            DR.AddCatalog(c2);
            DR.AddCatalog(c3);
            DR.AddCatalog(c4);
            DR.AddCatalog(c5);
            DR.AddCatalog(c6);
            DR.AddCatalog(c7);

            DR.AddState(new State("Q1", 24, c1));
            DR.AddState(new State("Q2", 44, c2));
            DR.AddState(new State("Q3", 20, c3));
            DR.AddState(new State("Q4", 12, c4));
            DR.AddState(new State("Q5", 10, c5));
            DR.AddState(new State("Q6", 10, c6));
            DR.AddState(new State("Q7", 10, c7));

            DR.AddEvent(new Sell("Q1", "C0001", 2));
            DR.AddEvent(new Sell("Q2", "C0002", 1));
            DR.AddEvent(new Sell("Q3", "C0004", 5));
            DR.AddEvent(new Supply("Q4", "W0001", 10));
            DR.AddEvent(new Return("Q5", "W0001", 2));
        }
    }
}
