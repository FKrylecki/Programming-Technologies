using System.Collections.Generic;
using Data.CodeImplementation;

namespace Data.API
{

    public interface IDataRepository
    {
        void AddCatalog(int id, string name, decimal price);
        void RemoveCatalog(int id);
        void UpdateCatalog(int id, string name, decimal price);
        ICatalog GetCatalog(int id);
        IEnumerable<ICatalog> GetCatalogsList();

        //---------------------------------------------------
        void AddUser(int id, string firstName, string lastName, string address);
        void RemoveUser(int id);
        void UpdateUser(int id, string firstName, string lastName, string address);
        IUser GetUser(int id);
        IEnumerable<IUser> GetUsersList();

        //---------------------------------------------------
        void AddState(int id, int quantity, int catalogId);
        void RemoveState(int id);
        IState GetState(int id);
        IEnumerable<IState> GetStatesList();
        void ChangeQuantity(int stateId, int change);

        //---------------------------------------------------
        void AddEvent(int id, int stateId, int userId, int QuantityChanged);
        void RemoveEvent(int id);
        IEnumerable<IEvent> GetEventsList();

        //---------------------------------------------------


    }
}
