
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class ViewModelMain : PropertyChange
    {
        public ICommand? Command1 { get; set; }
        public PropertyChange PC;

        private PropertyChange _selectedViewModel;
        public PropertyChange SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public ViewModelMain()
        {
            UpdateViewCommand = new RelayCommand(this);
        }
    }
}
