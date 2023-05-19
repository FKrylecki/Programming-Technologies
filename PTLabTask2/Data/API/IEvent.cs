
namespace Data.API
{
    public interface IEvent
    {
        string StateId { 
            get; 
        }
        string UserId { 
            get; 
        }
        int QuantityChanged { 
            get;
            set;
        }
    }
}
