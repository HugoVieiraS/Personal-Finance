using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class SalarioRepository : RepositoryBase, ISalarioRepository
    {
        #region Properties
        public string ControllerName => "salario";
        #endregion

        #region Constructor
        public SalarioRepository(IApiCaller apiCaller)
            : base(apiCaller) { }
        #endregion

        #region Mehtods
        public void Edit(Salario model)
        {
            _ = ApiCaller.CallWebApiByPut<Salario>(Token, model, $"{ControllerName}").Result;
        }

        public Salario Get(int id)
        {
            return ApiCaller.CallWebApiByGet<Salario>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(Salario model)
        {
            _ = ApiCaller.CallWebApiByPost<Salario>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<Salario> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<Salario>>(Token, ControllerName).Result;
        }

        public Salario Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<Salario>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}