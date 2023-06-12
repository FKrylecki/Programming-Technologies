
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogs : PropertyChange
    {
        private int id;
        private string name;
        private decimal price;
        public ICommand AddCat { get; }
        public ICommand DeleteCat { get; }

        public VMCatalogs(int idu, string nameu, decimal priceu)
        {
            id = idu;
            name = nameu;
            price = priceu;
        }

        public VMCatalogs()
        {
            id = 0;
            name = "Sample";
            price = 100;
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
