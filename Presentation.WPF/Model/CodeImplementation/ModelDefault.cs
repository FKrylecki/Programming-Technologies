using Data;
using Data.API;
using Presentation.WPF.Model.API;
using Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class ModelDefault : IModel
    {
        private IService service;

        internal ModelDefault(IService? _service = default)
        {
            service = _service ?? IService.CreateNewService();
        }

        public Task <ICatalogModelData> GetCatalogsList()
        {
            return null;
        }
        public async Task RemoveCatalog(int id)
        {
            await Task.Run(() => { service.RemoveCatalog(id); });
        }
        public async Task AddCatalog(int id, string name, decimal price)
        {
            await Task.Run(() => { service.AddCatalog(id, name, price); });
        }
        public Task <IUserModelData> GetUsersList()
        {
            //return (List<IUserModelData>)service.GetUsersList();
            return null;
        }
        public async Task RemoveUser(int id)
        {
            await Task.Run(() => { service.RemoveUser(id); });
        }
        public async Task AddUser(int id, string firstname, string lastname, string address)
        {
            await Task.Run(() => { service.AddUser(id, firstname, lastname, address); });
        }
        public async Task GetUser(int id)
        {
            await Task.Run(() => { service.GetUser(id); });
        }
        public Task <IStateModelData> GetStatesList()
        {
            //return (List<IStateModelData>)service.GetStatesList();
            return null;
        }
        public async Task RemoveState(int id)
        {
            await Task.Run(() => { service.RemoveState(id); });
        }
        public async Task AddState(int id, int quantity, int catalogId)
        {
            await Task.Run(() => { service.AddState(id, quantity, catalogId); });
        }
        public async Task SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await Task.Run(() => { service.SellItem(id, stateId, userId, -QuantityChanged); });
        }
        public async Task ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await Task.Run(() => { service.ReturnItem(id, stateId, userId, QuantityChanged); });
        }
        public async Task SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            await Task.Run(() => { service.SupplyItem(id, stateId, userId, QuantityChanged); });
        }
        public async Task RemoveEvent(int id)
        {
            await Task.Run(() => { service.RemoveEvent(id); });
        }
        
        public Task <IEventModelData> GetEventsList()
        {
            return null;
        }
    }
}
