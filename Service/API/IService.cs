using System.Collections.Generic;
using Services.API;
using Data.API;
using Services.CodeImplementation;

namespace Services.API
{
    public abstract class IService
    {
        public abstract Task AddCatalog(int id, string name, decimal price);
        public abstract Task RemoveCatalog(int id);
        public abstract List<ICatalogServiceData> GetCatalogsList();

        //---------------------------------------------------
        public abstract Task AddUser(int id, string firstName, string lastName, string address);
        public abstract Task RemoveUser(int id);
        public abstract List<IUserServiceData> GetUsersList();

        //---------------------------------------------------
        public abstract Task AddState(int id, int quantity, int catalogId);
        public abstract Task RemoveState(int id);
        public abstract List<IStateServiceData> GetStatesList();

        //---------------------------------------------------
        public abstract Task RemoveEvent(int id);
        public abstract List<IEventServiceData> GetEventsList();

        //Business Logic:
        public abstract Task SellItem(int id, int stateId, int userId, int QuantityChanged);
        public abstract Task ReturnItem(int id, int stateId, int userId, int QuantityChanged);
        public abstract Task SupplyItem(int id, int stateId, int userId, int QuantityChanged);

        public static IService CreateNewService(string connectionString)
        {
            return new Service(IDataRepository.CreateNewRepository(connectionString));
        }
        public static IService CreateNewService()
        {
            return new Service();
        }

    }
}

