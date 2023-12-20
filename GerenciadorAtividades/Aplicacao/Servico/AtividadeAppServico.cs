using Aplicacao.Interface;
using Aplicacao.Servico.Interface;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class AtividadeAppServico : IAtividadeAppServico
    {
        private readonly IAtividadeServico atividadeServico;

        public AtividadeAppServico(IAtividadeServico atividadeService)
        {
            this.atividadeServico = atividadeService;
        }

        public void MarcarAtividadeConcluida(string nomeLista, int idAtividade)
        {
            atividadeServico.MarcarAtividadeConcluida(nomeLista,idAtividade);
        }

        public Dictionary<string, List<IAtividade>> ExibirListasEAtividades()
        {
            return atividadeServico.ExibirListasEAtividades();
        }
    }
}
