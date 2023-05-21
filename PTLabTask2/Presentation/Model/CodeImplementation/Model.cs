using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
using Presentation.Model.API;

namespace Presentation.Model
{
    internal class Model : IModel
    {
        private IService service;

        internal Model(IService _service = default) 
        { 
            service = _service ?? IService.CreateNewService();
        }

        ICatalog IModel.GetCatalog(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ICatalog> IModel.GetCatalogsList()
        {
            throw new NotImplementedException();
        }
    }
}
