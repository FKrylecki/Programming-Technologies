using Data.API;
using System.Collections.Generic;

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
        public void AddCatalog(int id, string name, decimal price)
        {
            repository.AddCatalog(id, name, price);
        }
        public void RemoveCatalog(int id)
        {
            repository.RemoveCatalog(id);
        }
        public void UpdateCatalog(int id, string name, decimal price)
        {
            repository.UpdateCatalog(id, name, price);
        }
        public ICatalog GetCatalog(int id)
        {
            return repository.GetCatalog(id);
        }
        public IEnumerable<ICatalog> GetCatalogsList()
        {
            return repository.GetCatalogsList();
        }

        //------------------------------------------------------
        public void AddUser(int id, string firstName, string lastName, string address)
        {
            repository.AddUser(id, firstName, lastName, address);
        }
        public void RemoveUser(int id)
        {
            repository.RemoveUser(id);
        }
        public void UpdateUser(int id, string firstName, string lastName, string address)
        {
            repository.UpdateUser(id, firstName, lastName, address);
        }
        public IUser GetUser(int id)
        {
            return repository.GetUser(id);
        }
        public IEnumerable<IUser> GetUsersList()
        {
            return repository.GetUsersList();
        }

        //------------------------------------------------------
        public void AddState(int id, int quantity, int catalogId)
        {
            repository.AddState(id, quantity, catalogId);
        }
        public void RemoveState(int id)
        {
            repository.RemoveState(id);
        }
        public IState GetState(int id)
        {
            return repository.GetState(id);
        }
        public IEnumerable<IState> GetStatesList()
        {
            return repository.GetStatesList();
        }

        //------------------------------------------------------
        private void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            repository.AddEvent(id, stateId, userId, QuantityChanged);
        }
        public void RemoveEvent(int id)
        {
            repository.RemoveEvent(id);
        }
        public IEnumerable<IEvent> GetEventsList()
        {
            return repository.GetEventsList();
        }
        public void SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, -QuantityChanged);
        }
        public void ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, QuantityChanged);
        }
        public void SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            AddEvent(id, stateId, userId, QuantityChanged);
        }
    }
}
