using System.Collections.Generic;
using Data.API;
using Services.API;
using Services.CodeImplementation;


public abstract class  IService
{
    public abstract void AddCatalog(int id, string name, decimal price);
    public abstract void RemoveCatalog(int id);
    public abstract void UpdateCatalog(int id, string name, decimal price);
    public abstract ICatalogServiceData GetCatalog(int id);
    public abstract IEnumerable<ICatalogServiceData> GetCatalogsList();

    //---------------------------------------------------
    public abstract void AddUser(int id, string firstName, string lastName, string address);
    public abstract void RemoveUser(int id);
    public abstract void UpdateUser(int id, string firstName, string lastName, string address);
    public abstract IUserServiceData GetUser(int id);
    public abstract IEnumerable<IUserServiceData> GetUsersList();

    //---------------------------------------------------
    public abstract void AddState(int id, int quantity, int catalogId);
    public abstract void RemoveState(int id);
    public abstract IStateServiceData GetState(int id);
    public abstract IEnumerable<IStateServiceData> GetStatesList();

    //---------------------------------------------------
    public abstract void RemoveEvent(int id);
    public abstract IEnumerable<IEventServiceData> GetEventsList();
    public abstract void SellItem(int id, int stateId, int userId, int QuantityChanged);
    public abstract void ReturnItem(int id, int stateId, int userId, int QuantityChanged);
    public abstract void SupplyItem(int id, int stateId, int userId, int QuantityChanged);

    public static IService CreateNewService()
    {
        return new Service();
    }

}
