using System;
using System.Security.Cryptography;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class Usuarios : EntityBase
    {
        #region Properties
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        #endregion

        #region Private Methods
        private string GerarHash(string senha)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(senha);
            var hash = md5.ComputeHash(inputBytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }
        #endregion
    }
}
