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
        void AddUser(int id, string firstName, string lastName, string address)
        {
            repository.AddUser(id, firstName, lastName, address);
        }
        void RemoveUser(int id)
        {
            repository.RemoveUser(id);
        }
        void UpdateUser(int id, string firstName, string lastName, string address)
        {
            repository.UpdateUser(id, firstName, lastName, address);
        }
        IUser GetUser(int id)
        {
            return repository.GetUser(id);
        }
        IEnumerable<IUser> GetUsersList()
        {
            return repository.GetUsersList();
        }
        void AddState(int id, int quantity, int catalogId)
        {
            repository.AddState(id, quantity, catalogId);
        }
        void RemoveState(int id)
        {
            repository.RemoveState(id);
        }
        IState GetState(int id)
        {
            return repository.GetState(id);
        }
        IEnumerable<IState> GetStatesList()
        {
            return repository.GetStatesList();
        }
        void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            repository.AddEvent(id, stateId, userId, QuantityChanged);
        }
        void RemoveEvent(int id)
        {
            repository.RemoveEvent(id);
        }
        IEnumerable<IEvent> GetEventsList()
        {
            return repository.GetEventsList();
        }
    }
}
