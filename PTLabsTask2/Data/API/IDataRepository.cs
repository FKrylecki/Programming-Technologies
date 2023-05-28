using System.Collections.Generic;
using Data.CodeImplementation;

namespace Data.API
{

    public abstract class IDataRepository
    {
        public abstract void AddCatalog(int id, string name, decimal price);
        public abstract void RemoveCatalog(int id);
        public abstract ICatalog GetCatalog(int id);
        public abstract IEnumerable<ICatalog> GetCatalogsList();

        //---------------------------------------------------
        public abstract void AddUser(int id, string firstName, string lastName, string address);
        public abstract void RemoveUser(int id);
        public abstract IUser GetUser(int id);
        public abstract IEnumerable<IUser> GetUsersList();

        //---------------------------------------------------
        public abstract void AddState(int id, int quantity, int catalogId);
        public abstract void RemoveState(int id);
        public abstract IState GetState(int id);
        public abstract IEnumerable<IState> GetStatesList();
        public abstract void ChangeQuantity(int stateId, int change);

        //---------------------------------------------------
        public abstract void AddEvent(int id, int stateId, int userId, int QuantityChanged);
        public abstract void RemoveEvent(int id);
        public abstract IEnumerable<IEvent> GetEventsList();

        //---------------------------------------------------

        public abstract void ClearAll();

        public static IDataRepository CreateNewRepository()
        {
            return new DataRepository();
        }

        public static IDataRepository CreateNewRepository(string connectionString)
        {
            return new DataRepository(connectionString);
        }
    }
}
