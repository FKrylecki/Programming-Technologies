
using Data.API;
using System.Collections.Generic;

namespace Services.CodeImplementation
{
    internal class Service : IService
    {
        public void AddCatalog(int id, string name, decimal price)
        {
            throw new System.NotImplementedException();
        }

        public void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            throw new System.NotImplementedException();
        }

        public void AddState(int id, int quantity, int catalogId)
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(int id, string firstName, string lastName, string address)
        {
            throw new System.NotImplementedException();
        }

        public ICatalog GetCatalog(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ICatalog> GetCatalogsList()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IEvent> GetEventsList()
        {
            throw new System.NotImplementedException();
        }

        public IState GetState(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IState> GetStatesList()
        {
            throw new System.NotImplementedException();
        }

        public IUser GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IUser> GetUsersList()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCatalog(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveEvent(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveState(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public void ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            throw new System.NotImplementedException();
        }

        public void SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            throw new System.NotImplementedException();
        }

        public void SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCatalog(int id, string name, decimal price)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(int id, string firstName, string lastName, string address)
        {
            throw new System.NotImplementedException();
        }
    }
}
