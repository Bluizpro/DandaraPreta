using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dandara2.Migrations
{
    public partial class Dandara : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroVendedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroVendedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ClienteCadastro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartaoCredito = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteCadastro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    moeda = table.Column<double>(type: "float", nullable: false),
                    Condicoesdepagamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    condicaoeentrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videodosprodutos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tamanho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricaoproduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriaa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datavalidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contatovendendor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroVendedor");

            migrationBuilder.DropTable(
                name: "ClienteCadastro");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
