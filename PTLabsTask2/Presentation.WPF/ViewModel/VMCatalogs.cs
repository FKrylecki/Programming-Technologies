using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogs : PropertyChange
    {
        private readonly IModel? Cmodel;
        private int id;
        private string name;
        private decimal price;

        public VMCatalogs(ICatalogModelData data)
        {
            id = data.Id;
            name = data.Name;
            price = data.Price;
        }

        public int Id
        {
            get => id;

            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;

                OnPropertyChanged(nameof(Name));
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                price = value;

                OnPropertyChanged(nameof(Price));
            }
        }
    }
}
