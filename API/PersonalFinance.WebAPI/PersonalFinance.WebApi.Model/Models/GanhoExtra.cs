﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class GanhoExtra: EntityBase
    {
        #region Properties
        public string Origem { get; set; }
        public double Valor { get; set; }
        public DateTime DataGanho { get; set; } //DataRecebimento

        public virtual Competencia Competencia { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }

    public class GanhoExtraApi
    {
        #region Properties
        public int Id { get; set; }
        public string Origem { get; set; }
        public double Valor { get; set; }
        public string DataGanho { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
}
