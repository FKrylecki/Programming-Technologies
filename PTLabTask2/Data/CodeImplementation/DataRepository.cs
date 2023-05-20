using Data.API;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics;
using System.Xml.Linq;


[assembly: InternalsVisibleTo("Test")]
namespace Data.CodeImplementation

{
    internal class DataRepository : IDataRepository
    {
        private FurnitureShopDataContext dataContext;

        public DataRepository(FurnitureShopDataContext data = default)
        {
            dataContext = data ?? new FurnitureShopDataContext();
        }

        private IUser Entry(user user)
        {
            return new User(user.id, user.firstName, user.lastName, user.address);
        }

        private IEvent Entry(@event events)
        {
            return new Event(events.id, events.stateId, events.userId, events.quantityChanged);
        }

        private IState Entry(state state)
        {
            return new State(state.id, state.quantity, state.catalogId);
        }

        private ICatalog Entry(catalog item)
        {
            return new Catalog(item.id, item.name, item.price);
        }

        public void AddCatalog(int id, string name, decimal price)
        {
            var cat = new catalog
            {
                id = id,
                name = name,
                price = price
            };
            dataContext.catalogs.InsertOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        public void RemoveCatalog(int id)
        {
            var cat = (from catalog
                       in dataContext.catalogs
                       where catalog.id == id
                       select catalog).FirstOrDefault();
            dataContext.catalogs.DeleteOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        public void UpdateCatalog(int id, string name, decimal price)
        {
            var cat = (from catalog
                       in dataContext.catalogs
                       where catalog.id == id
                       select catalog).FirstOrDefault();
            if (cat != null)
            {
                cat.name = name;
                cat.price = price;
            }
            dataContext.SubmitChanges();
        }
        public ICatalog GetCatalog(int id)
        {
            var cat = (from catalog 
                       in dataContext.catalogs 
                       where catalog.id == id 
                       select catalog).FirstOrDefault();
            if (cat == null)
            {
                return null;
            }
            else
            {
                return Entry(cat);
            }
        }
        public IEnumerable<ICatalog> GetCatalogsList()
        {
            var cats = from catalog 
                       in dataContext.catalogs 
                       select Entry(catalog);
            return cats;
        }

        //---------------------------------------------------
        public void AddUser(int id, string firstName, string lastName, string address)
        {
            var User = new user
            {
                id = id,
                firstName = firstName,
                lastName = lastName,
                address = address,
            };
            dataContext.users.InsertOnSubmit(User);
            dataContext.SubmitChanges();
        }
        public void RemoveUser(int id)
        {
            var User = (from user
                       in dataContext.users
                       where user.id == id
                       select user).FirstOrDefault();
            dataContext.users.DeleteOnSubmit(User);
            dataContext.SubmitChanges();
        }
        public void UpdateUser(int id, string firstName, string lastName, string address)
        {
            var User = (from user
                       in dataContext.users
                       where user.id == id
                       select user).FirstOrDefault();
            if (User != null)
            {
                User.firstName = firstName;
                User.lastName = lastName;
                User.address = address;
            }
            dataContext.SubmitChanges();
        }
        public IUser GetUser(int id)
        {
            var User = (from user
                       in dataContext.users
                       where user.id == id
                       select user).FirstOrDefault();
            if (User == null)
            {
                return null;
            }
            else
            {
                return Entry(User);
            }
        }
        public IEnumerable<IUser> GetUsersList()
        {
            var Users = from user
                       in dataContext.users
                       select Entry(user);
            return Users;
        }

        //---------------------------------------------------
        public void AddState(int id, int quantity, int catalogId)
        {
            var State = new state
            {
                id = id,
                quantity = quantity,
                catalogId = catalogId,
            };
            dataContext.states.InsertOnSubmit(State);
            dataContext.SubmitChanges();
        }
        public void RemoveState(int id)
        {
            var State = (from state
                        in dataContext.states
                        where state.id == id
                        select state).FirstOrDefault();
            dataContext.states.DeleteOnSubmit(State);
            dataContext.SubmitChanges();
        }
        public IState GetState(int id)
        {
           var State = (from state
                        in dataContext.states
                        where state.id == id
                        select state).FirstOrDefault();
            if (State == null)
            {
                return null;
            }
            else
            {
                return Entry(State);
            }
        }
        public IEnumerable<IState> GetStatesList()
        {
            var States = from state
                        in dataContext.states
                        select Entry(state);
            return States;
        }
        public void ChangeQuantity(int stateId, int change)
        {
            GetState(stateId).Quantity += change;
        }

        //---------------------------------------------------
        public void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            var Event = new @event
            {
                id = id,
                stateId = stateId,
                userId = userId,
                quantityChanged = QuantityChanged
            };
            dataContext.events.InsertOnSubmit(Event);
            dataContext.SubmitChanges();
        }
        public void RemoveEvent(int id)
        {
            var Event = (from @event
                        in dataContext.events
                        where @event.id == id
                        select @event).FirstOrDefault();
            dataContext.events.DeleteOnSubmit(Event);
            dataContext.SubmitChanges();
        }
        public IEnumerable<IEvent> GetEventsList()
        {
            var Events = from @event
                         in dataContext.events
                         select Entry(@event);
            return Events;
        }

        //---------------------------------------------------



    }
}
