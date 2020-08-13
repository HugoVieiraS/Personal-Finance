using Common;
using PersonalFinance.WebApp.Models;
using PersonalFinance.WebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories
{
    internal class UsuariosRepository :RepositoryBase, IUsuariosRepository
    {
        public string ControllerName => "usuarios";
        
        public UsuariosRepository(IApiCaller apiCaller)
            : base(apiCaller) { }

        public void Edit(Usuarios model)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuarios model)
        {
            _ = ApiCaller.CallWebApiByPost<Usuarios>(model, ControllerName, $"usuarios").Result;
        }

        public IEnumerable<Usuarios> List()
        {
            return ApiCaller.CallWebApiByGet<IEnumerable<Usuarios>>(ControllerName).Result;
        }

        public Usuarios Get(int id)
        {
            return ApiCaller.CallWebApiByGet<Usuarios>($"/{ControllerName}/{id}").Result;
        }
    }
}
