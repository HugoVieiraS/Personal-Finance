using PersonalFinance.WebApp.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace PersonalFinance.WebApp.Acess
{
    public class LoginResult
    {
        public string Token { get; set; }
        public bool Succeeded { get; set; }

        public LoginResult(string token, HttpStatusCode statusCode)
        {
            Token = token;
            Succeeded = (statusCode == HttpStatusCode.OK);
        }
    }

    public class AuthApiClient
    {
        string uri = "http://localhost:5000/api/login";
        
        private readonly HttpClient _httpClient;

        public AuthApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginResult> PostLoginAsync(LoginModel model)
        {
            var resposta = await _httpClient.PostAsJsonAsync<LoginModel>(uri, model);
            return new LoginResult(await resposta.Content.ReadAsStringAsync(), resposta.StatusCode);
        }

        public async Task PostRegisterAsync(RegisterViewModel model)
        {
            var resposta = await _httpClient.PostAsJsonAsync<RegisterViewModel>("usuarios", model);
            resposta.EnsureSuccessStatusCode();
        }
    }
}
