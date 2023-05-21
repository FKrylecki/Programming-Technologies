using Presentation.WPF.Model.API;
using Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class Model : IModel
    {
        private IService service;

        internal Model(IService? _service = default)
        {
            service = _service ?? IService.CreateNewService();
        }

        public ICatalogModelData GetCatalog(int id)
        {
            return (ICatalogModelData)service.GetCatalog(id);
        }

        public IEnumerable<ICatalogModelData> GetCatalogsList()
        {
            return (IEnumerable<ICatalogModelData>)service.GetCatalogsList();
        }

        public void UpdateCatalog(int id, string name, decimal price)
        {
            service.UpdateCatalog(id, name, price);
        }
        public void RemoveCatalog(int id)
        {
            service.RemoveCatalog(id);
        }
        public void AddCatalog(int id, string name, decimal price)
        {
            service.AddCatalog(id, name, price);
        }
        public IUserModelData GetUser(int id)
        {
            return (IUserModelData)service.GetUser(id);
        }
        public IEnumerable<IUserModelData> GetUsersList()
        {
            return (IEnumerable<IUserModelData>)service.GetUsersList();
        }
        public void UpdateUser(int id, string firstname, string lastname, string address)
        {
            service.UpdateUser(id, firstname, lastname, address);
        }
        public void RemoveUser(int id)
        {
            service.RemoveUser(id);
        }
        public void AddUser(int id, string firstname, string lastname, string address)
        {
            service.AddUser(id, firstname, lastname, address);
        }
        public IStateModelData GetState(int id)
        {
            return (IStateModelData)service.GetState(id);
        }
        public IEnumerable<IStateModelData> GetStatesList()
        {
            return (IEnumerable<IStateModelData>)service.GetStatesList();
        }
        public void RemoveState(int id)
        {
            service.RemoveState(id);
        }
        public void AddState(int id, int quantity, int catalogId)
        {
            service.AddState(id, quantity, catalogId);
        }
    }
}
