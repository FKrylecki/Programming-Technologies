using Data.API;

namespace Logic.API
{
    public abstract class IbusinessLogic
    {
        public abstract void BuyItem(string userID, string stateID);
        public abstract void SupplyItem(string userId, string stateId);
        public abstract void ReturnItem(string userId, string stateId);
    }
}
