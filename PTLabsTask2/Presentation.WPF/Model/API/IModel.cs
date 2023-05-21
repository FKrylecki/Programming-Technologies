using System;
using System.Collections.Generic;
using Services.API;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Presentation.WPF.Model.API
{
    public interface IModel
    {
        ICatalogModelData GetCatalog(int id);
        IEnumerable<ICatalogModelData> GetCatalogsList();
        void UpdateCatalog(int id, string name, decimal price);
        void RemoveCatalog(int id);
        void AddCatalog(int id, string name, decimal price);
        IUserModelData GetUser(int id);
        IEnumerable<IUserModelData> GetUsersList();
        void UpdateUser(int id, string firstname, string lastname, string address);
        void RemoveUser(int id);
        void AddUser(int id, string firstname, string lastname, string address);
        IStateModelData GetState(int id);
        IEnumerable<IStateModelData> GetStatesList();
        void RemoveState(int id);
        void AddState(int id, int quantity, int catalogId);
    }
}
