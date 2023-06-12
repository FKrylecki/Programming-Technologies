using Presentation.WPF.Model.API;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogList : PropertyChange
    {
        private int id;
        private string name;
        private decimal price;
        private VMCatalogs selectedViewModel;
        private ICatalogModelData selectedCatalog;
        private IModel imodel;

        public ICommand AddCat { get; }
        public ICommand DeleteCat { get; }
        public ICommand Refresh { get; }

        private ObservableCollection<VMCatalogs> CatVM;

        public VMCatalogList()
        {
            imodel = IModel.CreateNewModel();
            CatVM = new ObservableCollection<VMCatalogs>();
            AddCat = new RelayCommand(e => { Add(); }, a => true);
            DeleteCat = new RelayCommand(e => { Delete(); }, a => true);
            Refresh = new RelayCommand(e => { GetCatalogs(); }, a => true);
        }

        public VMCatalogList(IModel? model)
        {
            imodel = model ?? IModel.CreateNewModel();
            CatVM = new ObservableCollection<VMCatalogs>();
            AddCat = new RelayCommand(e => { Add(); }, a => true);
            DeleteCat = new RelayCommand(e => { Delete(); }, a => true);
            Refresh = new RelayCommand(e => { GetCatalogs(); }, a => true);
        }

        public ObservableCollection<VMCatalogs> SelectedVM
        {
            get => CatVM;
            set
            {
                CatVM = value;
                OnPropertyChanged(nameof(SelectedVM));
            }
        }
        public ICatalogModelData SelectedCatalog
        {
            get => selectedCatalog;

            set
            {
                selectedCatalog = value;
                OnPropertyChanged(nameof(SelectedCatalog));
                selectedViewModel = new VMCatalogs(value.Id, value.Name, value.Price);
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

        private VMCatalogs CatalogToPrezentation (ICatalogModelData c)
        {
            return c == null ? null : new VMCatalogs(c.Id, c.Name, c.Price);
        }
        public void GetCatalogs()
        {
            CatVM.Clear();

            foreach (var c in imodel.GetCatalogsList())
            {
                CatVM.Add(CatalogToPrezentation(c));
            }

            OnPropertyChanged(nameof(CatVM));
        }

        private async Task Add()
        {
            await imodel.AddCatalog(selectedViewModel.Id, selectedViewModel.Name, selectedViewModel.Price);
        }
        private async Task Delete()
        {
            await imodel.RemoveCatalog(selectedViewModel.Id);
        }
    }
}
