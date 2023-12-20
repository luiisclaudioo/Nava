using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public  class Atividade : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EstaConcluida { get; set; }
    }
}
