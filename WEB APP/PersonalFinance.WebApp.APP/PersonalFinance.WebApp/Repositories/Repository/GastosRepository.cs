using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class GastosRepository : RepositoryBase, IGastosRepository
    {
        #region Properties
        public string ControllerName => "gastos";
        #endregion

        #region Constructor
        public GastosRepository(IApiCaller apiCaller)
            : base(apiCaller) { }
        #endregion

        #region Mehtods
        public void Edit(Gastos model)
        {
            _ = ApiCaller.CallWebApiByPut<Gastos>(Token, model, $"{ControllerName}").Result;
        }

        public Gastos Get(int id)
        {
            return ApiCaller.CallWebApiByGet<Gastos>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(Gastos model)
        {
            _ = ApiCaller.CallWebApiByPost<Gastos>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<Gastos> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<Gastos>>(Token, ControllerName).Result;
        }

        public Gastos Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<Gastos>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}