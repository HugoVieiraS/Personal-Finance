using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model.Extensions
{
    public static class InvestimentoExtension
    {
        #region Methods Extensions
        public static Investimentos ToModel(this InvestimentosApi model)
        {
            return new Investimentos
            {
                Id = model.Id,
                NomeInvestimento = model.NomeInvestimento,
                ValorInvestido = model.ValorInvestido,
                Rendimento = model.Rendimento,
                DataInvestimento = Convert.ToDateTime(model.DataInvestimento),
                CompetenciaId = model.CompetenciaId,
            };
        }

        public static InvestimentosApi ToApi(this Investimentos model)
        {
            return new InvestimentosApi
            {
                Id = model.Id,
                NomeInvestimento = model.NomeInvestimento,
                ValorInvestido = model.ValorInvestido,
                Rendimento = model.Rendimento,
                DataInvestimento = Convert.ToString(model.DataInvestimento),
                CompetenciaId = model.CompetenciaId,
            };
        }
        #endregion
    }
}
