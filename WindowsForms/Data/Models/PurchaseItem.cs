namespace WindowsForms.Data.Models;

public record PurchaseItem {
    public int id { get; set; } = 0;
    
    public Purchase? purchase { get; set; }

    public int purchaseId { get; set; }
    
    public Book? book { get; set; }

    public int bookId { get; set; }
    
    public int booksCount { get; set; }
    
    public PriceChange? price { get; set; }

    public int priceId { get; set; }
}