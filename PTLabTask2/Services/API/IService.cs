using System.Collections.Generic;
using Data.API;
using Services.CodeImplementation;


public abstract class  IService
{
    public abstract void AddCatalog(int id, string name, decimal price);
    public abstract void RemoveCatalog(int id);
    public abstract void UpdateCatalog(int id, string name, decimal price);
    public abstract ICatalog GetCatalog(int id);
    public abstract IEnumerable<ICatalog> GetCatalogsList();

    //---------------------------------------------------
    public abstract void AddUser(int id, string firstName, string lastName, string address);
    public abstract void RemoveUser(int id);
    public abstract void UpdateUser(int id, string firstName, string lastName, string address);
    public abstract IUser GetUser(int id);
    public abstract IEnumerable<IUser> GetUsersList();

    //---------------------------------------------------
    public abstract void AddState(int id, int quantity, int catalogId);
    public abstract void RemoveState(int id);
    public abstract IState GetState(int id);
    public abstract IEnumerable<IState> GetStatesList();

    //---------------------------------------------------
    public abstract void RemoveEvent(int id);
    public abstract IEnumerable<IEvent> GetEventsList();
    public abstract void SellItem(int id, int stateId, int userId, int QuantityChanged);
    public abstract void ReturnItem(int id, int stateId, int userId, int QuantityChanged);
    public abstract void SupplyItem(int id, int stateId, int userId, int QuantityChanged);

    public static IService CreateNewService()
    {
        return new Service();
    }

}
