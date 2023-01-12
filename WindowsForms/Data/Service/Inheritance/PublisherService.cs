using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance;

public class PublisherService : CrudService<Publisher> {
    public PublisherService(string url, string token) : base(url, token) { }
}