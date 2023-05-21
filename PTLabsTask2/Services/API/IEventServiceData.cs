using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.API
{
    public interface IEventServiceData
    {
        int Id
        {
            get;
        }
        int StateId
        {
            get;
        }
        int UserId
        {
            get;
        }
        int QuantityChanged
        {
            get;
            set;
        }
    }
}
