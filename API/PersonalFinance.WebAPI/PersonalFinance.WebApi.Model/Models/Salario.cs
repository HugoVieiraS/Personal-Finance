using System;
using System.Collections.Generic;

namespace PersonalFinance.WebApi.Model
{
    public class Salario : EntityBase
    {
        #region Properties
        public string OrigemGanho { get; set; } 
        public DateTime DataRecebimento { get; set; }
        public double ValorBruto { get; set; }
        public double Desconto1 { get; set; }
        public double Desconto2 { get; set; }
        public double Imposto { get; set; }
        public double ValorLiquido { get; set; }
        public double ValorAdicional { get; set; }

        public virtual Competencia Competencia { get; set; }
        public int CompetenciaId { get; set; }
        #endregion  
    }

    public class SalarioApi
    {
        #region Properties
        public int Id { get; set; }
        public string OrigemGanho { get; set; }
        public string DataRecebimento { get; set; }
        public double ValorBruto { get; set; }
        public double Desconto1 { get; set; }
        public double Desconto2 { get; set; }
        public double Imposto { get; set; }
        public double ValorLiquido { get; set; }
        public double ValorAdicional { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
}