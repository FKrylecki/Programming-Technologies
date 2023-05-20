using System.Collections.Generic;
using Data.CodeImplementation;

namespace Data.API
{

    public interface IDataRepository
    {
        void AddCatalog(ICatalog c);
        void RemoveCatalog(int id);
        void UpdateCatalog(int id, string name, decimal price);
        ICatalog GetCatalog(int id);
        IEnumerable<ICatalog> GetCatalogsList();

        //---------------------------------------------------
        void AddUser(IUser u);
        void RemoveUser(int id);
        void UpdateUser(int id, string firstName, string lastName, string address);
        IUser GetUser(int id);
        IEnumerable<IUser> GetUsersList();

        //---------------------------------------------------
        void AddState(IState s);
        void RemoveState(IState s);
        IState GetState(int id);
        IEnumerable<IState> GetStatesList();
        void ChangeQuantity(int stateId, int change);

        //---------------------------------------------------
        void AddEvent(IEvent e);
        void RemoveEvent(IEvent e);
        IEnumerable<IEvent> GetEventsList();

        //---------------------------------------------------


    }
}
