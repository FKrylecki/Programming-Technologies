namespace Data.API
{
    public interface ISell : IEvent
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
