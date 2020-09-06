using System;
using System.Threading.Tasks;

namespace Common
{
    public interface IApiCaller
    {
        Task<T> CallWebApiByGet<T>(string authToken, string controller);
        Task<T> CallWebApiByPost<T>(string authToken, object requestObject, string controller);
        Task<T> CallWebApiByDelete<T>(string authToken, string controller);
        Task<T> CallWebApiByPut<T>(string authToken, object requestObject, string controller);
    }
}
