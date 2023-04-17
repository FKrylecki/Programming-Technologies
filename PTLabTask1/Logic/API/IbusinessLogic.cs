using Data.API;
using Logic.CodeImplementation;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test")]

namespace Logic.API
{
    public abstract class IBusinessLogic
    {
        public abstract void SellItem(string userID, string stateID, int quantity);
        public abstract void SupplyItem(string userId, string stateId, int quantity);
        public abstract void ReturnItem(string userId, string stateId, int quantity);

        public static IBusinessLogic CreateNewLogic(IDataRepository? DR)
        {
            return new BusinessLogic(DR != null ? DR : IDataRepository.CreateNewRepository(null));
        }
    }
}
