using FunctionExample.Models;
using System.Threading.Tasks;

namespace FunctionExample.Services
{
    public interface IGitHubService
    {
        Task<User> GetUser(string userName);
    }
}