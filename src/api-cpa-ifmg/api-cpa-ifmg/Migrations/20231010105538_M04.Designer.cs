﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_cpa_ifmg.Models;

#nullable disable

namespace api_cpa_ifmg.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231010105538_M04")]
    partial class M04
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api_cpa_ifmg.Models.Campus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropostaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.CampusCurso", b =>
                {
                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasKey("CampusId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("CampusCurso");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Ciclo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Ano")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionarioId");

                    b.ToTable("Ciclo");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Cronograma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Termino")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoDasAtividades")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procedimentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropostaId")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelCronograma")
                        .HasColumnType("int");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Cronograma");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Area_Atuacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eixo_Tecnologico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Dimensao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescricaodaDimensao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EixoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EixoId");

                    b.ToTable("Dimensão");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Eixo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CicloId")
                        .HasColumnType("int");

                    b.Property<int?>("CicloId1")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoDoEixo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionarioId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionarioId1")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CicloId");

                    b.HasIndex("CicloId1");

                    b.HasIndex("QuestionarioId");

                    b.HasIndex("QuestionarioId1");

                    b.ToTable("Eixo");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Indicador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avaliacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionarioId");

                    b.ToTable("Indicador");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Melhoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DimensaoId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropostaDeMelhoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropostaId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DimensaoId");

                    b.HasIndex("PropostaId");

                    b.ToTable("Melhorias");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Termino")
                        .HasColumnType("datetime2");

                    b.Property<int>("Funcao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Portaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropostaId")
                        .HasColumnType("int");

                    b.Property<string>("Representação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Membros");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Atividade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Termino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropostaId")
                        .HasColumnType("int");

                    b.Property<int>("Responsavel")
                        .HasColumnType("int");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Metas e Ações");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Proposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Questionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Questionario");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Campus", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Proposta", "Proposta")
                        .WithMany("Campi")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.CampusCurso", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Campus", "Campus")
                        .WithMany("Cursos")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cpa_ifmg.Models.Curso", "Curso")
                        .WithMany("Campi")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campus");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Ciclo", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Questionario", "Questionario")
                        .WithMany("Ciclos")
                        .HasForeignKey("QuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questionario");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Cronograma", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Proposta", "Proposta")
                        .WithMany("Cronogramas")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Dimensao", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Eixo", "Eixo")
                        .WithMany("Dimensoes")
                        .HasForeignKey("EixoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eixo");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Eixo", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Ciclo", "Ciclo")
                        .WithMany()
                        .HasForeignKey("CicloId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("api_cpa_ifmg.Models.Ciclo", null)
                        .WithMany("Eixos")
                        .HasForeignKey("CicloId1");

                    b.HasOne("api_cpa_ifmg.Models.Questionario", "Questionario")
                        .WithMany()
                        .HasForeignKey("QuestionarioId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("api_cpa_ifmg.Models.Questionario", null)
                        .WithMany("Eixos")
                        .HasForeignKey("QuestionarioId1");

                    b.Navigation("Ciclo");

                    b.Navigation("Questionario");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Indicador", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Questionario", "Questionario")
                        .WithMany("Indicadores")
                        .HasForeignKey("QuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questionario");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Melhoria", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Dimensao", "Dimensao")
                        .WithMany("Melhorias")
                        .HasForeignKey("DimensaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cpa_ifmg.Models.Proposta", "Proposta")
                        .WithMany("Melhorias")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dimensao");

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Membro", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Proposta", "Proposta")
                        .WithMany("Membros")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Meta", b =>
                {
                    b.HasOne("api_cpa_ifmg.Models.Proposta", "Proposta")
                        .WithMany("Metas")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Campus", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Ciclo", b =>
                {
                    b.Navigation("Eixos");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Curso", b =>
                {
                    b.Navigation("Campi");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Dimensao", b =>
                {
                    b.Navigation("Melhorias");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Eixo", b =>
                {
                    b.Navigation("Dimensoes");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Proposta", b =>
                {
                    b.Navigation("Campi");

                    b.Navigation("Cronogramas");

                    b.Navigation("Melhorias");

                    b.Navigation("Membros");

                    b.Navigation("Metas");
                });

            modelBuilder.Entity("api_cpa_ifmg.Models.Questionario", b =>
                {
                    b.Navigation("Ciclos");

                    b.Navigation("Eixos");

                    b.Navigation("Indicadores");
                });
#pragma warning restore 612, 618
        }
    }
}
