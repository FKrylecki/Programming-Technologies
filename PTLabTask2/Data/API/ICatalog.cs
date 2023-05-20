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
        decimal Price 
        { 
            get; 
            set; 
        }
    }
}
