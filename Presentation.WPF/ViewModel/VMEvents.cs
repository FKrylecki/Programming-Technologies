using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    public class VMEvents : PropertyChange
    {
        private int id;
        private int stateid;
        private int userid;
        private int quantitychanged;

        private readonly Presentation.WPF.Model.API.IModel _model;

        public ICommand AddSell { get; }
        public ICommand DeleteEvent { get; }

        public VMEvents(int iD, int stateidu, int useridu, int quantitychangedu)
        {
            id = iD;
            stateid = stateidu;
            userid = useridu;
            quantitychanged = quantitychangedu;

            AddSell = new RelayCommand(e => { _ = Add(); }, a => true);
            DeleteEvent = new RelayCommand(e => { _ = Delete(); }, a => true);
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

        private async Task Add()
        {
            await _model.SellItem(Id, StateId, UserID, QuantityChanged);
        }
        private async Task Delete()
        {
            await _model.RemoveEvent(Id);
        }
    }
}
