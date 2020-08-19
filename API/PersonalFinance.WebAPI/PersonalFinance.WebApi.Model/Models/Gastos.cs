using PersonalFinance.WebApi.Model.Extensions;
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

        public virtual Competencia Competencia { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }

    public class GastosApi
    {
        #region Properties
        public int Id { get; set; }
        public string NomeConta { get; set; }
        public double Valor { get; set; }
        public String DataPagamento { get; set; }
        public String DataGasto { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
}