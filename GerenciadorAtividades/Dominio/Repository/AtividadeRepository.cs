using Aplicacao.Servico;
using Aplicacao.Servico.Interface;
using Dominio.Entidade;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private static AtividadeRepository _instancia;
        private Dictionary<string, List<IAtividade>> listasDeAtividades;

        public AtividadeRepository()
        {
            listasDeAtividades = new Dictionary<string, List<IAtividade>>
            {
                {"Trabalho" , new List<IAtividade> {new Atividade { Id = 1, Nome = "Reunião", EstaConcluida = false } } },
                {"Estudo", new List<IAtividade> { new Atividade { Id = 2, Nome = "Ler Livro", EstaConcluida = false } } }
            };
        }

        public static AtividadeRepository Instacia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new AtividadeRepository();

                return _instancia;
            }
        }

        public void MarcarAtividadeConcluida(string nomeLista, int idAtividade)
        {
            if (listasDeAtividades.TryGetValue(nomeLista, out var lista))
            {
                var atividade = lista.FirstOrDefault(a => a.Id == idAtividade);
                if (atividade != null)
                {
                    atividade.EstaConcluida = true;
                    // Atividae concluida
                }
                else
                {
                    // Atividade não concluida
                }
            }
            else
            {
                // Lista não encontrada
            }
        }

        public Dictionary<string, List<IAtividade>> ExibirListasEAtividades()
        {
            //foreach (var lista in listasDeAtividades)
            //{
            //    Console.WriteLine($"Lista: {lista.Key}");
            //    foreach (var atividade in lista.Value)
            //    {
            //        Console.WriteLine($"  - Atividade: {atividade.Nome} (Concluída: {atividade.EstaConcluida})");
            //    }
            //}     

            return listasDeAtividades;
        }
    }
}
