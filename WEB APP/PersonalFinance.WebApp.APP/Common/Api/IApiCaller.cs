using System;
using System.Threading.Tasks;

namespace Common
{
    public interface IApiCaller
    {
        Task<T> CallWebApiByPost<T>(object requestObject, string controller, string method);
        Task<T> CallWebApiByGet<T>(string controller);
    }
}
