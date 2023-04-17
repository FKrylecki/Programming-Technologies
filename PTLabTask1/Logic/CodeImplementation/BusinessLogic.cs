using Data.API;
using Logic.API;
using System.Collections.Generic;

namespace Logic.CodeImplementation
{
    internal class BusinessLogic : IBusinessLogic
    {
        private IDataRepository DR;
        public BusinessLogic (IDataRepository repo)
        {
            DR = repo;
        }

        public override void SellItem(string userID, string stateID, int quantity)
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
        public override void ReturnItem(string userID, string stateID, int quantity)
        {
            List<IEvent> events = DR.GetEventsList().ToList();
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].UserId == userID && events[i].StateId == stateID)
                {
                    DR.AddEvent(new Return(stateID, userID, quantity));
                    DR.ChangeQuantity(stateID, quantity);
                    return;
                }
            }
            throw new Exception("User has no record of buying this item");
        }
    }
}
