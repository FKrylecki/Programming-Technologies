using Presentation.WPF.Model.API;
using System.Collections.Generic;


namespace Presentation.WPF.ViewModel
{
    public class VMCatalogList : VMBase
    {
        private List<ICatalogModelData> catalogList;
        private IModel model;
        private VMCatalogs selectedEntry;
        private int selectedCatalog;

        public VMCatalogList()
        {
            model = IModel.CreateNewModel();
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
