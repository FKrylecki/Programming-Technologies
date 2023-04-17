
using Data.CodeImplementation;

namespace Data.API
{

    public abstract class IDataRepository
    {
        public abstract void AddCatalog(ICatalog c);
        public abstract void RemoveCatalog(string id);
        public abstract ICatalog GetCatalog(string id);
        public abstract IEnumerable<ICatalog> GetCatalogsList();

        //---------------------------------------------------
        public abstract void AddUser(IUser u);
        public abstract void RemoveUser(string id);
        public abstract IUser GetUser(string id);
        public abstract IEnumerable<IUser> GetUsersList();

        //---------------------------------------------------
        public abstract void AddState(IState s);
        public abstract void RemoveState(IState s);
        public abstract IState GetState(string id);
        public abstract IEnumerable<IState> GetStatesList();

        //---------------------------------------------------
        public abstract void AddEvent(IEvent e);
        public abstract void RemoveEvent(IEvent e);
        public abstract IEnumerable<IEvent> GetEventsList();

        //---------------------------------------------------
        public abstract void ChangeQuantity(string stateId ,int change);

        public static IDataRepository CreateNewRepository(IDataGenerator? generator) { 
            return new DataRepository(generator);
        }
    }
}
