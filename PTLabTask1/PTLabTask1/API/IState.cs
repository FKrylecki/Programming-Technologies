
namespace Data.API
{
    public interface IState
    {
        int ItemId { 
            get; 
        }
        string StateId {
            get;
            set;
        }
        int Quantity { 
            get; 
            set; 
        }
    }
}
