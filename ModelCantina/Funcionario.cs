﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Funcionario
    {   
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
