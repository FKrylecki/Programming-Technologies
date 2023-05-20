using System.Collections.Generic;
using Data.API;


public interface IService
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

    //---------------------------------------------------
    void RemoveEvent(int id);
    IEnumerable<IEvent> GetEventsList();
    void SellItem(int id, int stateId, int userId, int QuantityChanged);
    void ReturnItem(int id, int stateId, int userId, int QuantityChanged);
    void SupplyItem(int id, int stateId, int userId, int QuantityChanged);
}
