using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class VendaProduto
    {
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double PrecoUnitario
        {
            get
            {
                return Produto.PrecoUnitario;
            }
        }
        public double Total
        {
            get
            {
                return Produto.PrecoUnitario * Quantidade;
            }
        }
        
    }
}
