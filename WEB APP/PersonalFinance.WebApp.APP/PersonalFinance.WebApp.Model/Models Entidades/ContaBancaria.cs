using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApp.Model
{
    public class ContaBancaria
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Nome banco")]
        [DisplayFormat(NullDisplayText = "-")]
        public string NomeBanco { get; set; }

        [DisplayName("Valor na conta")]
        [DisplayFormat(NullDisplayText = "-")]
        public double ValorConta { get; set; }

        [DisplayName("Percentual do rendimento")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Rendimento { get; set; }

        #endregion
    }
}
