using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model.Extensions
{
    public static class SalarioExtension
    {
        #region Methods Extensions
        public static Salario ToModel(this SalarioApi model)
        {
            return new Salario
            {
                Id = model.Id,
                NomeEmpresa = model.NomeEmpresa,
                DataRecebimento = Convert.ToDateTime(model.DataRecebimento),
                ValorBruto = model.ValorBruto,
                Desconto1 = model.Desconto1,
                Desconto2 = model.Desconto2,
                Imposto = model.Imposto,
                ValorLiquido = model.ValorLiquido,
                ValorAdicional = model.ValorAdicional,
                CompetenciaId = model.CompetenciaId,
            };
        }

        public static SalarioApi ToApi(this Salario model)
        {
            return new SalarioApi
            {
                Id = model.Id,
                NomeEmpresa = model.NomeEmpresa,
                DataRecebimento = Convert.ToString(model.DataRecebimento),
                ValorBruto = model.ValorBruto,
                Desconto1 = model.Desconto1,
                Desconto2 = model.Desconto2,
                Imposto = model.Imposto,
                ValorLiquido = model.ValorLiquido,
                ValorAdicional = model.ValorAdicional,
                CompetenciaId = model.CompetenciaId,
            };
        }
        #endregion
    }
}
