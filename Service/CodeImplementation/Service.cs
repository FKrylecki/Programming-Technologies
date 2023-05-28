using Data.API;
using System.Collections.Generic;
using Services.API;
using System.Diagnostics;
using System.Net;
using Data;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Services.CodeImplementation
{
    public class Service : IService
    {
        private readonly IDataRepository repository;

        public Service(IDataRepository _repository) 
        {
            repository = _repository;
        }

        public Service()
        {
        }

        //------------------------------------------------------

        public async override Task AddCatalog(int id, string name, decimal price)
        {
            await Task.Run(() => { repository.AddCatalog(id, name, price); });
        }
        public async override Task RemoveCatalog(int id)
        {
            await Task.Run(() => { repository.RemoveCatalog(id); });
        }
        public async override Task<IEnumerable<ICatalog>> GetCatalogsList()
        {
            return repository.GetCatalogsList();
        }

        //------------------------------------------------------
        public async override Task AddUser(int id, string firstName, string lastName, string address)
        {
            await Task.Run(() => { repository.AddUser(id, firstName, lastName, address); });
        }
        public async override Task RemoveUser(int id)
        {
            await Task.Run(() => { repository.RemoveUser(id); });
        }
        public async override Task GetUser(int id)
        {
            await Task.Run(() => { repository.GetUser(id); });
        }
        public async override Task<IEnumerable<IUser>> GetUsersList()
        {
            return repository.GetUsersList();
        }

        //------------------------------------------------------
        public async override Task AddState(int id, int quantity, int catalogId)
        {
            await Task.Run(() => { repository.AddState(id, quantity, catalogId); });
        }
        public async override Task RemoveState(int id)
        {
            await Task.Run(() => { repository.RemoveState(id); });
        }
        public async override Task<IEnumerable<IState>> GetStatesList()
        {
            return repository.GetStatesList();
        }

        //------------------------------------------------------
        private async Task AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            await Task.Run(() => { repository.AddEvent(id, stateId, userId, QuantityChanged); });
        }
        public async override Task RemoveEvent(int id)
        {
            await Task.Run(() => { repository.RemoveEvent(id); });
        }
        public async override Task<IEnumerable<IEvent>> GetEventsList()
        {
            return repository.GetEventsList();
        }
        public async override Task SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await AddEvent(id, stateId, userId, -QuantityChanged);
        }
        public async override Task ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await AddEvent(id, stateId, userId, QuantityChanged);
        }
        public async override Task SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await AddEvent(id, stateId, userId, QuantityChanged);
        }
    }
}
