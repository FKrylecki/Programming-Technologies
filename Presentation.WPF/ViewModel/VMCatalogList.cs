using Presentation.WPF.Model.API;
using Presentation.WPF.Model.CodeImplementation;
using Services.API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogList : PropertyChange
    {
        private int id;
        private string name;
        private decimal price;

        private IModel imodel;

        private ObservableCollection<VMCatalogs> CatVM;

        public VMCatalogList(IModel? model = default(ModelDefault))
        {
            imodel = model ?? new ModelDefault();
            CatVM = new ObservableCollection<VMCatalogs>();
        }
        public ObservableCollection<VMCatalogs> CatView
        {
            get => CatVM;

            set
            {
                CatVM = value;
                OnPropertyChanged(nameof(CatView));
            }
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
