using Presentation.WPF.Model.API;
using Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class ModelDefault : IModel
    {
        private IService service;

        internal ModelDefault(IService? _service = default)
        {
            service = _service ?? IService.CreateNewService();
        }

        public ICatalogModelData GetCatalog(int id)
        {
            return (ICatalogModelData)service.GetCatalog(id);
        }

        public List<ICatalogModelData> GetCatalogsList()
        {
            return (List<ICatalogModelData>)service.GetCatalogsList();
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
        public List<IUserModelData> GetUsersList()
        {
            return (List<IUserModelData>)service.GetUsersList();
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
        public List<IStateModelData> GetStatesList()
        {
            return (List<IStateModelData>)service.GetStatesList();
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
