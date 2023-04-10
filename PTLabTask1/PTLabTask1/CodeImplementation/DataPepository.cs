using Data.API;

namespace Data.CodeImplementation
{
    internal class DataPepository : IDataRepository
    {
        private DataContext data;

        public override void AddCatalog(ICatalog c) { 

        }
        public override void RemoveCatalog(string id) { 
        }
        public override ICatalog GetCatalog(string id) { 
        }
        public override IEnumerable<ICatalog> GetAllCatalogs() { 
        }
        //---------------------------------------------------

        public override void AddUser(IUser u) { 
        }
        public override void RemoveUser(string id) { 
        }
        public override IUser GetUser(string id) { 
        }
        public override IEnumerable<IUser> GetUsersList() { 
        }

        //---------------------------------------------------
        public override void AddState(IState s) { 
        }
        public override void RemoveState(string id) { 
        }
        public override IState GetState(string id) { 
        }
        public override IEnumerable<IState> GetAllStates() { 
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

        public override IEnumerable<IEvent> GetEventsList();
    }
}
