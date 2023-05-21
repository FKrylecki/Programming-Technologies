using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.CodeImplementation
{
    internal class EventModelData
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
        public EventModelData(int id, int stateId, int userId, int quantityChanged) 
        {
            Id = id;
            StateId = stateId;
            UserId = userId;
            QuantityChanged = quantityChanged;
        }
    }
}
