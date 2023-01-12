namespace WindowsForms.Data.Models;

public record User {
    public int id { get; set; } = 0;
    public string login { get; set; }
    
    public string password { get; set; }
    
    public string firstName { get; set; }
    
    public string lastName { get; set; }

    public string role { get; set; } = "user";
};