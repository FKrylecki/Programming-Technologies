using Data.API;
using Logic.API;
using System.Collections.Generic;

namespace Logic.CodeImplementation
{
    internal class BusinessLogic : IbusinessLogic
    {
        private IDataRepository DR;
        public BusinessLogic (IDataRepository repo)
        {
            DR = repo;
        }

        public override void BuyItem(string userID, string stateID, int quantity)
        {
            if (DR.GetState(stateID).Quantity <= quantity) { 
                throw new Exception("Not enough items in stock."); 
            }
            DR.AddEvent(new Sell(stateID, userID, -quantity));
            DR.ChangeQuantity(stateID, -quantity);
        }
        public override void SupplyItem(string userID, string stateID, int quantity)
        {
            DR.AddEvent(new Supply(stateID, userID, quantity));
            DR.ChangeQuantity(stateID, quantity);
        }
        public override void ReturnItem(string userID, string stateID)
        {
            throw new NotImplementedException();
        }
    }
}
