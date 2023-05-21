using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.API
{
    public interface IEventModelData
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
