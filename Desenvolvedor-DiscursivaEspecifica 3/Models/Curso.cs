using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvedor_DiscursivaEspecifica_3.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }
    }
}
