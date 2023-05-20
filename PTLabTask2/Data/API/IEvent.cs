
namespace Data.API
{
    public interface IEvent
    {
        int Id { 
            get; 
        }
        int StateId { 
            get; 
        }
        int UserId { 
            get; 
        }
        int QuantityChanged { 
            get;
            set;
        }
    }
}
