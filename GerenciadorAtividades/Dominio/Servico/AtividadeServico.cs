using Aplicacao.Servico.Interface;
using Dominio.Interface;
using Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class AtividadeServico : IAtividadeServico
    {
        private readonly IAtividadeRepository atividadeRepository;

        public AtividadeServico(IAtividadeRepository atividadeRepository)
        {
            this.atividadeRepository = atividadeRepository;
        }

        public void MarcarAtividadeConcluida(string nomeLista, int idAtividade)
        {            
            atividadeRepository.MarcarAtividadeConcluida(nomeLista, idAtividade);
        }

        public Dictionary<string, List<IAtividade>> ExibirListasEAtividades()
        {
            return atividadeRepository.ExibirListasEAtividades();
        }
    }
}
