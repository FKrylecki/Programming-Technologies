using System;
using System.Collections.Generic;
using Presentation.WPF.Model.CodeImplementation;
using Presentation.WPF.Model.API;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Presentation.WPF.ViewModel
{
    public class VMEventList : PropertyChange
    {
        private int id;
        private int stateid;
        private int userid;
        private int quantitychanged;

        private IModel imodel;

        private ObservableCollection<VMEvents> EventVM;

        public VMEventList(IModel? model = default(ModelDefault))
        {
            imodel = model ?? new ModelDefault();
            EventVM = new ObservableCollection<VMEvents>();
        }
        public ObservableCollection<VMEvents> EventView
        {
            get => EventVM;

            set
            {
                EventVM = value;
                OnPropertyChanged(nameof(EventView));
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
    }
}
