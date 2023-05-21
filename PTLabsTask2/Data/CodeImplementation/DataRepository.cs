﻿using Data.API;
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

        private IUser EntryToObj(user user)
        {
            return new User(user.id, user.firstName, user.lastName, user.address);
        }

        private IEvent EntryToObj(@event events)
        {
            return new Event(events.id, events.stateId, events.userId, events.quantityChanged);
        }

        private IState EntryToObj(state state)
        {
            return new State(state.id, state.quantity, state.catalogId);
        }

        private ICatalog EntryToObj(catalog item)
        {
            return new Catalog(item.id, item.name, item.price);
        }

        public override void AddCatalog(int id, string name, decimal price)
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
        public override void RemoveCatalog(int id)
        {
            var cat = dataContext.catalogs.SingleOrDefault(catalog => catalog.id == id);
            dataContext.catalogs.DeleteOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        public override void UpdateCatalog(int id, string name, decimal price)
        {
            var cat = dataContext.catalogs.SingleOrDefault(catalog => catalog.id == id);
            if (cat != null)
            {
                cat.name = name;
                cat.price = price;
            }
            dataContext.SubmitChanges();
        }
        public override ICatalog GetCatalog(int id)
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
                return EntryToObj(cat);
            }
        }
        public override IEnumerable<ICatalog> GetCatalogsList()
        {
            var cats = from catalog 
                       in dataContext.catalogs 
                       select EntryToObj(catalog);
            return cats;
        }

        //---------------------------------------------------
        public override void AddUser(int id, string firstName, string lastName, string address)
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
        public override void RemoveUser(int id)
        {
            var User = dataContext.users.SingleOrDefault(user => user.id == id);
            dataContext.users.DeleteOnSubmit(User);
            dataContext.SubmitChanges();
        }
        public override void UpdateUser(int id, string firstName, string lastName, string address)
        {
            var User = dataContext.users.SingleOrDefault(user => user.id == id);
            if (User != null)
            {
                User.firstName = firstName;
                User.lastName = lastName;
                User.address = address;
            }
            dataContext.SubmitChanges();
        }
        public override IUser GetUser(int id)
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
                return EntryToObj(User);
            }
        }
        public override IEnumerable<IUser> GetUsersList()
        {
            var Users = from user
                       in dataContext.users
                       select EntryToObj(user);
            return Users;
        }

        //---------------------------------------------------
        public override void AddState(int id, int quantity, int catalogId)
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
        public override void RemoveState(int id)
        {
            var State = dataContext.states.SingleOrDefault(state => state.id == id);
            dataContext.states.DeleteOnSubmit(State);
            dataContext.SubmitChanges();
        }
        public override IState GetState(int id)
        {
            var State = dataContext.states.SingleOrDefault(state => state.id == id);
            if (State == null)
            {
                return null;
            }
            else
            {
                return EntryToObj(State);
            }
        }
        public override IEnumerable<IState> GetStatesList()
        {
            var States = from state
                        in dataContext.states
                        select EntryToObj(state);
            return States;
        }
        public override void ChangeQuantity(int stateId, int change)
        {
            var State = dataContext.states.SingleOrDefault(state => state.id == stateId);
            State.quantity += change;
            dataContext.SubmitChanges();
        }

        //---------------------------------------------------
        public override void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            var Event = new @event
            {
                id = id,
                stateId = stateId,
                userId = userId,
                quantityChanged = QuantityChanged
            };
            ChangeQuantity(stateId, QuantityChanged);
            dataContext.events.InsertOnSubmit(Event);
            dataContext.SubmitChanges();
        }
        public override void RemoveEvent(int id)
        {
            var Event = dataContext.events.SingleOrDefault(@event => @event.id == id);
            dataContext.events.DeleteOnSubmit(Event);
            dataContext.SubmitChanges();
        }
        public override IEnumerable<IEvent> GetEventsList()
        {
            var Events = from @event
                         in dataContext.events
                         select EntryToObj(@event);
            return Events;
        }
        public override void Delete()
        {
            dataContext.ExecuteCommand("DELETE FROM events");
            dataContext.ExecuteCommand("DELETE FROM states");
            dataContext.ExecuteCommand("DELETE FROM users");
            dataContext.ExecuteCommand("DELETE FROM catalogs");
        }

        //---------------------------------------------------



    }
}