using Data.API;

namespace Data.CodeImplementation
{
    internal class DataContext : IDataContext
    {
        internal List<IEvent> events = new();
        List<IState> states = new();
        List<IUser> users = new();
        Dictionary<string, ICatalog> dictionary = new();
    }
}
