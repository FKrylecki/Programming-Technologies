using Data.API;

namespace Data.CodeImplementation
{
    internal class Return : Event
    {
        public Return(int id, int stateId, int userId, int quantityChanged) : base(id, stateId, userId, quantityChanged)
        {
        }
    }
}
