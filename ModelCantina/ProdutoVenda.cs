using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class ProdutoVenda
    {
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
    }
}
