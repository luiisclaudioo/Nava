using Aplicacao.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorAtividades.Controllers
{
    [ApiController]
    [Route("api/atividades")]
    public class AtividadeController : ControllerBase
    {
        private readonly IAtividadeAppServico atividadeAppServico;

        public AtividadeController(IAtividadeAppServico atividadeAppServico)
        {
            this.atividadeAppServico = atividadeAppServico;
        }

        [HttpGet]
        public IActionResult GetListasEAtividades()
        {
            var listasDeAtividades = atividadeAppServico.ExibirListasEAtividades();
                        
            return Ok(listasDeAtividades);
        }

        [HttpPost("{nomeLista}/{idAtividade}/concluir")]
        public IActionResult ConcluirAtividade(string nomeLista, int idAtividade)
        {
            atividadeAppServico.MarcarAtividadeConcluida(nomeLista, idAtividade);
            return Ok($"Atividade com ID {idAtividade} na lista '{nomeLista}' concluída.");
        }
    }
}
