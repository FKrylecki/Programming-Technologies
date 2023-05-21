using Data.API; //TO BE CHANGED?
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Presentation.Model;
using Presentation.Model.API;

namespace Presentation.ViewModel
{
    internal class Class1
    {
        public ObservableCollection<ICatalog> CatalogList;
        public ICatalog SelectedEntry;


        private void Catalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedEntry = CatalogList[0];
        }
    }


}
