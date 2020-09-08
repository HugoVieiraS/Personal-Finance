using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class InvestimentosRepository : RepositoryBase, IInvestimentosRepository
    {
        #region Properties
        public string ControllerName => "investimentos";
        #endregion

        #region Constructor
        public InvestimentosRepository(IApiCaller apiCaller)
            : base(apiCaller) { }
        #endregion

        #region Mehtods
        public void Edit(Investimentos model)
        {
            _ = ApiCaller.CallWebApiByPut<Investimentos>(Token, model, $"{ControllerName}").Result;
        }

        public Investimentos Get(int id)
        {
            return ApiCaller.CallWebApiByGet<Investimentos>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(Investimentos model)
        {
            _ = ApiCaller.CallWebApiByPost<Investimentos>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<Investimentos> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<Investimentos>>(Token, ControllerName).Result;
        }

        public Investimentos Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<Investimentos>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}