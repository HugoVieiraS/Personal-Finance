using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ApiCaller : IApiCaller
    {
        private const string BASE_ADRESS = @"https://localhost:44366/api/";
        protected static bool _alreadyTried = false;
        //private readonly authToken = "";

        public async Task<T> CallWebApiByPost<T>(string authToken, object requestObject, string controller)
        {
            var requestJson = JsonConvert.SerializeObject(requestObject);
            using var handler = new HttpClientHandler();
            using var client = new HttpClient(handler) { BaseAddress = new Uri(BASE_ADRESS) };

            //if (controller.EndsWith(@"/"))
            //    controller += @"/";

            //Autenticação via token
            if (!string.IsNullOrEmpty(authToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            }

            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var result = await client.PostAsync($"{ controller }", requestContent);

            var resultContent = await result.Content.ReadAsStringAsync();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
            {
                if (result.StatusCode == HttpStatusCode.InternalServerError && string.IsNullOrEmpty(resultContent))
                {
                    if (!_alreadyTried)
                    {
                        _alreadyTried = true;
                        return await CallWebApiByPost<T>(authToken, requestObject, controller);
                    }
                }
                else if (result.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new HttpRequestException("Usuario ou senha inválida");
                }
                else if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException($"{ resultContent.RemoveQuotes() }");
                }
                else if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new NotFoundException();
                }

                throw new HttpRequestException($"Statuc code: { (int)result.StatusCode }. { resultContent }");
            }
        }

        public async Task<T> CallWebApiByGet<T>(string authToken, string controller)
        {
            using var handler = new HttpClientHandler();
            using var client = new HttpClient(handler) { BaseAddress = new Uri(BASE_ADRESS) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

            //if (!controller.EndsWith(@"/"))
            //    controller += @"/";

            var result = await client.GetAsync($"{ controller }");

            var resultContent = await result.Content.ReadAsStringAsync();
            if(result.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
            {
                if (result.StatusCode == HttpStatusCode.InternalServerError && string.IsNullOrWhiteSpace(resultContent))
                {
                    if (!_alreadyTried)
                    {
                        _alreadyTried = true;
                        return await CallWebApiByGet<T>(authToken, controller);
                    }
                }
                else if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException($"{ resultContent.RemoveQuotes() }");
                }
                else if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    return default;
                }
                else if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new NotFoundException();
                }

                throw new HttpRequestException($"Status code: { (int)HttpStatusCode.InternalServerError }. { resultContent }");
            }

        }

        public async Task<T> CallWebApiByDelete<T>(string authToken, string controller)
        {
            using var handler = new HttpClientHandler();
            using var client = new HttpClient(handler) { BaseAddress = new Uri(BASE_ADRESS) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

            var result = await client.DeleteAsync($"{ controller }");

            var resultContent = await result.Content.ReadAsStringAsync();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
            {
                if (result.StatusCode == HttpStatusCode.InternalServerError && string.IsNullOrWhiteSpace(resultContent))
                {
                    if (!_alreadyTried)
                    {
                        _alreadyTried = true;
                        return await CallWebApiByDelete<T>(authToken, controller);
                    }
                }
                else if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException($"{ resultContent.RemoveQuotes() }");
                }
                else if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    return default;
                }
                else if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new NotFoundException();
                }

                throw new HttpRequestException($"Status code: { (int)HttpStatusCode.InternalServerError }. { resultContent }");
            }
        }

        public async Task<T> CallWebApiByPut<T>(string authToken, object requestObject, string controller)
        {
            var requestJson = JsonConvert.SerializeObject(requestObject);
            using var handler = new HttpClientHandler();
            using var client = new HttpClient(handler) { BaseAddress = new Uri(BASE_ADRESS) };

            //if (controller.EndsWith(@"/"))
            //    controller += @"/";

            //Autenticação via token
            if (!string.IsNullOrEmpty(authToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            }

            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var result = await client.PutAsync($"{ controller }", requestContent);

            var resultContent = await result.Content.ReadAsStringAsync();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
            {
                if (result.StatusCode == HttpStatusCode.InternalServerError && string.IsNullOrEmpty(resultContent))
                {
                    if (!_alreadyTried)
                    {
                        _alreadyTried = true;
                        return await CallWebApiByPut<T>(authToken, requestObject, controller);
                    }
                }
                else if (result.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new HttpRequestException("Usuario ou senha inválida");
                }
                else if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException($"{ resultContent.RemoveQuotes() }");
                }
                else if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new NotFoundException();
                }

                throw new HttpRequestException($"Statuc code: { (int)result.StatusCode }. { resultContent }");
            }
        }
    }
}
