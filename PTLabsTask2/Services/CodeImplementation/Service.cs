using Data.API;
using System.Collections.Generic;
using Services.API;

namespace Services.CodeImplementation
{
    internal class Service : IService
    {
        private readonly IDataRepository repository;

        public Service(IDataRepository _repository = default) 
        {
            repository = _repository ?? IDataRepository.CreateNewRepository();
        }

        //------------------------------------------------------
        private ICatalogServiceData CatalogToService(ICatalog c)
        {
            return c == null ? null : new CatalogServiceData(c.Id, c.Name, c.Price);
        }

        public override void AddCatalog(int id, string name, decimal price)
        {
            repository.AddCatalog(id, name, price);
        }
        public override void RemoveCatalog(int id)
        {
            repository.RemoveCatalog(id);
        }
        public override void UpdateCatalog(int id, string name, decimal price)
        {
            repository.UpdateCatalog(id, name, price);
        }
        public override ICatalogServiceData GetCatalog(int id)
        {
            return CatalogToService(repository.GetCatalog(id));
        }
        public override IEnumerable<ICatalogServiceData> GetCatalogsList()
        {
            List<ICatalogServiceData> catalogs = new List<ICatalogServiceData>();
            foreach (ICatalog c in repository.GetCatalogsList()) 
            { 
                catalogs.Add(CatalogToService(c));
            }
            return catalogs;
        }

        //------------------------------------------------------
        private IUserServiceData UserToService(IUser u)
        {
            return u == null ? null : new UserServiceData(u.Id, u.FirstName, u.LastName, u.Address);
        }
        public override void AddUser(int id, string firstName, string lastName, string address)
        {
            repository.AddUser(id, firstName, lastName, address);
        }
        public override void RemoveUser(int id)
        {
            repository.RemoveUser(id);
        }
        public override void UpdateUser(int id, string firstName, string lastName, string address)
        {
            repository.UpdateUser(id, firstName, lastName, address);
        }
        public override IUserServiceData GetUser(int id)
        {
            return UserToService(repository.GetUser(id));
        }
        public override IEnumerable<IUserServiceData> GetUsersList()
        {
            List<IUserServiceData> users = new List<IUserServiceData>();
            foreach (IUser u in repository.GetUsersList())
            {
                users.Add(UserToService(u));
            }
            return users;
        }

        //------------------------------------------------------
        private IStateServiceData StateToService(IState s)
        {
            return s == null ? null : new StateServiceData(s.StateId, s.Quantity, s.Catalog);
        }
        public override void AddState(int id, int quantity, int catalogId)
        {
            repository.AddState(id, quantity, catalogId);
        }
        public override void RemoveState(int id)
        {
            repository.RemoveState(id);
        }
        public override IStateServiceData GetState(int id)
        {
            return StateToService(repository.GetState(id));
        }
        public override IEnumerable<IStateServiceData> GetStatesList()
        {
            List<IStateServiceData> states = new List<IStateServiceData>();
            foreach (IState s in repository.GetStatesList())
            {
                states.Add(StateToService(s));
            }
            return states;
        }

        //------------------------------------------------------
        private void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            repository.AddEvent(id, stateId, userId, QuantityChanged);
        }
        public override void RemoveEvent(int id)
        {
            repository.RemoveEvent(id);
        }
        public override IEnumerable<IEvent> GetEventsList()
        {
            return repository.GetEventsList();
        }
        public override void SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, -QuantityChanged);
        }
        public override void ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, QuantityChanged);
        }
        public override void SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, QuantityChanged);
        }
    }
}
