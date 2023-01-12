using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance;

public class DeliveryService : CrudService<Delivery> {
    public DeliveryService(string url, string token) : base(url, token) { }
}