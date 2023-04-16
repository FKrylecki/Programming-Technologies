using Data.API;

namespace Logic.CodeImplementation
{
    internal class Sell : ISell
    {
        public string StateId { get; }
        public string UserId { get; }

        public Sell(string stateID, string userID)
        {
            StateId = stateID;
            UserId = userID;
        }
    }
}
