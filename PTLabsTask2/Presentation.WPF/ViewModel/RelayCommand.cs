using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;
        private Action<object> value;

        public RelayCommand(Action<object> value) : this(value, null)
        {}

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
