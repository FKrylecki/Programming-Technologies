namespace Data.API
{
    public interface ISupply : IEvent
    {
        string StateId
        {
            get;
        }
        string UserId
        {
            get;
        }
        int QuantityChanged
        {
            get;
            set;
        }
    }
}
