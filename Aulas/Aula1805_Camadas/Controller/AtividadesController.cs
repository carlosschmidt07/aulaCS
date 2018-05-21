using Aula1805_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1805_Camadas.Controller
{
    class AtividadesController
    {
        List<Atividade> minhasAtividades = new List<Atividade>();
        public int ultimoIdUtilizado { get; private set; }
        public AtividadesController()
        {
            ultimoIdUtilizado = 0;
        }
        public void Salvar(Atividade atividade)
        {
            ultimoIdUtilizado++;
            atividade.AtividadeID = ultimoIdUtilizado;
            minhasAtividades.Add(atividade);
        }

        public List<Atividade> Listar()
        {
            return minhasAtividades;
        }
        public void Editar(Atividade novaAtividade)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if (a.AtividadeID == novaAtividade.AtividadeID)
                {
                    a.Nome = novaAtividade.Nome;
                    a.Ativo = novaAtividade.Ativo;
                }
            }
        }
        public void Excluir(Atividade atividade)
        {
            minhasAtividades.Remove(atividade);
        }
        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if (a.AtividadeID == id)
                {
                    return a;
                }
            }

            return null;

        }
        public Atividade BuscarPorNome(string nome)
        {
            foreach ( Atividade a in  minhasAtividades)
            {
                if (a.Nome.Equals(nome))
                {
                    return a;
                }
            }
            return null;
        }
    }

}
