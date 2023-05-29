using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;


namespace ServiceTests
{
    internal class MockUser : IUser
    {
        public MockUser(int id, string firstName, string lastName, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string Address { get; set; }
    }
}
