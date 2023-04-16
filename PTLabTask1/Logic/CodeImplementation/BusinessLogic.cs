using Data.API;
using Logic.API;
using System.Collections.Generic;

namespace Logic.CodeImplementation
{
    internal class BusinessLogic : IbusinessLogic
    {
        private IDataRepository DR;

        public override void BuyItem(string userID, string stateID)
        {
            DR.AddEvent(new Sell(stateID, userID));
            throw new NotImplementedException();
        }
        public override void SupplyItem(string userID, string stateID)
        {
            throw new NotImplementedException();
        }
        public override void ReturnItem(string userID, string stateID)
        {
            throw new NotImplementedException();
        }
    }
}
