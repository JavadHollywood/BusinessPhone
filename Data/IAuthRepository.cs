using System.Threading.Tasks;
using BusinessPhone.Models;

namespace BusinessPhone.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username,string password);
         Task<bool> UserExists(string username);
         
    }
}