using System;
using System.Collections.Generic;
using Services.API;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Presentation.WPF.Model.CodeImplementation;

namespace Presentation.WPF.Model.API
{
    public interface IModel
    {
        ICatalogModelData GetCatalog(int id);
        List<ICatalogModelData> GetCatalogsList();
        void UpdateCatalog(int id, string name, decimal price);
        void RemoveCatalog(int id);
        void AddCatalog(int id, string name, decimal price);
        IUserModelData GetUser(int id);
        List<IUserModelData> GetUsersList();
        void UpdateUser(int id, string firstname, string lastname, string address);
        void RemoveUser(int id);
        void AddUser(int id, string firstname, string lastname, string address);
        IStateModelData GetState(int id);
        List<IStateModelData> GetStatesList();
        void RemoveState(int id);
        void AddState(int id, int quantity, int catalogId);

        public static IModel CreateNewModel()
        {
            return new ModelDefault();
        }
    }
}
