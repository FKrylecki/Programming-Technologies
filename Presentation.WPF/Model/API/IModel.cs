using System;
using System.Collections.Generic;
using Services.API;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Presentation.WPF.Model.CodeImplementation;
using Data.API;

namespace Presentation.WPF.Model.API
{
    public interface IModel
    {
        Task <ICatalogModelData> GetCatalogsList();
        Task RemoveCatalog(int id);
        Task AddCatalog(int id, string name, decimal price);
        Task <IUserModelData> GetUsersList();
        Task RemoveUser(int id);
        Task AddUser(int id, string firstname, string lastname, string address);
        Task GetUser(int id);
        Task <IStateModelData> GetStatesList();
        Task RemoveState(int id);
        Task AddState(int id, int quantity, int catalogId);
        Task RemoveEvent(int id);
        Task <IEventModelData> GetEventsList();
        Task SellItem(int id, int stateId, int userId, int QuantityChanged);
        Task ReturnItem(int id, int stateId, int userId, int QuantityChanged);
        Task SupplyItem(int id, int stateId, int userId, int QuantityChanged);

        public static IModel CreateNewModel()
        {
            return new ModelDefault();
        }
    }
}
