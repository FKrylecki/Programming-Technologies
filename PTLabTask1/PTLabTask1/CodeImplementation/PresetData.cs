using Data.API;

namespace Data.CodeImplementation
{
    internal class PresetData : IDataGenerator
    {
        public override void genrate(IDataRepository DR)
        {
            DR.AddUser(new User("C0001", "Bill", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User("C0002", "Anna", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User("C0003", "Hank", "White", "31 Blueberry St. New York"));
            DR.AddUser(new User("C0004", "Mark", "Robert", "101 Willson St. New York"));

            ICatalog c1 = new Catalog("S01A", "Szafka Nocna Aga", 299.99f);
            ICatalog c2 = new Catalog("S02A", "Szafka Nocna Panama", 269.99f);
            ICatalog c3 = new Catalog("S03A", "Szafka Nocna Besta", 359.99f);
            ICatalog c4 = new Catalog("S01B", "Szafa Przesuwna Dąb", 999.99f);
            ICatalog c5 = new Catalog("S02B", "Szafka 2-drzwiowa Aga", 1299.99f);
            ICatalog c6 = new Catalog("B02B", "Biurko Hawana", 699.99f);
            ICatalog c7 = new Catalog("B02B", "Biurko Lozana", 399.99f);

            DR.AddCatalog(c1);
            DR.AddCatalog(c2);
            DR.AddCatalog(c3);
            DR.AddCatalog(c4);
            DR.AddCatalog(c5);
            DR.AddCatalog(c6);
            DR.AddCatalog(c7);

            DR.AddState(new State("Q", 24, c1));
            DR.AddState(new State("Q", 44, c2));
            DR.AddState(new State("Q", 20, c3));
            DR.AddState(new State("Q", 12, c4));
            DR.AddState(new State("Q", 10, c5));
            DR.AddState(new State("Q", 10, c6));
            DR.AddState(new State("Q", 10, c7));

            DR.AddEvent(new )


        }
    }
}
