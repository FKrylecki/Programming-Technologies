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
        public override ICatalog GetCatalog(int id)
        {
            return repository.GetCatalog(id);
        }
        public override IEnumerable<ICatalog> GetCatalogsList()
        {
            return repository.GetCatalogsList();
        }

        //------------------------------------------------------
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
        public override IUser GetUser(int id)
        {
            return repository.GetUser(id);
        }
        public override IEnumerable<IUser> GetUsersList()
        {
            return repository.GetUsersList();
        }

        //------------------------------------------------------
        public override void AddState(int id, int quantity, int catalogId)
        {
            repository.AddState(id, quantity, catalogId);
        }
        public override void RemoveState(int id)
        {
            repository.RemoveState(id);
        }
        public override IState GetState(int id)
        {
            return repository.GetState(id);
        }
        public override IEnumerable<IState> GetStatesList()
        {
            return repository.GetStatesList();
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
