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
        enum OpcesMenu
        {
            CadastrarAtividades = 1,
            ExibirAtividadeCadastrada = 2,
            EditarAtividadeCadastrada = 3,
            ExcluirAtividade = 4,
            BuscarAtividadePorNome = 5,
            Sair = 6
        }
        AtividadesController ac = new AtividadesController();
        public void ExibirMenu()
        {
            OpcesMenu opcao = OpcesMenu.Sair;
            do
            {

                Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("= 1- Cadastrar Atividade");
            Console.WriteLine("= 2- Listar Atividade");
            Console.WriteLine("= 3- Editar Atividade");
            Console.WriteLine("= 4- Excluir Atividade");
            Console.WriteLine("= 5- Buscar por nome");

            Console.WriteLine("= 6- Sair");
            Console.WriteLine("=============================");
            Console.Write("Digite sua opção: ");
                try
                {
                    opcao = (OpcesMenu)int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Valor invalido...");
                
                }

                switch (opcao)
                {
                    case OpcesMenu.CadastrarAtividades:
                        CadastrarAtividade();
                        break;
                    case OpcesMenu.ExibirAtividadeCadastrada:
                        ExibirAtividadesCadastradas();
                        break;
                    case OpcesMenu.EditarAtividadeCadastrada:
                        EditarAtividadeCadastrada();
                        break;
                    case OpcesMenu.ExcluirAtividade:
                        ExcluirAtividadeCadastrada();
                        break;
                    case OpcesMenu.BuscarAtividadePorNome:
                        BuscaAtividadePorNome();
                        break;
                    case OpcesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine("Opçao Invalida...");
                        break;
                }
                 
                Console.ReadKey();
            } while (opcao != OpcesMenu.Sair);
        }

        private void BuscaAtividadePorNome()
        {
            Console.WriteLine("Buscar Atividade pelo Nome");
            Console.Write("Digite o nome da atividade: ");
            List<Atividade> x = ac.BuscarPorNome(Console.ReadLine());
            if (x.Count > 0)
            {
                foreach (Atividade a in x)
                {
                    ExibirDetalhesAtividade(a);

                }
            }
            else
            {
                Console.WriteLine("Não ha atividades com esse nome ");
            }
        }

        private static void ExibirDetalhesAtividade(Atividade a)
        {
            Console.WriteLine("-Dados Atividade-");
            Console.WriteLine("id: " + a.AtividadeID);
            Console.WriteLine("Nome: " + a.Nome);
            Console.WriteLine("Ativo: " + a.Ativo);
            Console.WriteLine("--");
        }

        private void ExcluirAtividadeCadastrada()
        {
            Console.Clear();
            ExibirAtividadesCadastradas();
            Console.WriteLine("Excluir Atividades Cadastradas");
            Console.Write("Digite o ID da atividade a ser excluida: ");
            try
            {
                Atividade atividade = ac.BuscarPorID(int.Parse(Console.ReadLine()));
                if (atividade != null)
                {
                    ac.Excluir(atividade);
                    Console.Clear();
                    Console.WriteLine("--Atividade excluida comn sucesso!!--");
                }
                else
                    Console.WriteLine("Atividade não encontrada");
            }
            catch (Exception)
            {

                Console.WriteLine("Valor invalido...");
            }
           
        }

        private void EditarAtividadeCadastrada()
        {
            Atividade atividade = new Atividade();
            ExibirAtividadesCadastradas();
            Console.Write("Digite o ID da atividade a ser alterada: ");
           
            try
            {
                int id = int.Parse(Console.ReadLine());
                Atividade atividadeX = ac.BuscarPorID(id);
               
                if ( atividadeX != null)
                {
                    atividade.AtividadeID = id;
                    Console.Write("Digite novo nome: ");
                    atividade.Nome = Console.ReadLine();
                    Console.Write("Ativo? (s/n)");
                    atividade.Ativo = Console.ReadLine() == "s" ? true : false;
                    ac.Editar(atividade);
                    Console.Clear();
                    Console.WriteLine("--Atividade editada comn sucesso!!--");
                }
                else
                {
                    Console.WriteLine("ID não encontrado");
                }

               
            }
            catch (Exception)
            {

                Console.WriteLine("Valor invalido...");
                
            }


            

        }

        private void ExibirAtividadesCadastradas()
        {
            Console.WriteLine("--Exibindo atividades cadastradas -- ");
            foreach (Atividade a in ac.Listar())
            {
                ExibirDetalhesAtividade(a);


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
            Console.Clear();
            Console.WriteLine("--Atividade cadastrada comn sucesso!!--");
        }
    }
}
