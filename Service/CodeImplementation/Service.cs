using Data.API;
using System.Collections.Generic;
using Services.API;
using System.Diagnostics;
using System.Net;
using Data;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Data.CodeImplementation;

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
            repository = IDataRepository.CreateNewRepository();
        }

        

        //------------------------------------------------------

        private CatalogServiceData CatalogToService(ICatalog c)
        {
            if (c == null)
                return null;
            return new CatalogServiceData(c.Id, c.Name, c.Price);
        }
        public async override Task AddCatalog(int id, string name, decimal price)
        {
            await Task.Run(() => { repository.AddCatalog(id, name, price); });
        }
        public async override Task RemoveCatalog(int id)
        {
            await Task.Run(() => { repository.RemoveCatalog(id); });
        }
        public override List<ICatalogServiceData> GetCatalogsList()
        {
            IEnumerable<ICatalog> listData = repository.GetCatalogsList();
            List<ICatalogServiceData> result = new List<ICatalogServiceData>();
            foreach (var entry in listData)
                result.Add(CatalogToService(entry));

            return result;
        }

        //------------------------------------------------------
        private UserServiceData UserToService(IUser u)
        {
            if (u == null)
                return null;
            return new UserServiceData(u.Id, u.FirstName, u.LastName, u.Address);
        }
        public async override Task AddUser(int id, string firstName, string lastName, string address)
        {
            await Task.Run(() => { repository.AddUser(id, firstName, lastName, address); });
        }
        public async override Task RemoveUser(int id)
        {
            await Task.Run(() => { repository.RemoveUser(id); });
        }

        public override List<IUserServiceData> GetUsersList()
        {
            IEnumerable<IUser> listData = repository.GetUsersList();
            List<IUserServiceData> result = new List<IUserServiceData>();
            foreach (var entry in listData)
                result.Add(UserToService(entry));

            return result;
        }

        //------------------------------------------------------
        private StateServiceData StateToService(IState s)
        {
            if (s == null)
                return null;
            return new StateServiceData(s.StateId, s.Catalog, s.Quantity);
        }

        public async override Task AddState(int id, int quantity, int catalogId)
        {
            await Task.Run(() => { repository.AddState(id, quantity, catalogId); });
        }
        public async override Task RemoveState(int id)
        {
            await Task.Run(() => { repository.RemoveState(id); });
        }
        public override List<IStateServiceData> GetStatesList()
        {
            IEnumerable<IState> listData = repository.GetStatesList();
            List<IStateServiceData> result = new List<IStateServiceData>();
            foreach (var entry in listData)
                result.Add(StateToService(entry));

            return result;
        }

        //------------------------------------------------------
        private EventServiceData EventToService(IEvent e)
        {
            if (e == null)
                return null;
            return new EventServiceData(e.Id, e.StateId, e.UserId, e.QuantityChanged);
        }
        private async Task AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            await Task.Run(() => { repository.AddEvent(id, stateId, userId, QuantityChanged); });
        }
        public async override Task RemoveEvent(int id)
        {
            await Task.Run(() => { repository.RemoveEvent(id); });
        }
        public override List<IEventServiceData> GetEventsList()
        {
            IEnumerable<IEvent> listData = repository.GetEventsList();
            List<IEventServiceData> result = new List<IEventServiceData>();
            foreach (var entry in listData)
                result.Add(EventToService(entry));

            return result;
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
