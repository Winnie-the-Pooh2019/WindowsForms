using System;

namespace WindowsForms.Data.Models;

public record PriceChange {
    public int id { get; set; } = 0;
    
    public DateTime priceChanged { get; set; }
    
    public double newPrice { get; set; }
}