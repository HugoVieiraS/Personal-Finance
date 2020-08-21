using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model.Extensions
{
    public static class GanhosExtrasExtension
    {
        #region Methods Extensions
        public static GanhoExtra ToModel(this GanhoExtraApi model)
        {
            return new GanhoExtra
            {
                Id = model.Id,
                DataRecebimento = Convert.ToDateTime(model.DataRecebimento),
                Valor = model.Valor,
                CompetenciaId = model.CompetenciaId,
            };
        }

        public static GanhoExtraApi ToApi(this GanhoExtra model)
        {
            return new GanhoExtraApi
            {
                Id = model.Id,
                DataRecebimento = Convert.ToString(model.DataRecebimento),
                Valor = model.Valor,
                CompetenciaId = model.CompetenciaId,
            };
        }
        #endregion
    }
}
