
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMStates : PropertyChange
    {
        private int id;
        private int quantity;
        private int catalogid;
        private readonly Presentation.WPF.Model.API.IModel model;
        public ICommand AddState { get; }
        public ICommand DeleteState { get; }

        public VMStates(int idu, int quantityu, int catalogidu)
        {
            id = idu;
            quantity = quantityu;
            catalogid = catalogidu;

            AddState = new RelayCommand(e => { _ = Add(); }, a => true);
            DeleteState = new RelayCommand(e => { _ = Delete(); }, a => true);
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

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;

                OnPropertyChanged(nameof(Quantity));
            }
        }
        public int CatalogId
        {
            get => catalogid;
            set
            {
                catalogid = value;

                OnPropertyChanged(nameof(CatalogId));
            }
        }

        private async Task Add()
        {
            await model.AddState(Id, Quantity, CatalogId);
        }
        private async Task Delete()
        {
            await model.RemoveState(Id);
        }
    }
}
