using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance; 

public class BookService : CrudService<Book> {
    public BookService(string url, string token) : base(url, token) { }
}