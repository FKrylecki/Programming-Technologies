
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.API
{
    public interface IModel
    {
        ICatalogData_M GetCatalog(int id);
        IEnumerable<ICatalogData_M> GetCatalogsList();

        void UpdateCatalog(int id, string name, decimal price);
    }
}
