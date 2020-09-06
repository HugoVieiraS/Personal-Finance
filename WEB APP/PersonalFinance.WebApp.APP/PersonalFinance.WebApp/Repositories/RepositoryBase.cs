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
        protected string Token => "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhZG1pbiIsImp0aSI6IjZkYmFmNTczLTgzYzktNDUyYi04YTYwLTgwNDAyYmJjZTYxYiIsImV4cCI6MTU5OTQxMjYyNSwiaXNzIjoiUGVyc29uYWxGaW5hbmNlLldlYkFQSSIsImF1ZCI6IlBvc3RtYW4ifQ.MfLm_9XGOe9WVGz8PMsAOzCi5Wr6oIFq9Fs3F2PsSTA";
           /*UserResolverService.GetToken();*/
        //protected UserResolverService UserResolverService;
        protected IApiCaller ApiCaller;

        protected RepositoryBase(IApiCaller apiCaller)
        {
            ApiCaller = apiCaller;
        }
    }
}
