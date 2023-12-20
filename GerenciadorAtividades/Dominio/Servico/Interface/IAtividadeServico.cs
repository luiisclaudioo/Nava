using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Interface
{
    public interface IAtividadeServico
    {
        void MarcarAtividadeConcluida(string nomeLista, int idAtividade);
        Dictionary<string, List<IAtividade>> ExibirListasEAtividades();
    }
}
