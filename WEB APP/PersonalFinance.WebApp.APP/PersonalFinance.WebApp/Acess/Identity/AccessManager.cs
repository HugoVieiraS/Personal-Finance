using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Acess
{
    public class AccessManager
    {
        internal static string GetRoles(ControllerNames controllerName)
        {
            return controllerName switch
            {
                ControllerNames.Competencia => AppRoles.Generate(AppRoles.ADMINISTRADOR),
                _ => AppRoles.ADMINISTRADOR
            };
        }
    }
}
