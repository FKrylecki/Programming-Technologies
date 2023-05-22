using Data;
using Presentation.WPF.Model.API;
using System.Collections.Generic;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    internal class ViewModelMain : VMBase
    {

        private ICommand _SwitchViewCommand;
        private VMBase _selectedVm;

        public ViewModelMain(VMCatalogList defaultSelection = default)
        {
            SelectedVm = defaultSelection ?? new VMCatalogList();
            _SwitchViewCommand = new RelayCommand(view  => { SwitchView(view.ToString()); });
        }

        public VMBase SelectedVm
        {
            get => _selectedVm;
            set
            {
                _selectedVm = value;
                OnPropertyChanged(nameof(SelectedVm));
            }
        }

        public ICommand SwitchViewCommand => _SwitchViewCommand;

        public void SwitchView(string view)
        {
            switch (view)
            {
                case "ProductListView":
                    SelectedVm = new VMCatalogList();
                    break;
            }
        }


        /*public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }*/

        /*private class Updater : ICommand
        {
            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public event EventHandler? CanExecuteChanged;

            public void Execute(object? parameter)
            {

            }

        }*/
    }
}
