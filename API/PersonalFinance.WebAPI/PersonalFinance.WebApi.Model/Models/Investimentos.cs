using System;

namespace PersonalFinance.WebApi.Model
{
    public class Investimentos : EntityBase
    {
        #region Properties
        public string NomeInvestimento { get; set; }
        public double ValorInvestido { get; set; }
        public double Rendimento { get; set; }
        public DateTime DataInvestimento { get; set; }
        #endregion
    }

    public class InvestimentosApi
    {
        #region Properties
        public int Id { get; set; }
        public string NomeInvestimento { get; set; }
        public double ValorInvestido { get; set; }
        public double Rendimento { get; set; }
        public string DataInvestimento { get; set; }
        #endregion
    }
}