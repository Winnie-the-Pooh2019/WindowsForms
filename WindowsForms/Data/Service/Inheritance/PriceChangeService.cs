using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class PriceChangeService : CrudService<PriceChange> {
    public PriceChangeService(string url, string token) : base(url, token) { }
}