using Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CodeImplementation
{
    internal class UserServiceData : IUserServiceData
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
