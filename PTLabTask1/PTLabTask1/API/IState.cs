
namespace Data.API
{
    public interface IState
    {
        string ItemId { 
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
