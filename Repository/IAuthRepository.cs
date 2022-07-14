using System.Threading.Tasks;
using TokenAuthantication.Models;

namespace TokenAuthantication.Repository
{
    public interface IAuthRepository
    {
        
            Task<TblUser> Register(TblUser user, string password);
            Task<TblUser> Login(string username, string password);
            Task<bool> UserExists(string username);
    }

}