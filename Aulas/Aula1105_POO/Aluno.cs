﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno : Pessoa
    {
        private string nome;


        public Aluno()
        {

        }
        public Aluno(string nome) : base(nome)
        {
            Nome = nome;
        }

    }
}
