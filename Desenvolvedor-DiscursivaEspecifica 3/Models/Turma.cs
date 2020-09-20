using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvedor_DiscursivaEspecifica_3.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Nome { get; set; }
        public List<Bloco> Blocos { get; set; }
    }
}
