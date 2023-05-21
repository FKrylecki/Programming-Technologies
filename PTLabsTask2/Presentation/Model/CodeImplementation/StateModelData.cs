using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.CodeImplementation
{
    internal class StateModelData
    {
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
        public StateModelData(int stateId, int quantity, int catalogId) 
        { 
            StateId = stateId;
            Quantity = quantity;
            Catalog = catalogId;
        }
    }
}
