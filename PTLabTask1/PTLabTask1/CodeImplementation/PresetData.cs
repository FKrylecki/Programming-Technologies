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
            DR.AddUser(new User("C0004", "Mark", "Robert", "101 Grove St. New York"));
        }
    }
}
