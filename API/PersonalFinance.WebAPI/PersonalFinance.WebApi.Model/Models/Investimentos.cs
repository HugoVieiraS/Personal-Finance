namespace PersonalFinance.WebApi.Model
{
    public class Investimentos : EntityBase
    {
        #region Properties
        public string NomeInvestimento { get; set; }
        public double ValorInvestido { get; set; }
        public double Rendimento { get; set; }

        public virtual Competencia Competencia { get; set; }
        public int CompetenciaId { get; set; }
        #endregion
    }
}