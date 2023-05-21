using Data.API;

namespace Data.CodeImplementation
{
    internal class State : IState
    {
         public State(int stateId, int quantity, int catalog_id)
        {
            StateId = stateId;
            Quantity = quantity;
            Catalog = catalog_id;
        }

        public int StateId { 
            get;
            set;
        }
        public int Quantity { 
            get; 
            set; 
        }
        public int Catalog {
            get;
            set;
        }
    }
}
