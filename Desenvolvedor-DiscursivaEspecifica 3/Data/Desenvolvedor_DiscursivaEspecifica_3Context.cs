using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desenvolvedor_DiscursivaEspecifica_3.Models;

namespace Desenvolvedor_DiscursivaEspecifica_3.Data
{
    public class Desenvolvedor_DiscursivaEspecifica_3Context : DbContext
    {
        public Desenvolvedor_DiscursivaEspecifica_3Context (DbContextOptions<Desenvolvedor_DiscursivaEspecifica_3Context> options)
            : base(options)
        {
        }

        public DbSet<Desenvolvedor_DiscursivaEspecifica_3.Models.Disciplina> Disciplina { get; set; }

        public DbSet<Desenvolvedor_DiscursivaEspecifica_3.Models.Bloco> Bloco { get; set; }

        public DbSet<Desenvolvedor_DiscursivaEspecifica_3.Models.Turma> Turma { get; set; }

        public DbSet<Desenvolvedor_DiscursivaEspecifica_3.Models.Curso> Curso { get; set; }
    }
}
