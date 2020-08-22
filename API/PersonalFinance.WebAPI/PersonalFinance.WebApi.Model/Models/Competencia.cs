using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class Competencia : EntityBase
    {
        #region Properties
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public double ValorGasto { get; set; }
        public double ValorGanho { get; set; }
        public double ValorSobra { get; set; }

        public virtual IList<Salario> Salario { get; set; }
        public virtual IList<Investimentos> Investimentos { get; set; }
        public virtual IList<Gastos> Gastos { get; set; }
        public virtual IList<GanhoExtra> GanhoExtra { get; set; }
        public virtual IList<ContaBancaria> ContaBancaria { get; set; }
        #endregion
    }

    public class CompetenciaApi
    {
        #region Properties
        public int Id { get; set; }
        public String DataInicial { get; set; }
        public String DataFinal { get; set; }
        public double ValorGasto { get; set; }
        public double ValorGanho { get; set; }
        public double ValorSobra { get; set; }
        #endregion
    }
}
