using Data.API;
namespace Data.CodeImplementation
{
    internal class Catalog : ICatalog
    {
        public Catalog(string id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Id 
        { 
            get; 
            set; 
        }

        public string Name 
        { 
            get; 
            set; 
        }

        public float Price 
        { 
            get; 
            set; 
        }
    }
}
