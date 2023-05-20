using Data.API;

namespace Data.CodeImplementation
{
    internal class Sell : Event
    {
        public Sell(int id, int stateId, int userId, int quantityChanged) : base(id, stateId, userId, quantityChanged)
        {
        }
    }
}
