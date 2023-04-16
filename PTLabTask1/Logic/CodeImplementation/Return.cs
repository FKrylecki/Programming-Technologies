namespace Logic.CodeImplementation
{
    internal class Return
    {
        public string StateId { get; }
        public string UserId { get; }
        public int QuantityChanged { get; set; }

        public Return(string stateID, string userID, int quantityChanged)
        {
            StateId = stateID;
            UserId = userID;
            QuantityChanged = quantityChanged;
        }
    }
}
