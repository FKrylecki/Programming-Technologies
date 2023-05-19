using Data.API;

namespace Data.CodeImplementation
{
    internal class State : IState
    {
        private ICatalog Catalog;
        public State(string stateId, int quantity, ICatalog catalog)
        {
            StateId = stateId;
            Quantity = quantity;
            Catalog = catalog;
        }

        public string StateId { 
            get;
            set;
        }
        public int Quantity { 
            get; 
            set; 
        }
        public string ItemId => Catalog.Id;
    }
}
