using System;

namespace WindowsForms.Data.Models;

public record Purchase {
    public int id { get; set; } = 0;
    
    public Customer? customer { get; set; }

    public int customerId { get; set; }

    public DateTime purchaseDate { get; set; }
};