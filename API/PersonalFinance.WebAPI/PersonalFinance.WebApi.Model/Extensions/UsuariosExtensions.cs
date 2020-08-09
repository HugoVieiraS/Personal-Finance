using PersonalFinance.WebApi.Model;
using System;
using System.Security.Cryptography;
using System.Text;

namespace PersonalFinance.WebApi.Extensions
{
    public static class UsuariosExtensions
    {
        #region Methods Extensions
        public static Usuarios ToModel(this Usuarios model)
        {
            return new Usuarios
            {
                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Login = model.Login,
                Senha = model.Senha,
            };
        }

        public static UsuariosApi ToApi(this Usuarios model)
        {
            return new UsuariosApi
            {
                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Login = model.Login,
            };
        }
        #endregion
    }
}
