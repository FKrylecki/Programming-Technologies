using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace ServiceTests
{
    internal class MockCatalog : ICatalog
    {
        public MockCatalog(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }
    }
}
