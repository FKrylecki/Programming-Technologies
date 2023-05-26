using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogList : PropertyChange
    {
        public List<ICatalogModelData> catalogList;
        public IModel model;
        public VMCatalogs selectedEntry;
        public int selectedCatalog;

        public VMCatalogList()
        {

        }
        public VMCatalogList(IModel? _model = default)
        {
            model = _model ?? IModel.CreateNewModel();
            catalogList = model.GetCatalogsList();
        }
        public int SelectedCatalog
        {
            get => selectedCatalog;
            set
            {
                selectedCatalog = value;
                OnPropertyChanged(nameof(SelectedCatalog));
                try
                {
                    selectedEntry = new VMCatalogs(catalogList[value]);
                    OnPropertyChanged(nameof(SelectedEntry));

                } catch {}
            }

        }
        public VMCatalogs SelectedEntry
        {
            get => selectedEntry;
            set
            {
                selectedEntry = value;
                OnPropertyChanged(nameof(SelectedEntry));
            }
        }




    }


}
