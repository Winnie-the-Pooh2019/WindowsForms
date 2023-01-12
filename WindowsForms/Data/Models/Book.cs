namespace WindowsForms.Data.Models;

public record Book {
    public int id { get; set; } = 0;

    public string name { get; set; }
    
    // public Publisher? publisher { get; set; }

    public int publisherId { get; set; }
    
    // public Category? category { get; set; }

    public int categoryId { get; set; }
}