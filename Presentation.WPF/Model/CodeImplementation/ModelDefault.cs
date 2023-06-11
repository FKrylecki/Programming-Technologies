using Data;
using Data.API;
using Presentation.WPF.Model.API;
using Services.API;
using Services.CodeImplementation;
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

        internal ModelDefault(IService? _service = null)
        {
            service = _service ?? IService.CreateNewService();
        }

        private CatalogModelData CatalogToModel(ICatalogServiceData c)
        {
            return c == null ? null : new CatalogModelData(c.Id, c.Name, c.Price);
        }

        public List<ICatalogModelData> GetCatalogsList()
        {
            var listData = service.GetCatalogsList();
            List<ICatalogModelData> result = new List<ICatalogModelData>();

            foreach (var entry in listData)
            {
                result.Add(CatalogToModel(entry));
            }
            return result;
        }
        public async Task RemoveCatalog(int id)
        {
            await Task.Run(() => { service.RemoveCatalog(id); });
        }
        public async Task AddCatalog(int id, string name, decimal price)
        {
            await Task.Run(() => { service.AddCatalog(id, name, price); });
        }

        //--------------------------------------------------------------------------

        private UserModelData UserToModel(IUserServiceData e)
        {
            return e == null ? null : new UserModelData(e.Id, e.FirstName, e.LastName, e.Address);
        }

        public List <IUserModelData> GetUsersList()
        {
            var listData = service.GetUsersList();
            List<IUserModelData> result = new List<IUserModelData>();

            foreach (var entry in listData)
            {
                result.Add(UserToModel(entry));
            }
            return result;
        }
        public async Task RemoveUser(int id)
        {
            await Task.Run(() => { service.RemoveUser(id); });
        }
        public async Task AddUser(int id, string firstname, string lastname, string address)
        {
            await Task.Run(() => { service.AddUser(id, firstname, lastname, address); });
        }

        //--------------------------------------------------------------------------

        private StateModelData StateToModel(IStateServiceData s)
        {
            return s == null ? null : new StateModelData(s.StateId, s.Catalog, s.Quantity);
        }

        public List <IStateModelData> GetStatesList()
        {
            var listData = service.GetStatesList();
            List<IStateModelData> result = new List<IStateModelData>();

            foreach (var entry in listData)
            {
                result.Add(StateToModel(entry));
            }
            return result;
        }
        public async Task RemoveState(int id)
        {
            await Task.Run(() => { service.RemoveState(id); });
        }
        public async Task AddState(int id, int quantity, int catalogId)
        {
            await Task.Run(() => { service.AddState(id, quantity, catalogId); });
        }

        //--------------------------------------------------------------------------

        private EventModelData EventToModel(IEventServiceData e)
        {
            return e == null ? null : new EventModelData(e.Id, e.StateId, e.UserId, e.QuantityChanged);
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
        
        public List <IEventModelData> GetEventsList()
        {
            var listData = service.GetEventsList();
            List<IEventModelData> result = new List<IEventModelData>();

            foreach (var entry in listData)
            {
                result.Add(EventToModel(entry));
            }
            return result;
        }
    }
}
