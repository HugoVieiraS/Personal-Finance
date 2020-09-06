using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Acess
{
    public class AppRoles
    {
        #region Constants
        public const string ADMINISTRADOR = "Administrador";

        public static string[] UserRoles => new string[] { ADMINISTRADOR };
        #endregion

        #region Methods
        internal static string GetUserRole(int perfil)
        {
            return perfil switch
            {
                1 => ADMINISTRADOR,
                _ => string.Empty,
            };
        }

        internal static string Generate(params string[] args)
        {
            if (args == null || args.Length <= 0)
            {
                return ADMINISTRADOR;
            }

            var roles = UserRoles.Where(p => args.Contains(p));
            if (roles == null || !roles.Any())
            {
                return ADMINISTRADOR;
            }

            return roles.Aggregate((a, b) => $"{a},{b}");
        }
        #endregion
    }
}
