using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ProdutoVenda> Items { get; set; }

        public Venda()
        {
            Items = new List<ProdutoVenda>();
        }

        public double ValorTotal
        {
            get
            {
                double total = 0.0;
                foreach (ProdutoVenda produtoVenda in Items)
                {
                    total += produtoVenda.Quantidade * produtoVenda.Produto.PrecoUnitario;
                }
                return total;
                
            }
        }



    }
}
