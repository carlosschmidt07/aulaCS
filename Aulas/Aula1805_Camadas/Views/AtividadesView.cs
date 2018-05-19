using Aula1805_Camadas.Controller;
using Aula1805_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1805_Camadas.Views
{
    class AtividadesView
    {
        AtividadesController ac = new AtividadesController();
        public void ExibirMenu()
        {
            int opcao = 6;
            do
            {

                Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("= 1- Cadastrar Atividade");
            Console.WriteLine("= 2- Listar Atividade");
            Console.WriteLine("= 3- Editar Atividade");
            Console.WriteLine("= 4- Excluir Atividade");
            Console.WriteLine("= 6- Sair");
            Console.WriteLine("=============================");
            Console.Write("Digite sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                    case 1:
                        CadastrarAtividade();
                        break;

                    case 2:
                        ExibirAtividadesCadastradas();
                        break;
                    case 3:
                        EditarAtividadeCadastrada();

                        break;

                    case 4:
                        ExcluirAtividadeCadastrada();
                        break;
                    default:
                    break;
            }
                Console.ReadKey();
            } while (opcao !=6);
        }

        private void ExcluirAtividadeCadastrada()
        {
            Console.Clear();
            ExibirAtividadesCadastradas();
            Console.WriteLine("Excluir Atividades Cadastradas");
            Console.Write("Digite o ID da atividade a ser alterada: ");
            Atividade atividade = ac.BuscarPorID(int.Parse(Console.ReadLine()));
            if (atividade != null)
            {
                ac.Excluir(atividade);
            }else
                Console.WriteLine("Atividade não encontrada");
        }

        private void EditarAtividadeCadastrada()
        {
            Atividade atividade = new Atividade();
            ExibirAtividadesCadastradas();
            Console.Write("Digite o ID da atividade a ser alterada: ");
            atividade.AtividadeID = int.Parse(Console.ReadLine());
            Console.Write("Digite novo nome: ");
            atividade.Nome = Console.ReadLine();
            Console.Write("Ativo? (s/n)");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;
            ac.Editar(atividade);


        }

        private void ExibirAtividadesCadastradas()
        {
            Console.WriteLine("--Exibindo atividades cadastradas -- ");
            foreach (Atividade a in ac.Listar())
            {
                Console.WriteLine("-Dados Atividade-");
                Console.WriteLine("id: " + a.AtividadeID);
                Console.WriteLine("Nome: " + a.Nome);
                Console.WriteLine("Ativo: " + a.Ativo);
                Console.WriteLine("--");


            }
            Console.WriteLine("-- Fim da lista -- ");
        }

        private void CadastrarAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            ac.Salvar(atividade);
        }
    }
}
