
namespace Data.API
{
    public interface IState
    {
        int StateId {
            get;
            set;
        }
        int Quantity { 
            get; 
            set; 
        }
        int Catalog {
            get;
            set;
        }
    }
}
