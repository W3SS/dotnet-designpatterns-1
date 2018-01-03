﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }
        public ImpostoMuitoAlto(Imposto outro) : base(outro) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoOutroImposto(orcamento);
        }
    }
}
