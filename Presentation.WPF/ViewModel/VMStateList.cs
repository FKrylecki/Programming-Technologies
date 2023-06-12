using Presentation.WPF.Model.API;
using System.Collections.ObjectModel;

namespace Presentation.WPF.ViewModel
{
    public class VMStateList : PropertyChange
    {
        private int id;
        private int quantity;
        private int catalogid;

        private IModel imodel;

        private ObservableCollection<VMStates> StateVM;

        public VMStateList()
        {
            imodel = imodel ?? IModel.CreateNewModel();
            StateVM = new ObservableCollection<VMStates>();
        }
        public VMStateList(IModel? model)
        {
            imodel = model ?? IModel.CreateNewModel();
            StateVM = new ObservableCollection<VMStates>();
        }
        public ObservableCollection<VMStates> StateView
        {
            get => StateVM;

            set
            {
                StateVM = value;
                OnPropertyChanged(nameof(StateView));
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
    }
}
