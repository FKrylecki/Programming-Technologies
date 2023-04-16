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

        public Supply(string stateId, string userId) {
            StateId = stateId;
            UserId = userId;
        }
    }
}
