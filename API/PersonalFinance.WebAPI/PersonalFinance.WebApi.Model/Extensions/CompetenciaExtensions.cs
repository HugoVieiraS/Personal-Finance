using PersonalFinance.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Extensions
{
    public static class CompetenciaExtensions
    {
        #region Methods Extensions
        public static Competencia ToModel(this Competencia model)
        {
            return new Competencia
            {
                Id = model.Id,
                DataInicial = model.DataInicial,
                DataFinal = model.DataFinal,
                ValorGasto = model.ValorGasto,
                ValorGanho = model.ValorGanho,
                ValorSobra = model.ValorSobra,
            };
        }

        public static CompetenciaApi ToApi(this CompetenciaApi model)
        {
            return new CompetenciaApi
            {
                Id = model.Id,
                DataInicial = model.DataInicial,
                DataFinal = model.DataFinal,
                ValorGasto = model.ValorGasto,
                ValorGanho = model.ValorGanho,
                ValorSobra = model.ValorSobra,
            };
        }
        #endregion
    }
}
