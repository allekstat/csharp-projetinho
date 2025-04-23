using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_projetinho
{
    internal class Pessoa
    {
        protected string nome;
        protected string email;
        public void exibirDados() { }
        public virtual void cadastrar() { }
    }
}
