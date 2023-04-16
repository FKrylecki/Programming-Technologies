using Data.API;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Test")]
namespace Data.CodeImplementation

{
    internal class DataRepository : IDataRepository
    {
        private DataContext data;

        public DataRepository(IDataGenerator? genMethod)
        {
            data = new DataContext();
            genMethod?.genrate(this);
            
        }

        public override void AddCatalog(ICatalog c) { 
            data.dictionary.Add(c.Id, c);
        }
        public override void RemoveCatalog(string id) { 
            data.dictionary.Remove(id);
        }
        public override ICatalog GetCatalog(string id) {
            return data.dictionary[id];
        }
        public override IEnumerable<ICatalog> GetCatalogsList() {
            return data.dictionary.Values;
            //returns collection contained in dictionary
        }
        //---------------------------------------------------

        public override void AddUser(IUser u) { 
            data.users.Add(u);
        }
        public override void RemoveUser(string id) {
            for (int i = 0; i < data.users.Count; i++)
            {
                if (data.users[i].Id == id)
                {
                    data.users.RemoveAt(i);
                }
            }
        }
        public override IUser GetUser(string id) { 
            for (int i = 0;i < data.users.Count; i++)
            {
                if (data.users[i].Id == id) 
                { 
                    return data.users[i]; 
                }
            }
            throw new Exception("Could not find a User.");
        }
        public override IEnumerable<IUser> GetUsersList() {
            return data.users;
        }

        //---------------------------------------------------
        public override void AddState(IState s) {
            data.states.Add(s);
        }
        public override void RemoveState(IState s) {
            data.states.Remove(s);
        }
        public override IState GetState(string id) {
            for (int i = 0; i < data.states.Count; i++)
            {
                if (data.states[i].StateId == id)
                {
                    return data.states[i];
                }
            }
            throw new Exception("Could not find a State.");
        }
        public override IEnumerable<IState> GetStatesList() {
            return data.states;
        }

        //---------------------------------------------------

        public override void AddEvent(IEvent e)
        {
            data.events.Add(e);
        }
        public override void RemoveEvent(IEvent e)
        {
            foreach (var target in data.events)
                if (e.Equals(target))
                {
                    data.events.Remove(e);
                    return;
                }
        }

        public override IEnumerable<IEvent> GetEventsList() {
            return data.events;
        }

        //---------------------------------------------------

        public override void ChangeQuantity(string stateId, int change)
        {
            GetState(stateId).Quantity += change;
        }
    }
}
