using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.API
{
    public interface ICatalogServiceData
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
        Task AddAsync();
        Task DeleteAsync();
    }
}
