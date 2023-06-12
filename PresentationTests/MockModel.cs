using Presentation.WPF.Model.API;
using Services.API;

namespace PresentationTests
{
    public class MockModel : IModel
    {
        private IService service;

        internal MockModel(IService? _service = null)
        {
            service = _service ?? IService.CreateNewService();
        }
        public class CatalogMockModelData
        {
            public CatalogMockModelData(int id, string name, decimal price)
            {
                Id = id;
                Name = name;
                Price = price;
            }

            public int Id
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public decimal Price
            {
                get;
                set;
            }
        }

        internal class UserMockModelData
        {
            public int Id
            {
                get;
                set;
            }
            public string FirstName
            {
                get;
                set;
            }
            public string LastName
            {
                get;
                set;
            }
            public string Address
            {
                get;
                set;
            }
            public UserMockModelData(int id, string firstname, string lastname, string address)
            {
                Id = id;
                FirstName = firstname;
                LastName = lastname;
                Address = address;
            }
        }
        internal class StateMockModelData
        {
            public int StateId
            {
                get;
                set;
            }
            public int Quantity
            {
                get;
                set;
            }
            public int Catalog
            {
                get;
                set;
            }
            public StateMockModelData(int stateid, int quantity, int catalog)
            {
                StateId = stateid;
                Quantity = quantity;
                Catalog = catalog;
            }
        }
        internal class EventMockModelData
        {
            public int Id
            {
                get;
            }
            public int StateId
            {
                get;
            }
            public int UserId
            {
                get;
            }
            public int QuantityChanged
            {
                get;
                set;
            }
            public EventMockModelData(int id, int stateid, int userid, int quantitychanged)
            {
                Id = id;
                StateId = stateid;
                UserId = userid;
                QuantityChanged = quantitychanged;
            }
        }

        public List<ICatalogModelData> GetCatalogsList()
        {
            return service.GetCatalogsList().ConvertAll(x => (ICatalogModelData)x);
        }

        public Task RemoveCatalog(int id)
        {
            return service.RemoveCatalog(id);
        }

        public Task AddCatalog(int id, string name, decimal price)
        {
            return service.AddCatalog(id, name, price);
        }

        public List<IUserModelData> GetUsersList()
        {
            return service.GetUsersList().ConvertAll(x => (IUserModelData)x);
        }

        public Task RemoveUser(int id)
        {
            return service.RemoveUser(id);
        }

        public Task AddUser(int id, string firstname, string lastname, string address)
        {
            return service.AddUser(id, firstname, lastname, address);
        }

        public List<IStateModelData> GetStatesList()
        {
            return service.GetStatesList().ConvertAll(x => (IStateModelData)x);
        }

        public Task RemoveState(int id)
        {
            return service.RemoveState(id);
        }

        public Task AddState(int id, int quantity, int catalogId)
        {
            return service.AddState(id, quantity, catalogId);
        }

        public Task RemoveEvent(int id)
        {
            return service.RemoveEvent(id);
        }

        public List<IEventModelData> GetEventsList()
        {
            return service.GetEventsList().ConvertAll(x => (IEventModelData)x);
        }

        public Task SellItem(int id, int stateId, int userId, int QuantityChanged)
        {
            return service.SellItem(id, stateId, userId, -QuantityChanged);
        }

        public Task ReturnItem(int id, int stateId, int userId, int QuantityChanged)
        {
            return service.ReturnItem(id, stateId, userId, QuantityChanged);
        }

        public Task SupplyItem(int id, int stateId, int userId, int QuantityChanged)
        {
            return service.SupplyItem(id, stateId, userId, QuantityChanged);
        }
    }
}
