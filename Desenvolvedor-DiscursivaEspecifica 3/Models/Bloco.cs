﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvedor_DiscursivaEspecifica_3.Models
{
    public class Bloco
    {
        public int BlocoId { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}
