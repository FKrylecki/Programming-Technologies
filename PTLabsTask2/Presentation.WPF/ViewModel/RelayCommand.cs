using System;
using Presentation.WPF.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class RelayCommand : ICommand
    {
        private ViewModelMain viewModel;

        public RelayCommand(ViewModelMain viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("texxx");
            if (parameter.ToString() == "CList")
            {
                viewModel.SelectedViewModel = new VMCatalogList();
            }
            else if (parameter.ToString() == "UList")
            {
                viewModel.SelectedViewModel = new VMUsers();
            }
        }
    }
}
