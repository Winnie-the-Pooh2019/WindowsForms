using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class CategoryService : CrudService<Category> {
    public CategoryService(string url, string token) : base(url, token) { }
}