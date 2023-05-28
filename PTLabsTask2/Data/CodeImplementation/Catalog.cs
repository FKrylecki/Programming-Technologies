using Data.API;

namespace Data.CodeImplementation
{
    internal class Catalog : ICatalog
    {
        public Catalog(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id 
        { 
            get; 
            set; 
        }

        public string Name 
        { 
            get; 
            set; 
        }

        public decimal Price 
        { 
            get; 
            set; 
        }
    }
}
