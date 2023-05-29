using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Data.API;
using Data.CodeImplementation;

namespace ServiceTests
{
    internal class MockDataLayer : IDataRepository
    {

        public List<IUser> Users = new List<IUser>();
        public List<IEvent> Events = new List<IEvent>();
        public List<ICatalog> Catalogs = new List<ICatalog>();
        public List<IState> States = new List<IState>();



        public override void AddCatalog(int id, string name, decimal price)
        {
            Catalogs.Add(new MockCatalog(id, name, price));
        }

        public override void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            Events.Add(new MockEvent(id, stateId, userId, QuantityChanged));
        }

        public override void AddState(int id, int quantity, int catalogId)
        {
            States.Add(new MockState(id, quantity, catalogId));
        }

        public override void AddUser(int id, string firstName, string lastName, string address)
        {
            Users.Add(new MockUser(id, firstName, lastName, address));
        }

        public override void ChangeQuantity(int stateId, int change)
        {
            States[stateId - 1].Quantity = change;
        }

        public override void ClearAll()
        {
            States.Clear();
            Users.Clear();
            Catalogs.Clear();
            Events.Clear();

        }

        public override ICatalog GetCatalog(int id)
        {
            return Catalogs[id - 1];
        }

        public override IEnumerable<ICatalog> GetCatalogsList()
        {
            return Catalogs;
        }

        public override IEnumerable<IEvent> GetEventsList()
        {
            return Events;
        }

        public override IState GetState(int id)
        {
            return States[id - 1];
        }

        public override IEnumerable<IState> GetStatesList()
        {
            return States;
        }

        public override IUser GetUser(int id)
        {
            return Users[id - 1];
        }

        public override IEnumerable<IUser> GetUsersList()
        {
            return Users;
        }

        public override void RemoveCatalog(int id)
        {
            Catalogs.RemoveAt(id - 1);
        }

        public override void RemoveEvent(int id)
        {
            Events.RemoveAt(id - 1);
        }

        public override void RemoveState(int id)
        {
            States.RemoveAt(id - 1);
        }

        public override void RemoveUser(int id)
        {
            Users.RemoveAt(id - 1);
        }
    }
}
