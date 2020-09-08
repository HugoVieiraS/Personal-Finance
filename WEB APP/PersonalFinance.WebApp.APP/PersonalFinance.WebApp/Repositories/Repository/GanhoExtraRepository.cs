using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class GanhoExtraRepository : RepositoryBase, IGanhoExtraRepository
    {

        #region Properties
        public string ControllerName => "ganhosextra";
        #endregion

        #region Constructor
        public GanhoExtraRepository(IApiCaller apiCaller)
            : base(apiCaller) { }
        #endregion

        #region Mehtods
        public void Edit(GanhoExtra model)
        {
            _ = ApiCaller.CallWebApiByPut<GanhoExtra>(Token, model, $"{ControllerName}").Result;
        }

        public GanhoExtra Get(int id)
        {
            return ApiCaller.CallWebApiByGet<GanhoExtra>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(GanhoExtra model)
        {
            _ = ApiCaller.CallWebApiByPost<GanhoExtra>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<GanhoExtra> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<GanhoExtra>>(Token, ControllerName).Result;
        }

        public GanhoExtra Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<GanhoExtra>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}