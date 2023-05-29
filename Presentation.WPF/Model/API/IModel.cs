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
        List<ICatalogModelData> GetCatalogsList();
        Task RemoveCatalog(int id);
        Task AddCatalog(int id, string name, decimal price);
        List <IUserModelData> GetUsersList();
        Task RemoveUser(int id);
        Task AddUser(int id, string firstname, string lastname, string address);
        List <IStateModelData> GetStatesList();
        Task RemoveState(int id);
        Task AddState(int id, int quantity, int catalogId);
        Task RemoveEvent(int id);
        List <IEventModelData> GetEventsList();
        Task SellItem(int id, int stateId, int userId, int QuantityChanged);
        Task ReturnItem(int id, int stateId, int userId, int QuantityChanged);
        Task SupplyItem(int id, int stateId, int userId, int QuantityChanged);

        public static IModel CreateNewModel()
        {
            return new ModelDefault();
        }
    }
}
