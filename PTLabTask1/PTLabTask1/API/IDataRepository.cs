
namespace Data.API
{
    public abstract class IDataRepository
    {
        public abstract void AddEvent(IEvent e);
        public abstract void RemoveEvent(IEvent e);
    }
}
