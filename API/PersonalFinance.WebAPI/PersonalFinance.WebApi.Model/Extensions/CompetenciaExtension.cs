using Newtonsoft.Json;
using PersonalFinance.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PersonalFinance.WebApi.Extensions
{
    public static class CompetenciaExtension
    {
        #region Methods Extensions
        public static Competencia ToModel(this CompetenciaApi model)
        {
            return new Competencia
            {
                Id = model.Id,
                DataInicial = Convert.ToDateTime(model.DataInicial),
                DataFinal   = Convert.ToDateTime(model.DataFinal),
                ValorGasto  = model.ValorGasto,
                ValorGanho  = model.ValorGanho,
                ValorSobra  = model.ValorSobra,
            };
        }

        public static CompetenciaApi ToApi(this Competencia model)
        {
            return new CompetenciaApi
            {
                Id = model.Id,
                DataInicial = Convert.ToString(model.DataInicial),
                DataFinal   = Convert.ToString(model.DataFinal),
                ValorGasto  = model.ValorGasto,
                ValorGanho  = model.ValorGanho,
                ValorSobra  = model.ValorSobra,
            };
        }
        #endregion
    }
}
