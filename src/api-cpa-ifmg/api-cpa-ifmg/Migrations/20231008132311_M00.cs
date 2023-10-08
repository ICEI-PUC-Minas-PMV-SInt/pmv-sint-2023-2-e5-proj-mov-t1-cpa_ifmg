using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cpa_ifmg.Migrations
{
    /// <inheritdoc />
    public partial class M00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area_Atuacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eixo_Tecnologico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proposta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campus_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cronograma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoDasAtividades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    ResponsavelCronograma = table.Column<int>(type: "int", nullable: false),
                    Data_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Termino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Procedimentos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cronograma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cronograma_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Membros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Portaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Representação = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Termino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Membros_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metas e Ações",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Termino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Atividade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsavel = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metas e Ações", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metas e Ações_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciclo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ano = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciclo_Questionario_QuestionarioId",
                        column: x => x.QuestionarioId,
                        principalTable: "Questionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avaliacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indicador_Questionario_QuestionarioId",
                        column: x => x.QuestionarioId,
                        principalTable: "Questionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampusCurso",
                columns: table => new
                {
                    CampusId = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusCurso", x => new { x.CampusId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_CampusCurso_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampusCurso_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eixo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoDoEixo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CicloId = table.Column<int>(type: "int", nullable: false),
                    QuestionarioId = table.Column<int>(type: "int", nullable: false),
                    CicloId1 = table.Column<int>(type: "int", nullable: true),
                    QuestionarioId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eixo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eixo_Ciclo_CicloId",
                        column: x => x.CicloId,
                        principalTable: "Ciclo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Eixo_Ciclo_CicloId1",
                        column: x => x.CicloId1,
                        principalTable: "Ciclo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Eixo_Questionario_QuestionarioId",
                        column: x => x.QuestionarioId,
                        principalTable: "Questionario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Eixo_Questionario_QuestionarioId1",
                        column: x => x.QuestionarioId1,
                        principalTable: "Questionario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dimensão",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaodaDimensao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EixoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensão", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensão_Eixo_EixoId",
                        column: x => x.EixoId,
                        principalTable: "Eixo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Melhorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropostaDeMelhoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DimensaoId = table.Column<int>(type: "int", nullable: false),
                    PropostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melhorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Melhorias_Dimensão_DimensaoId",
                        column: x => x.DimensaoId,
                        principalTable: "Dimensão",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Melhorias_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campus_PropostaId",
                table: "Campus",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_CampusCurso_CursoId",
                table: "CampusCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclo_QuestionarioId",
                table: "Ciclo",
                column: "QuestionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Cronograma_PropostaId",
                table: "Cronograma",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensão_EixoId",
                table: "Dimensão",
                column: "EixoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eixo_CicloId",
                table: "Eixo",
                column: "CicloId");

            migrationBuilder.CreateIndex(
                name: "IX_Eixo_CicloId1",
                table: "Eixo",
                column: "CicloId1");

            migrationBuilder.CreateIndex(
                name: "IX_Eixo_QuestionarioId",
                table: "Eixo",
                column: "QuestionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Eixo_QuestionarioId1",
                table: "Eixo",
                column: "QuestionarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Indicador_QuestionarioId",
                table: "Indicador",
                column: "QuestionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Melhorias_DimensaoId",
                table: "Melhorias",
                column: "DimensaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Melhorias_PropostaId",
                table: "Melhorias",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Membros_PropostaId",
                table: "Membros",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas e Ações_PropostaId",
                table: "Metas e Ações",
                column: "PropostaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusCurso");

            migrationBuilder.DropTable(
                name: "Cronograma");

            migrationBuilder.DropTable(
                name: "Indicador");

            migrationBuilder.DropTable(
                name: "Melhorias");

            migrationBuilder.DropTable(
                name: "Membros");

            migrationBuilder.DropTable(
                name: "Metas e Ações");

            migrationBuilder.DropTable(
                name: "Campus");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Dimensão");

            migrationBuilder.DropTable(
                name: "Proposta");

            migrationBuilder.DropTable(
                name: "Eixo");

            migrationBuilder.DropTable(
                name: "Ciclo");

            migrationBuilder.DropTable(
                name: "Questionario");
        }
    }
}
