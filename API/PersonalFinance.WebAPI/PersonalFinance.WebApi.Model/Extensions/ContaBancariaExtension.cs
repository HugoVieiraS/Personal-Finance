using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model.Extensions
{
    public static class ContaBancariaExtension
    {
        #region Methods Extensions
        public static ContaBancaria ToModel(this ContaBancariaApi model)
        {
            return new ContaBancaria
            {
                Id = model.Id,
                NomeBanco = model.NomeBanco,
                ValorConta = model.ValorConta,
                Rendimento = model.Rendimento,
                CompetenciaId = model.CompetenciaId,
            };
        }

        public static ContaBancariaApi ToApi(this ContaBancaria model)
        {
            return new ContaBancariaApi
            {
                Id = model.Id,
                NomeBanco = model.NomeBanco,
                ValorConta = model.ValorConta,
                Rendimento = model.Rendimento,
                CompetenciaId = model.CompetenciaId,
            };
        }
        #endregion
    }
}