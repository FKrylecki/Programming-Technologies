using Data.API;

namespace Services.CodeImplementation
{
    internal class EventServiceData : IEvent
    {
        public int Id
        {
            get;
        }
        public int StateId
        {
            get;
        }
        public int UserId
        {
            get;
        }
        public int QuantityChanged
        {
            get;
            set;
        }
        public EventServiceData(int id, int stateId, int userId, int quantityChanged)
        {
            Id = id;
            StateId = stateId;
            UserId = userId;
            QuantityChanged = quantityChanged;
        }
    }
}
