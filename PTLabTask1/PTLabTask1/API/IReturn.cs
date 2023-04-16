namespace Data.API
{
    public interface IReturn : IEvent
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
