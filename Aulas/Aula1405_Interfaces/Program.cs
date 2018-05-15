using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Onibus b = new Onibus();
            Carro c = new Carro();
            Console.WriteLine("Carro Criado, velocidade inicial: "+ c.Velocidade);
            c.Acelerar();
            c.Acelerar();
            AcelerarBastante(c);

            Console.WriteLine("Carro Velocidade atual: "+ c.Velocidade);
            AcelerarBastante(b);

            Console.WriteLine("Onibus Velocidade atual: "+ b.Velocidade);
            string nome = c._Marca.Nome;

            Console.ReadKey();

            
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
