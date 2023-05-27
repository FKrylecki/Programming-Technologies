using Presentation.WPF.Model.API;
using Presentation.WPF.Model.CodeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.ViewModel
{
    public class VMCatalogList : PropertyChange
    {

        private IService serviceData;
        public VMCatalogList(IService _service = default)
        {
            //serviceData = _service ?? IService.CreateNewService(); // THROWS A Could not load file or assembly 'System.Data.Linq, Version=4.0.0.0, Culture=neutral EXCEPTION IN DATA LAYER
        }

        public List<ICatalogModelData> Items
        {
            get {
                // Mock data (works)
                return new List<ICatalogModelData>()
                {
                    new CatalogModelData(1, "Sample 1", 100),
                    new CatalogModelData(2, "Sample 1", 200),
                    new CatalogModelData(3, "Sample 1", 200)
                };
            }
        }

    }


}
