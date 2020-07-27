using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class Competencia : EntityBase
    {
        public DateTime Inicial { get; set; }
        public DateTime Final { get; set; }
        public double ValorGasto { get; set; }
        public double ValorGanho { get; set; }
        public double ValorSobra { get; set; }

        public virtual Salario Salario { get; set; }
        public int SalarioId { get; set; }
        public virtual Gastos Gastos { get; set; }
        public int GastosId { get; set; }
        public virtual GanhoExtra GanhoExtra { get; set; }
        public int GanhoExtraId { get; set; }
        public virtual Patrimonio Patrimonio { get; set; }
        public int PatrimonioId { get; set; }
    }
}
