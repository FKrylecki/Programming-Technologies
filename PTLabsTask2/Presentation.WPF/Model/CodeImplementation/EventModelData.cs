using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class EventModelData : IEventModelData
    {
        public int Id
        {
            get;
        }
        public int StateId
        {
            get;
        }
        public int UserId
        {
            get;
        }
        public int QuantityChanged
        {
            get;
            set;
        }
        public EventModelData(int id, int stateid, int userid, int quantitychanged) 
        {
            Id = id;
            StateId = stateid;
            UserId = userid;
            QuantityChanged = quantitychanged;
        }
    }
}
