using Data.API;

namespace Logic.CodeImplementation
{
    internal class Sell : ISell
    {
        public string StateId { get; }
        public string UserId { get; }
        public int QuantityChanged { get; set; }

        public Sell(string stateID, string userID, int quantityChanged)
        {
            StateId = stateID;
            UserId = userID;
            QuantityChanged = quantityChanged;
        }
    }
}
