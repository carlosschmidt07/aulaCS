using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno : Pessoa
    {
        
        private string matricula;


        public Aluno()
        {

        }
        public Aluno(string nome) : base(nome)
        {
            Nome = nome;
        }

        public string Matricula { get => matricula; set => matricula = value; }

        public override string ShowInfoPessoa()
        {
            return "Aluno: " + Nome + ", CPF: " + Cpf + ", Matricula: " + Matricula;
        }
    }
}
