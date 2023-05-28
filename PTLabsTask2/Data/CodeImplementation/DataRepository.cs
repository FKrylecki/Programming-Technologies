using Data.API;
using Data.CodeImplementation;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Test")]
namespace Data.CodeImplementation

{
    internal class DataRepository : IDataRepository
    {
        private FurnitureShopDataContext dataContext;

        public DataRepository(string customConnectionString)
        {
            dataContext = new FurnitureShopDataContext(customConnectionString);
        }

        public DataRepository()
        {
        }

        //----------------------------------------------------------------------
        private ICatalog EntryToObj(catalog catalog)
        {
            if (catalog != null)
            {
                return new Catalog(catalog.id, catalog.name, catalog.price);
            }
            return null;
        }
        public override void AddCatalog(int id, string name, decimal price)
        {
            catalog c = new catalog
            {
                id = id,
                name = name,
                price = price
            };
            dataContext.catalogs.InsertOnSubmit(c);
            dataContext.SubmitChanges();
        }
        public override void RemoveCatalog(int id)
        {
            catalog cat = dataContext.catalogs.Single(catalog => catalog.id == id);
            dataContext.catalogs.DeleteOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        public override ICatalog GetCatalog(int id)
        {
            catalog c = new catalog();
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
                c.id = cat.id;
                c.price = cat.price;
                c.name = cat.name;
                return EntryToObj(c);
            }
        }
        public override IEnumerable<ICatalog> GetCatalogsList()
        {
            var cats = (from catalog 
                       in dataContext.catalogs 
                       select EntryToObj(catalog)
                       );
            return cats;
        }

        //----------------------------------------------------------------------
        private IUser EntryToObj(user user)
        {
            if (user != null)
            {
                return new User(user.id, user.firstName, user.lastName, user.address);
            }
            return null;
        }
        public override void AddUser(int id, string firstName, string lastName, string address)
        {
            user u = new user
            {
                id = id,
                firstName = firstName,
                lastName = lastName,
                address = address,
            };
            dataContext.users.InsertOnSubmit(u);
            dataContext.SubmitChanges();
        }
        public override void RemoveUser(int id)
        {
            user usr = dataContext.users.Single(user => user.id == id);
            dataContext.users.DeleteOnSubmit(usr);
            dataContext.SubmitChanges();
        }
        public override IUser GetUser(int id)
        {
            var usr = (from user
                       in dataContext.users
                       where user.id == id
                       select user).FirstOrDefault();
            if (usr == null)
            {
                return null;
            }
            else
            {
                return EntryToObj(usr);
            }
        }
        public override IEnumerable<IUser> GetUsersList()
        {
            var usr = (from user
                       in dataContext.users
                       select EntryToObj(user)
                       );
            return usr;
        }

        //----------------------------------------------------------------------
        private IState EntryToObj(state state)
        {
            if (state != null)
            {
                return new State(state.id, state.quantity, state.catalogId);
            }
            return null;
        }
        public override void AddState(int id, int quantity, int catalogId)
        {
            state stt = new state
            {
                id = id,
                quantity = quantity,
                catalogId = catalogId,
            };
            dataContext.states.InsertOnSubmit(stt);
            dataContext.SubmitChanges();
        }
        public override void RemoveState(int id)
        {
            state stt = dataContext.states.Single(state => state.id == id);
            dataContext.states.DeleteOnSubmit(stt);
            dataContext.SubmitChanges();
        }
        public override IState GetState(int id)
        {
            state stt = dataContext.states.SingleOrDefault(state => state.id == id);
            if (stt == null)
            {
                return null;
            }
            else
            {
                return EntryToObj(stt);
            }
        }
        public override IEnumerable<IState> GetStatesList()
        {
            var stt = from state
                        in dataContext.states
                        select EntryToObj(state);
            return stt;
        }
        public override void ChangeQuantity(int stateId, int change)
        {
            state stt = dataContext.states.Single(state => state.id == stateId);
            stt.quantity += change;
            dataContext.SubmitChanges();
        }

        //----------------------------------------------------------------------
        private IEvent EntryToObj(@event @event)
        {
            if (@event != null)
            {
                return new Event(@event.id, @event.stateId, @event.userId, @event.quantityChanged);
            }
            return null;
        }
        public override void AddEvent(int id, int stateId, int userId, int QuantityChanged)
        {
            @event evt = new @event
            {
                id = id,
                stateId = stateId,
                userId = userId,
                quantityChanged = QuantityChanged
            };
            ChangeQuantity(stateId, QuantityChanged);
            dataContext.events.InsertOnSubmit(evt);
            dataContext.SubmitChanges();
        }
        public override void RemoveEvent(int id)
        {
            @event evt = dataContext.events.SingleOrDefault(@event => @event.id == id);
            dataContext.events.DeleteOnSubmit(evt);
            dataContext.SubmitChanges();
        }
        public override IEnumerable<IEvent> GetEventsList()
        {
            var Events = from @event
                         in dataContext.events
                         select EntryToObj(@event);
            return Events;
        }

        //----------------------------------------------------------------------

        public override void ClearAll()
        {
            dataContext.ExecuteCommand("DELETE FROM events");
            dataContext.ExecuteCommand("DELETE FROM states");
            dataContext.ExecuteCommand("DELETE FROM users");
            dataContext.ExecuteCommand("DELETE FROM catalogs");
        }

    }
}
