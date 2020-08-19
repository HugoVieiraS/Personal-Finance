using PersonalFinance.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Extensions
{
    public static class GastosExtension
    {
        #region Methods Extensions
        public static Gastos ToModel(this GastosApi model)
        {
            return new Gastos
            {
                Id = model.Id,
                NomeConta = model.NomeConta,
                Valor = model.Valor,
                CompetenciaId = model.CompetenciaId,
                DataPagamento = Convert.ToDateTime(model.DataPagamento),
                DataGasto = Convert.ToDateTime(model.DataGasto),
            };
        }

        public static GastosApi ToApi(this Gastos model)
        {
            return new GastosApi
            {
                Id = model.Id,
                NomeConta = model.NomeConta,
                Valor = model.Valor,
                CompetenciaId = model.CompetenciaId,
                DataPagamento = Convert.ToString(model.DataPagamento),
                DataGasto = Convert.ToString(model.DataGasto),
            };
        }
        #endregion
    }
}
