using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_projetinho
{
    internal class ClienteVip : Cliente
    {
        protected double desconto;
        protected double cashback;
        public void exibirCashBack() { }
        public void calcularCashBack() { }
    }
}
