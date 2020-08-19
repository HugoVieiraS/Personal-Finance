using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class ContaBancaria : EntityBase
    {
        #region Properties
        public string NomeBanco { get; set; }
        public double ValorConta { get; set; }
        public double Rendimento { get; set; }

        public virtual Competencia Competencia { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
    public class ContaBancariaApi
    {
        #region Properties
        public int Id { get; set; }
        public string NomeBanco { get; set; }
        public double ValorConta { get; set; }
        public double Rendimento { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
}
