using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApp.Model
{
    public class Salario
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Origem do ganho")]
        [DisplayFormat(NullDisplayText = "-")]
        public string OrigemGanho { get; set; }

        [DisplayName("Nome do investimento")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataRecebimento { get; set; }

        [DisplayName("Valor bruto")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorBruto { get; set; }

        [DisplayName("Desconto 1")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Desconto1 { get; set; }

        [DisplayName("Desconto 2")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Desconto2 { get; set; }

        [DisplayName("Imposto")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Imposto { get; set; }

        [DisplayName("Valor liquído")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorLiquido { get; set; }

        [DisplayName("Ganho adicional")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorAdicional { get; set; }

        [DisplayName("Competência")]
        [DisplayFormat(NullDisplayText = "-")]
        public int CompetenciaId { get; set; }
        #endregion
    }
}