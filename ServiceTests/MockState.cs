using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace ServiceTests
{
    internal class MockState : IState
    {
        public MockState(int stateId, int quantity, int catalog_id)
        {
            StateId = stateId;
            Quantity = quantity;
            Catalog = catalog_id;
        }

        public int StateId
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
        public int Catalog
        {
            get;
            set;
        }
    }
}
