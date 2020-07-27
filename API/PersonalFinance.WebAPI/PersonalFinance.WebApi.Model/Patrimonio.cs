using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    public class Patrimonio : EntityBase
    {
        public double ValorPatrimonio { get; set; }
        public IList<Competencia> Competencia { get; set; }
        public virtual ContaBancaria ContaBancaria { get; set; }
        public int ContaBancariaId { get; set; }
        public virtual Investimentos Investimentos { get; set; }
        public int InvestimentosId { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public int UsuariosId { get; set; }

    }
}
