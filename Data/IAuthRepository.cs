using System.Threading.Tasks;
using dotnet_rpg.Model;

namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
        //Register with user and return the int of the user
        Task<ServiceResponse<int>> Register(User user, string password);

        //Login with 2 string parameters and retur token string
        Task<ServiceResponse<string>> Login(string username, string password);

        //User exist with the user name if exist

        Task<bool> UserExist(string username);

    }
}