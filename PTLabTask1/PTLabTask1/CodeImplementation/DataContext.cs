using Data.API;

namespace Data.CodeImplementation
{
    internal class DataContext : IDataContext
    {
        internal List<IEvent> events = new();
        internal List<IState> states = new();
        internal List<IUser> users = new();
        internal Dictionary<string, ICatalog> dictionary = new();

    }
}
