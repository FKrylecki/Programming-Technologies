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
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        private ViewModelMain viewModel;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

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
            if (parameter != null)
            {
                if (parameter.ToString() == "CList")
                {
                    viewModel.SelectedViewModel = new VMCatalogList();
                }
                else if (parameter.ToString() == "UList")
                {
                    viewModel.SelectedViewModel = new VMUserList();
                }
                else if (parameter.ToString() == "EList")
                {
                    viewModel.SelectedViewModel = new VMEventList();
                }
                else if (parameter.ToString() == "SList")
                {
                    viewModel.SelectedViewModel = new VMStateList();
                }
            }
            else
            {
                _execute.Invoke(parameter);
            }

        }
    }
}
