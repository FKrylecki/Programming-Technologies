
namespace Data.API
{
    public interface IUser
    {
        string Id {
            get;
            set;
        }
        string FirstName { 
            get; 
            set; 
        }
        string LastName { 
            get; 
            set; 
        }
        string Address {
            get;
            set;
        }

    }
}
