using System;

namespace WindowsForms.Data.Models;

public record Delivery {
    public int id { get; set; }
    
    public Book? book { get; set; }

    public int bookId { get; set; }

    public DateTime deliveryDate { get; set; }
    
    public int booksCount { get; set; }
    
    public double price { get; set; }
}