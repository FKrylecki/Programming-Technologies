using Data.API;

namespace Logic.CodeImplementation
{
    internal class Supply : ISupply
    {
        public string StateId { 
            get; set;
        }
        public string UserId
        {
            get; set;
        }
        public int QuantityChanged 
        { 
            get; set; 
        }

        public Supply(string stateId, string userId, int quantityChanged)
        {
            StateId = stateId;
            UserId = userId;
            QuantityChanged = quantityChanged;
        }
    }
}
