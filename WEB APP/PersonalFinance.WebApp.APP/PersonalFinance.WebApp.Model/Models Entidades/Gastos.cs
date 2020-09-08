using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApp.Model
{
    public class Gastos
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Nome da conta")]
        [DisplayFormat(NullDisplayText = "-")]
        public string NomeConta { get; set; }

        [DisplayName("Valor")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Valor { get; set; }

        [DisplayName("Data de pagamento")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataPagamento { get; set; }

        [DisplayName("Data do gasto")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataGasto { get; set; }

        [DisplayName("Competencia")]
        [DisplayFormat(NullDisplayText = "-")]
        public int CompetenciaId { get; set; }
        #endregion
    }
}