using System;
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
            a.Cpf = "12345678909";
            a.Matricula = "54321";

            Console.WriteLine(a.ShowInfoPessoa()); 
            //Console.WriteLine("Aluno: " + a.Nome);
            Console.ReadKey();
            
        }
    }
} 
