using System;

namespace WindowsForms.Data.Models;

public record PriceChange {
    public int id { get; set; }
    
    public DateTime priceChanged { get; set; }
    
    public double newPrice { get; set; }
}