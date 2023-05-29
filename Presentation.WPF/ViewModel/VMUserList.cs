using System;
using System.Collections.Generic;
using Presentation.WPF.Model.API;
using Presentation.WPF.Model.CodeImplementation;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Xml.Linq;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMUserList : PropertyChange
    {
        private int id;
        private string firstname;
        private string lastname;
        private string address;

        private IModel imodel;

        public ICommand SupplyCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand RefreshCommand { get; }

        private ObservableCollection<VMUsers> UserVM;

        public VMUserList(IModel? model = default(ModelDefault)) {
            imodel = model ?? new ModelDefault();
            UserVM = new ObservableCollection<VMUsers>();
        }
        public ObservableCollection<VMUsers> UserView
        {
            get => UserVM;

            set
            {
                UserVM = value;
                OnPropertyChanged(nameof(UserView));
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

        public string firstName
        {
            get => firstname;
            set
            {
                firstname = value;

                OnPropertyChanged(nameof(firstName));
            }
        }
        public string lastName
        {
            get => lastname;
            set
            {
                lastname = value;

                OnPropertyChanged(nameof(lastName));
            }
        }
        public string Address
        {
            get => address;
            set
            {
                address = value;

                OnPropertyChanged(nameof(Address));
            }
        }
    }
}
