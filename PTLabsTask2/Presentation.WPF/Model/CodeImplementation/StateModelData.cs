using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class StateModelData : IStateModelData
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
        public StateModelData(int stateid, int quantity, int catalog) 
        {
            StateId = stateid;
            Quantity = quantity;
            Catalog = catalog;
        }
    }
}
