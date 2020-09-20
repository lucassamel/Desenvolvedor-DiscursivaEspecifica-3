﻿// <auto-generated />
using System;
using Desenvolvedor_DiscursivaEspecifica_3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desenvolvedor_DiscursivaEspecifica_3.Migrations
{
    [DbContext(typeof(Desenvolvedor_DiscursivaEspecifica_3Context))]
    partial class Desenvolvedor_DiscursivaEspecifica_3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Bloco", b =>
                {
                    b.Property<int>("BlocoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("BlocoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Bloco");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlocoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("BlocoId");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Turma", b =>
                {
                    b.Property<int>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurmaId");

                    b.HasIndex("CursoId");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Bloco", b =>
                {
                    b.HasOne("Desenvolvedor_DiscursivaEspecifica_3.Models.Turma", null)
                        .WithMany("Blocos")
                        .HasForeignKey("TurmaId");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Disciplina", b =>
                {
                    b.HasOne("Desenvolvedor_DiscursivaEspecifica_3.Models.Bloco", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("BlocoId");
                });

            modelBuilder.Entity("Desenvolvedor_DiscursivaEspecifica_3.Models.Turma", b =>
                {
                    b.HasOne("Desenvolvedor_DiscursivaEspecifica_3.Models.Curso", null)
                        .WithMany("Turmas")
                        .HasForeignKey("CursoId");
                });
#pragma warning restore 612, 618
        }
    }
}