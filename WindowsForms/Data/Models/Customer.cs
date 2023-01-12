namespace WindowsForms.Data.Models; 

public record Customer {
    public int id { get; set; }
    
    public string firstName { get; set; }
    
    public string lastName { get; set; }
}