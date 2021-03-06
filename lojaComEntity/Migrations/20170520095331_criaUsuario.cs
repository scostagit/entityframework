using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace lojaComEntity.Migrations
{
    public partial class criaUsuario : Migration
    {
        //O metodo up criar as tabelas e faz a altera��o
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        //o metodo faz o drop database.
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Usuario");
        }
    }
}
