using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    internal interface IDataContext
    {
        IQueryable<ICatalog> Catalog { get; }
        IQueryable<IUser> User { get; }
        IQueryable<IEvent> Event { get; }
        public IQueryable<IState> State { get; }


        Task AddCatalogEntryAsync(ICatalog catalogEntry);
        Task RemoveCatalogEntryAsync(int id);

        Task AddUserAsync(IUser userEntry);
        Task RemoveUserAsync(int id);

        Task AddEventAsync(IEvent eventEntry);
        Task AddStateAsync(IState stateEntry);
        
        
        Task DeleteCustomerAsync(int Id);
        Task DeleteStateAsync(int Id);
        Task DeleteProductAsync(int Id);
        Task DeleteOrderAsync(int Id);

        public static IDataContext CreateContext(string? connectionString = null) => new DataContext(connectionString);
    }
}
