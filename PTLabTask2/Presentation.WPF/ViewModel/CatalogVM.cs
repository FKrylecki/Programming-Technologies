using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.WPF.Model;
using Services;


namespace Presentation.WPF.ViewModel
{
    internal class CatalogVM
    {
        private IList<Catalog> catalogList;

        public CatalogVM(IService _service = default)
        {
            catalogList = _service.GetCatalogsList;
        }
    }
}
