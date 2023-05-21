using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.API
{
    public interface IModel
    {
        ICatalogModelData GetCatalog(int id);
        IEnumerable<ICatalogModelData> GetCatalogsList();

        void UpdateCatalog(int id, string name, decimal price);
    }
}
