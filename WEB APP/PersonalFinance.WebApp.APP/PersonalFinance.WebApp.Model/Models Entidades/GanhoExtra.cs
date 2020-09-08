using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApp.Model
{
    public class GanhoExtra
    {
        #region Properties
        [Key]
        [DisplayName("Identificador")]
        public int Id { get; set; }

        [DisplayName("Origem do ganho")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Origem { get; set; }

        [DisplayName("Valor")]
        [DisplayFormat(NullDisplayText = "-")]
        public double Valor { get; set; }

        [DisplayName("Data recebido")]
        [DisplayFormat(NullDisplayText = "-")]
        public DateTime DataRecebimento { get; set; }

        [DisplayName("Competencia")]
        [DisplayFormat(NullDisplayText = "-")]
        public int CompetenciaId { get; set; }
        #endregion
    }
}