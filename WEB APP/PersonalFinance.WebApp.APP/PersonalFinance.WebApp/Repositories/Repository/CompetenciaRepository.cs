using Common;
using PersonalFinance.WebApp.Model;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Repository
{
    public class CompetenciaRepository : RepositoryBase, ICompetenciaRepository
    {
        #region Properties
        public string ControllerName => "competencias";
        #endregion

        #region Constructor
        public CompetenciaRepository(IApiCaller apiCaller) 
            : base(apiCaller){ }
        #endregion

        #region Mehtods
        public void Edit(Competencia model)
        {
            _ = ApiCaller.CallWebApiByPut<Competencia>(Token, model, $"{ControllerName}").Result;
        }

        public Competencia Get(int id)
        {
            return ApiCaller.CallWebApiByGet<Competencia>(Token, $"{ControllerName}/{id}").Result;
        }

        public void Insert(Competencia model)
        {
            _ = ApiCaller.CallWebApiByPost<Competencia>(Token, model, $"{ControllerName}").Result;
        }

        public IEnumerable<Competencia> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<Competencia>>(Token, ControllerName).Result;
        }

        public Competencia Delete(int id)
        {
            return ApiCaller.CallWebApiByDelete<Competencia>(Token, $"{ControllerName}/{id}").Result;
        }
        #endregion
    }
}
