﻿using Data.API;

namespace Services.CodeImplementation
{
    internal class CatalogServiceData : ICatalog
    {
        public CatalogServiceData(int id, string name, decimal price)
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
