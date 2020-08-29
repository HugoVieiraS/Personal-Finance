using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Seguranca
{
    public interface ITokenFactory
    {
        string Token { get; }
    }
}
