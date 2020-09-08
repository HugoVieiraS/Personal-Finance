using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApp.Model
{
    public class Investimentos
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Nome do investimento")]
        [DisplayFormat(NullDisplayText = "-")]
        public string NomeInvestimento { get; set; }

        [DisplayName("Valor investido")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorInvestido { get; set; }

        [DisplayName("Valor do rendimento")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Rendimento { get; set; }

        [DisplayName("Data investido")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataInvestimento { get; set; }

        #endregion
    }
}
