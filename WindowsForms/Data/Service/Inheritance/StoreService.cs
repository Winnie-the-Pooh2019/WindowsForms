using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class StoreService : CrudService<Store> {
    public StoreService(string url, string token) : base(url, token) { }
}