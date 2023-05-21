using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model
{
    internal class Catalog
    {
        private int id;
        private string name;
        private float price;


        public int id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("id");
            }
        }
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("name");
            }
        }
        public string price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
}
