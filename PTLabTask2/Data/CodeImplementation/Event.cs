using Data.API;

namespace Data.CodeImplementation
{
    internal class Event : IEvent
    {
        public int Id { get; }
        public int StateId { get; }
        public int UserId { get; }
        public int QuantityChanged { get; set; }

        public Event(int id, int stateId, int userId, int quantityChanged)
        {
            Id = id;
            StateId = stateId;
            UserId = userId;
            QuantityChanged = quantityChanged;
        }
    }
}
