using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class PurchaseService : CrudService<Purchase> {
    public PurchaseService(string url, string token) : base(url, token) { }
}