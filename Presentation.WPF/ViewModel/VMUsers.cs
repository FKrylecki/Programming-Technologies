using Presentation.WPF.Model.API;
using Presentation.WPF.Model.CodeImplementation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMUsers : PropertyChange
    {
        private int id;
        private string firstname;
        private string lastname;
        private string address;

        private readonly Presentation.WPF.Model.API.IModel _model;

        public ICommand AddUser { get; }
        public ICommand DeleteUser { get; }
        public ICommand GetUser { get; }

        public VMUsers(int iD, string firstName, string lastName, string addresS)
        {
            id = iD;
            firstname = firstName;
            lastname = lastName;
            address = addresS;

            AddUser = new RelayCommand(e => { _ = Add(); }, a => true);
            DeleteUser = new RelayCommand(e => { _ = Delete(); }, a => true);
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

        private async Task Add()
        {
            await _model.AddUser(Id, firstName, lastName, Address);
        }
        private async Task Delete()
        {
            await _model.RemoveUser(Id);
        }
    }
}
