﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.Nome = "Godofredo";
            Console.WriteLine("Aluno: " + a.Nome);
            
        }
    }
}