using Data.API;

namespace Logic.API
{
    public abstract class IbusinessLogic
    {
        public abstract void SellItem(string userID, string stateID, int quantity);
        public abstract void SupplyItem(string userId, string stateId, int quantity);
        public abstract void ReturnItem(string userId, string stateId, int quantity);
    }
}
