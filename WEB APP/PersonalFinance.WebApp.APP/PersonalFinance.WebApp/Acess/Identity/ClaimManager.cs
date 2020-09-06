using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Acess
{
    public class ClaimManager
    {
        #region Constants
        private const string TOKEN_NAME = "Token";
        private const string PESSOA_IDENT = "IdentPessoa";
        private const string FULL_NAME = "NomeCompl";
        private const string IDENT = "Ident";
        #endregion

        #region Methods
        public static bool AllowedAccess(ControllerNames controllerName, ClaimsPrincipal user)
        {
            var perfil = user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(perfil))
            {
                return false;
            }

            perfil = perfil.ToLower();

            if (perfil == AppRoles.ADMINISTRADOR.ToLower())
            {
                return true;
            }

            var controllerRoles = AccessManager.GetRoles(controllerName);
            if (string.IsNullOrWhiteSpace(controllerRoles))
            {
                return true;
            }

            return controllerRoles.ToLower().Contains(perfil);
        }

        public static string GetUserToken(ClaimsPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var tokenClaim = user.Claims.FirstOrDefault(f => f.Type == TOKEN_NAME);
            return tokenClaim != null ? tokenClaim.Value : string.Empty;
        }

        public static string GetUserPessoaId(ClaimsPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var tokenClaim = user.Claims.FirstOrDefault(f => f.Type == PESSOA_IDENT);
            return tokenClaim != null ? tokenClaim.Value : string.Empty;
        }

        public static string GetUserId(ClaimsPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var tokenClaim = user.Claims.FirstOrDefault(f => f.Type == IDENT);
            return tokenClaim != null ? tokenClaim.Value : string.Empty;
        }

        public static string GetUserFullName(ClaimsPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var tokenClaim = user.Claims.FirstOrDefault(f => f.Type == FULL_NAME);
            return tokenClaim != null ? tokenClaim.Value : string.Empty;
        }

        public static string GetUserRole(ClaimsPrincipal user)
        {
            var perfil = user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(perfil))
            {
                return string.Empty;
            }
            return perfil;
        }
        #endregion
    }
}