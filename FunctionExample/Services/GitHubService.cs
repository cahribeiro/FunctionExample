using FunctionExample.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunctionExample.Services
{
    public class GitHubService : IGitHubService
    {
        private HttpClient _httpClient;

        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetUser(string userName)
        {
            var response = await _httpClient.GetAsync(userName);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(content);
            
        }
    }
}
