using System;
using System.Collections.Generic;
using Presentation.WPF.Model.CodeImplementation;
using Presentation.WPF.Model.API;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMEventList : PropertyChange
    {
        private int id;
        private int stateid;
        private int userid;
        private int quantitychanged;

        private VMEvents selectedViewModel;
        private IEventModelData selectedEvent;
        private IModel imodel;

        public ICommand SellCommand { get; }
        public ICommand ReturnCommand { get; }
        public ICommand SupplyCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand RefreshCommand { get; }

        private ObservableCollection<VMEvents> EventVM;

        public VMEventList()
        {
            imodel = new ModelDefault();
            EventVM = new ObservableCollection<VMEvents>();

            SellCommand = new RelayCommand(e => { Sell(); }, a => true);
            ReturnCommand = new RelayCommand(e => { Return(); }, a => true);
            SupplyCommand = new RelayCommand(e => { Supply(); }, a => true);
            DeleteCommand = new RelayCommand(e => { Delete(); }, a => true);
            RefreshCommand = new RelayCommand(e => { GetEvents(); }, a => true);
        }
        public VMEventList(IModel model)
        {
            imodel = model;
            EventVM = new ObservableCollection<VMEvents>();

            SellCommand = new RelayCommand(e => { Sell(); }, a => true);
            ReturnCommand = new RelayCommand(e => { Return(); }, a => true);
            SupplyCommand = new RelayCommand(e => { Supply(); }, a => true);
            DeleteCommand = new RelayCommand(e => { Delete(); }, a => true);
            RefreshCommand = new RelayCommand(e => { GetEvents(); }, a => true);
        }

        public ObservableCollection<VMEvents> SelectedVM
        {
            get => EventVM;

            set
            {
                EventVM = value;
                OnPropertyChanged(nameof(SelectedVM));
            }
        }
        public IEventModelData SelectedEvent
        {
            get => selectedEvent;

            set
            {
                selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
                selectedViewModel = new VMEvents(value.Id, value.StateId, value.UserId, value.QuantityChanged);
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
        public int StateId
        {
            get => stateid;
            set
            {
                stateid = value;

                OnPropertyChanged(nameof(StateId));
            }
        }
        public int UserID
        {
            get => userid;
            set
            {
                userid = value;

                OnPropertyChanged(nameof(UserID));
            }
        }
        public int QuantityChanged
        {
            get => quantitychanged;
            set
            {
                quantitychanged = value;

                OnPropertyChanged(nameof(QuantityChanged));
            }
        }

        private VMEvents EventToPrezentation(IEventModelData e)
        {
            return e == null ? null : new VMEvents(e.Id, e.StateId, e.UserId, e.QuantityChanged);
        }
        public void GetEvents()
        {
            EventVM.Clear();

            foreach (var e in imodel.GetEventsList())
            {
                EventVM.Add(EventToPrezentation(e));
            }

            OnPropertyChanged(nameof(EventVM));
        }

        private async Task Sell()
        {
            await imodel.SellItem(selectedViewModel.Id, selectedViewModel.StateId, selectedViewModel.UserID, selectedViewModel.QuantityChanged);
        }
        private async Task Return()
        {
            await imodel.ReturnItem(selectedViewModel.Id, selectedViewModel.StateId, selectedViewModel.UserID, selectedViewModel.QuantityChanged);
        }
        private async Task Supply()
        {
            await imodel.SupplyItem(selectedViewModel.Id, selectedViewModel.StateId, selectedViewModel.UserID, selectedViewModel.QuantityChanged);
        }

        private async Task Delete()
        {
            await imodel.RemoveEvent(selectedViewModel.Id);
        }
    }
}
