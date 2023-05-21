using Data.API;

namespace Data.CodeImplementation
{
    internal class Supply : Event
    {
        public Supply(int id, int stateId, int userId, int quantityChanged) : base(id, stateId, userId, quantityChanged)
        {
        }
    }
}

