using Presentation.WPF.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.CodeImplementation
{
    internal class Model : IModel
    {
        private IService service;

        internal Model(IService? _service = default)
        {
            service = _service ?? IService.CreateNewService();
        }

        public ICatalogModelData GetCatalog(int id)
        {
            return (ICatalogModelData)service.GetCatalog(id);
        }

        public IEnumerable<ICatalogModelData> GetCatalogsList()
        {
            return (IEnumerable<ICatalogModelData>)service.GetCatalogsList();
        }

        public void UpdateCatalog(int id, string name, decimal price)
        {
            service.UpdateCatalog(id, name, price);
        }
    }
}
