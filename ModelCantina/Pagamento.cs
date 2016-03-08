using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public DateTime DataPagamento {get;set;}
        public double ValorPagamento { get; set; }
        public Conta Conta { get; set; }
    }
}
