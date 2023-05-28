using Data.API;

namespace Services.CodeImplementation
{
    internal class StateServiceData : IState
    {
        public StateServiceData(int stateId, int quantity, int catalog_id)
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
