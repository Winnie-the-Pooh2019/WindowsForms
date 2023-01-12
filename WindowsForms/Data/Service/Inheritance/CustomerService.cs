using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class CustomerService : CrudService<Customer> {
    public CustomerService(string url, string token) : base(url, token) { }
}