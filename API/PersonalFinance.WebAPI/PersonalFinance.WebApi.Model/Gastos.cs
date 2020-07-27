using System;
using System.Collections.Generic;

namespace PersonalFinance.WebApi.Model
{
    public class Gastos : EntityBase
    {
        #region Properties
        public string NomeConta { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataGasto { get; set; }
        public IList<Competencia> Competencia { get; set; }
        #endregion
    }
}