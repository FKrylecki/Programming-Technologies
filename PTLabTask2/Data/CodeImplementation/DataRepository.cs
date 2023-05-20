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

        private void AddCatalog(ICatalog c)
        {
            var cat = new catalog
            {
                id = c.Id,
                name = c.Name,
                price = c.Price
            };
            dataContext.catalogs.InsertOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        private void RemoveCatalog(int id)
        {
            var cat = (from catalog
                       in dataContext.catalogs
                       where catalog.id == id
                       select catalog).FirstOrDefault();
            dataContext.catalogs.DeleteOnSubmit(cat);
            dataContext.SubmitChanges();
        }
        private void UpdateCatalog(int id, string name, decimal price)
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
        private ICatalog GetCatalog(int id)
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
        private IEnumerable<ICatalog> GetCatalogsList()
        {
            var cats = from catalog 
                       in dataContext.catalogs 
                       select Entry(catalog);
            return cats;
        }

        //---------------------------------------------------
        private void AddUser(IUser u)
        {
            var User = new user
            {
                id = u.Id,
                firstName = u.FirstName,
                lastName = u.LastName,
                address = u.Address,
            };
            dataContext.users.InsertOnSubmit(User);
            dataContext.SubmitChanges();
        }
        private void RemoveUser(int id)
        {
            var User = (from user
                       in dataContext.users
                       where user.id == id
                       select user).FirstOrDefault();
            dataContext.users.DeleteOnSubmit(User);
            dataContext.SubmitChanges();
        }
        private void UpdateUser(int id, string firstName, string lastName, string address)
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
        private IUser GetUser(int id)
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
        private IEnumerable<IUser> GetUsersList()
        {
            var Users = from user
                       in dataContext.users
                       select Entry(user);
            return Users;
        }

        //---------------------------------------------------
        private void AddState(IState s)
        {

        }
        private void RemoveState(IState s)
        {

        }
        private IState GetState(string id)
        {

        }
        private IEnumerable<IState> GetStatesList()
        {

        }
        private void ChangeQuantity(string stateId, int change)
        {

        }

        //---------------------------------------------------
        private void AddEvent(IEvent e)
        {

        }
        private void RemoveEvent(IEvent e)
        {

        }
        private IEnumerable<IEvent> GetEventsList()
        {

        }

        //---------------------------------------------------



    }
}
