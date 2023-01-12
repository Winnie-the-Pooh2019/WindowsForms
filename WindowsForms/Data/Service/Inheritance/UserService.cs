using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class UserService : CrudService<User> {
    public UserService(string url, string token) : base(url, token) { }
}