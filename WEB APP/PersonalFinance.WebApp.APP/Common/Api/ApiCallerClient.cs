using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Common.Api
{
    public class ApiCallerClient
    {
        //private const string uriClient = @"http://localhost:5000/api/";

        //public async Task<T> PostLoginAsync<T>(object model)
        //{
        //    var requestJson = JsonConvert.SerializeObject(model);

        //    using var handler = new HttpClientHandler();
        //    using var client = new HttpClient(handler) { BaseAddress = new Uri(uriClient) };

        //    var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
        //    var result = await client.PostAsync($"login/",requestContent);

        //    var resultContent = await result.Content.ReadAsStringAsync();
        //    if (result.StatusCode == HttpStatusCode.OK)
        //    {
        //        return JsonConvert.DeserializeObject<T>(resultContent);
        //    }
        //    else if (result.StatusCode == HttpStatusCode.Unauthorized)
        //    {
        //        throw new HttpRequestException("Usuario ou senha inválida");
        //    }

        //    throw new HttpRequestException($"Statuc code: { (int)result.StatusCode }. { resultContent }");
        //}

        //var resposta = await _httpClient.PostAsJsonAsync<LoginModel>(uri, model);
        //return new LoginResult(await resposta.Content.ReadAsStringAsync(), resposta.StatusCode);

        //public async Task PostRegisterAsync(RegisterViewModel model)
        //{
        //    var resposta = await _httpClient.PostAsJsonAsync<RegisterViewModel>("usuarios", model);
        //    resposta.EnsureSuccessStatusCode();
        //}
    }
}
