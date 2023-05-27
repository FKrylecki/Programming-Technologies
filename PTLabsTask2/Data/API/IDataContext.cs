using Data.CodeImplementation;

namespace Data.API
{
    internal interface IDataContext
    {
        public IQueryable<ICatalog> Catalog { get; }
        Task AddCatalogEntryAsync(ICatalog catalogEntry);
        Task RemoveCatalogEntryAsync(int id);


        public IQueryable<IUser> User { get; }
        Task AddUserAsync(IUser userEntry);
        Task RemoveUserAsync(int id);


        public IQueryable<IEvent> Event { get; }
        Task AddEventAsync(IEvent eventEntry);
        Task RemoveEventAsync(int id);


        public IQueryable<IState> State { get; }
        Task AddStateAsync(IState stateEntry);
        Task RemoveStateAsync(int id);

        public static IDataContext CreateContext(string? connectionString = null) => new DataContext(connectionString);


    }
}
