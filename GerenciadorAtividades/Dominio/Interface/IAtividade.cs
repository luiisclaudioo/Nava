﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IAtividade
    {
        int Id { get; set; }
        string Nome { get; set; }
        bool EstaConcluida { get; set; }
    }
}
