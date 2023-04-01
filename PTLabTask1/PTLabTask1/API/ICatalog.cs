namespace Data.API
{
    public interface ICatalog
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
        float Price 
        { 
            get; 
            set; 
        }
    }
}
