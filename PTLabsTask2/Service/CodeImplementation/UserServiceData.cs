using Data.API;

namespace Services.CodeImplementation
{
    internal class UserServiceData : IUser
    {
        public UserServiceData(int id, string fName, string lName, string address) 
        { 
            Id = id;
            FirstName = fName;
            LastName = lName;
            Address = address;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string Address { get; set; }
    }
}
