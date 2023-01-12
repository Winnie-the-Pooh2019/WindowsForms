using System.Threading.Tasks;
using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service; 

public interface IAuthService {
    public Task<Access> signIn(string login, string password);
    public Task<bool> signUp(User user);
}