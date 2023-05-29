using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.API
{
    public interface IStateServiceData
    {
        int StateId
        {
            get;
            set;
        }
        int Quantity
        {
            get;
            set;
        }
        int Catalog
        {
            get;
            set;
        }

    }
}
