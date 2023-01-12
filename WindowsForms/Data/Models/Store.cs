namespace WindowsForms.Data.Models;

public record Store {
    public int bookId { get; set; }
    
    public Book? book { get; set; }
    
    public int booksCount { get; set; }
    
    public PriceChange? price { get; set; }

    public int priceChangeId { get; set; }
}