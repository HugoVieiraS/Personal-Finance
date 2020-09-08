using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class ContaBancariaRepository : RepositoryBase, IContaBancariaRepository
    {
        #region Properties
        public string ControllerName => "contabancaria";
        #endregion

        #region Constructor
        public ContaBancariaRepository(IApiCaller apiCaller)
            : base(apiCaller) { }
        #endregion

        #region Mehtods
        public void Edit(ContaBancaria model)
        {
            _ = ApiCaller.CallWebApiByPut<ContaBancaria>(Token, model, $"{ControllerName}").Result;
        }

        public ContaBancaria Get(int id)
        {
            return ApiCaller.CallWebApiByGet<ContaBancaria>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(ContaBancaria model)
        {
            _ = ApiCaller.CallWebApiByPost<ContaBancaria>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<ContaBancaria> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<ContaBancaria>>(Token, ControllerName).Result;
        }

        public ContaBancaria Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<ContaBancaria>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}

