using Data.API;
using Microsoft.EntityFrameworkCore;

namespace Data.CodeImplementation
{
    internal class DataContext : DbContext, IDataContext
    {
        private readonly string _connectionString;
        private const string defaultConnectionString = "Data Source = (localdb) Local;Initial Catalog = PTLabdb; Integrated Security = True";

        public DataContext(string? connectionString = null)
        {
            this._connectionString = connectionString ?? defaultConnectionString;
        }

        // ------------------------------------------------------------------------------
        internal List<ICatalog> catalogData = new();
        public DbSet<catalog> _catalogDBSet { get; set; }
        public IQueryable<ICatalog> Catalog => throw new NotImplementedException();
        public async Task AddCatalogEntryAsync(ICatalog catalogEntry)
        {
            catalog c = new() { id = catalogEntry.Id, name = catalogEntry.Name, price = catalogEntry.Price };
            await _catalogDBSet.AddAsync(c);
            await SaveChangesAsync();
        }
        public async Task RemoveCatalogEntryAsync(int id)
        {
            catalog? c = await _catalogDBSet.FindAsync(id);
            if (c != null)
            {
                _catalogDBSet.Remove(c);
                await SaveChangesAsync();
            }
        }

        // ------------------------------------------------------------------------------
        internal List<IUser> userData = new();
        public DbSet<user> _userDBSet { get; set; }
        public IQueryable<IUser> User => throw new NotImplementedException();
        public async Task AddUserAsync(IUser userEntry)
        {
            user u = new() { id = userEntry.Id, firstName = userEntry.FirstName, lastName = userEntry.LastName };
            await _userDBSet.AddAsync(u);
            await SaveChangesAsync();
        }
        public async Task RemoveUserAsync(int id)
        {
            user? u = await _userDBSet.FindAsync(id);
            if (u != null)
            {
                _userDBSet.Remove(u);
                await SaveChangesAsync();
            }
        }

        // ------------------------------------------------------------------------------
        internal List<IEvent> eventData = new();
        public DbSet<@event> _eventDBSet { get; set; }
        public IQueryable<IEvent> Event => throw new NotImplementedException();
        public async Task AddEventAsync(IEvent eventEntry)
        {
            @event e = new() { id = eventEntry.Id, stateId = eventEntry.StateId, userId = eventEntry.UserId };
            await _eventDBSet.AddAsync(e);
            await SaveChangesAsync();
        }
        public async Task RemoveEventAsync(int id)
        {
            @event? e = await _eventDBSet.FindAsync(id);
            if (e != null)
            {
                _eventDBSet.Remove(e);
                await SaveChangesAsync();
            }
        }

        // ------------------------------------------------------------------------------
        internal List<IState> stateData = new();
        public DbSet<state> _stateDBSet { get; set; }
        public IQueryable<IState> State => throw new NotImplementedException();
        public async Task AddStateAsync(IState stateEntry)
        {
            state s = new() { id = stateEntry.StateId, catalogId = stateEntry.Catalog, quantity = stateEntry.Quantity };
            await _stateDBSet.AddAsync(s);
            await SaveChangesAsync();
        }
        public async Task RemoveStateAsync(int id)
        {
            state? s = await _stateDBSet.FindAsync(id);
            if (s != null)
            {
                _stateDBSet.Remove(s);
                await SaveChangesAsync();
            }
        }





        
    }
}
