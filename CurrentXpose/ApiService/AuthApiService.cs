using CurrentXpose.ApiService.Interfaces;
using CurrentXpose.Models;
using Newtonsoft.Json;
using System.Text;

namespace CurrentXpose.ApiService
{
    public class AuthApiService : IAuthApiService
    {
        private readonly HttpClient _httpClient;
        public AuthApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<object> Autenticar(string username, string password)
        {
            var response = await _httpClient.PostAsync($"Auth?username={username}&password={password}", null);

            return response.Content.ReadAsStringAsync();
        }
    }
}
