namespace Data.API
{
    public interface ICatalog
    {
        string Id 
        { 
            get; 
            set; 
        }
        string Name 
        { 
            get; 
            set; 
        }
        float Price 
        { 
            get; 
            set; 
        }
    }
}
