using Data.API;

namespace Data.CodeImplementation
{
    internal class DataPepository : IDataRepository
    {
        private DataContext data;
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
    }
}
