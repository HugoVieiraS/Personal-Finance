﻿using System;
using System.Collections.Generic;

namespace PersonalFinance.WebApi.Model
{
    public class Salario : EntityBase
    {
        #region Properties
        public string NomeEmpresa { get; set; }
        public DateTime DataRecebimento { get; set; }
        public double ValorBruto { get; set; }
        public double Desconto1 { get; set; }
        public double Desconto2 { get; set; }
        public double Imposto { get; set; }
        public double ValorLiquido { get; set; }
        public double ValorAdicional { get; set; }
        public IList<Competencia> Competencia { get; set; }
        #endregion  
    }
}