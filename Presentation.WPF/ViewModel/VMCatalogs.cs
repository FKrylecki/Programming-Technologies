using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogs : PropertyChange
    {
        private int id;
        private string name;
        private decimal price;
        private readonly Presentation.WPF.Model.API.IModel model;
        public ICommand AddCat { get; }
        public ICommand DeleteCat { get; }

        public VMCatalogs(int idu, string nameu, decimal priceu)
        {
            id = idu;
            name = nameu;
            price = priceu;

            AddCat = new RelayCommand(e => { _ = Add(); }, a => true);
            DeleteCat = new RelayCommand(e => { _ = Delete(); }, a => true);
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

        private async Task Add()
        {
            await model.AddCatalog(Id, Name, Price);
        }
        private async Task Delete()
        {
            await model.RemoveCatalog(Id);
        }
    }
}
