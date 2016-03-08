using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Conta
    {
        public int IdConta { get; set; }
        public Cliente Cliente { get; set; }
        public double Limite { get; set; }
        private double saldoDevedor;
       
        public IList<Pagamento> Pagamentos { get; set; }

        public Conta()
        {
            Pagamentos = new List<Pagamento>();
        }

        public double SaldoDevedor { 
        get 
        {
            return saldoDevedor;
        }}

        public bool RegistraDebito(double valor)
        {
            if (saldoDevedor + valor > Limite)
                return false;
            else
            {
                saldoDevedor += valor;
                return true;
            }
        }


    }
}
