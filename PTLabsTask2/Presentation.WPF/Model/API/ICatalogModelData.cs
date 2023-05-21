using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.WPF.Model.API
{
    public interface ICatalogModelData
    {
        int Id
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        decimal Price
        {
            get;
            set;
        }
    }
}
