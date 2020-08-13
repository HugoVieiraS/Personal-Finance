using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Models
{
    public class Usuarios
    {
        #region Properties
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        #endregion
    }
}
