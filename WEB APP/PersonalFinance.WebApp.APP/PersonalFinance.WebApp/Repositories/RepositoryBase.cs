using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories
{
    internal abstract class RepositoryBase
    {
        protected IApiCaller ApiCaller;

        protected RepositoryBase(IApiCaller apiCaller)
        {
            ApiCaller = apiCaller;
        }
    }
}
