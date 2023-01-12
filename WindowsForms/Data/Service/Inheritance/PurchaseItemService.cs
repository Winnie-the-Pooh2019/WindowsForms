using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class PurchaseItemService : CrudService<PurchaseItem> {
    public PurchaseItemService(string url, string token) : base(url, token) { }
}