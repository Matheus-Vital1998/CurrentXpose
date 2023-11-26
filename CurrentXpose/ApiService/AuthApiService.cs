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

        public async Task<object> Autenticar(string username, string password, string userType)
        {
            try
            {
                var endpoint = userType.ToLower() == "morador" ? "Auth/morador" : "Auth/sindico";
                var response = await _httpClient.PostAsync($"{endpoint}?username={username}&password={password}", null);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        return JsonConvert.DeserializeObject<object>(content);
                    }
                }
                else
                {
                    Console.WriteLine($"Erro na chamada da API. Código de status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na chamada da API: {ex.Message}");
            }

            return null;
        }
    }
}