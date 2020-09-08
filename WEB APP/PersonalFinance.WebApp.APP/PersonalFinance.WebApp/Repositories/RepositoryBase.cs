using Common;
using PersonalFinance.WebApp.Acess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories
{
    public abstract class RepositoryBase
    {
        protected string Token => "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhZG1pbiIsImp0aSI6Ijk2MWVjYzJmLTMzMzItNDU5Ni1iNTkwLWEzMDJiMWE4NjQwMCIsImV4cCI6MTYwMjA5NDMxMCwiaXNzIjoiUGVyc29uYWxGaW5hbmNlLldlYkFQSSIsImF1ZCI6IlBvc3RtYW4ifQ.-sXy091Ti2RYutMKDebCg1mjt_1jXvSpduXJrUvI6Yg";
           /*UserResolverService.GetToken();*/
        //protected UserResolverService UserResolverService;
        protected IApiCaller ApiCaller;

        protected RepositoryBase(IApiCaller apiCaller)
        {
            ApiCaller = apiCaller;
        }
    }
}
