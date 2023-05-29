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
        private VMUsers selectedViewModel;
        private IUserModelData selectedUser;
        private IModel imodel;

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand RefreshCommand { get; }

        private ObservableCollection<VMUsers> UserVM;

        public VMUserList()
        {
            imodel = new ModelDefault();
            UserVM = new ObservableCollection<VMUsers>();
            AddCommand = new RelayCommand(e => { Add(); }, a => true);
            DeleteCommand = new RelayCommand(e => { Delete(); }, a => true);
            RefreshCommand = new RelayCommand(e => { GetUsers(); }, a => true);
        }

        public VMUserList(IModel model)
        {
            imodel = model;
            UserVM = new ObservableCollection<VMUsers>();
            AddCommand = new RelayCommand(e => { Add(); }, a => true);
            DeleteCommand = new RelayCommand(e => { Delete(); }, a => true);
            RefreshCommand = new RelayCommand(e => { GetUsers(); }, a => true);
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

        private VMUsers UserToPrezentation(IUserModelData u)
        {
            return u == null ? null : new VMUsers(u.Id, u.FirstName, u.LastName, u.Address);
        }

        public void GetUsers()
        {
            UserVM.Clear();

            foreach (var u in imodel.GetUsersList())
            {
                UserVM.Add(UserToPrezentation(u));
            }

            OnPropertyChanged(nameof(UserVM));
        }

        private async Task Add()
        {
            await imodel.AddUser(selectedViewModel.Id, selectedViewModel.firstName, selectedViewModel.lastName, selectedViewModel.Address);
        }
        private async Task Delete()
        {
            await imodel.RemoveUser(selectedViewModel.Id);
        }
    }
}
