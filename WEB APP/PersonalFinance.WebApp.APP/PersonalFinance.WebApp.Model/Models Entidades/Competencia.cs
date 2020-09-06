using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.WebApp.Model
{
    public class Competencia
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Data inicial")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataInicial { get; set; }


        [DisplayName("Data de fechamento")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataFinal { get; set; }

        [DisplayName("Valor gasto")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorGasto { get; set; }

        [DisplayName("Valor ganho")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorGanho { get; set; }

        [DisplayName("Valor economizado")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorSobra { get; set; }     
        #endregion
    }
}
