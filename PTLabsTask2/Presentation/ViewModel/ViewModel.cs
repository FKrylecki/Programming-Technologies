using Presentation.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.ViewModel
{
    internal class ViewModel
    {
        private readonly IModel model;
        private IEnumerable<ICatalogModelData> catalogList;
        private ICommand mUpdater;

        public ViewModel()
        {
            catalogList = model.GetCatalogsList();
           
        }

        public IEnumerable<ICatalogModelData> Catalogs
        {
            get { return catalogList; }
            set { catalogList = value; }
        }

        
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

        }
    }
}
