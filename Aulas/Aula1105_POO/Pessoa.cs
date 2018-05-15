using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
  abstract  class Pessoa
    {
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public Pessoa()
        {

        }
        public Pessoa( string nome)
        {
            Nome = nome;
        }
        public abstract string ShowInfoPessoa();
    }
   
}
