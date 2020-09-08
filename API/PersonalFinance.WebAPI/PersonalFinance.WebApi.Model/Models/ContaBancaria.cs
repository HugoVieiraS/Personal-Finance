using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.WebApi.Model
{
    public class ContaBancaria : EntityBase
    {
        #region Properties
        public string NomeBanco { get; set; }
        public double ValorConta { get; set; }
        public double Rendimento { get; set; }   
        #endregion
    }
    public class ContaBancariaApi
    {
        #region Properties
        public int Id { get; set; }
        public string NomeBanco { get; set; }
        public double ValorConta { get; set; }
        public double Rendimento { get; set; }
        #endregion
    }
}
