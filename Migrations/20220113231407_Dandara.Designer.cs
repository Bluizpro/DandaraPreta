﻿// <auto-generated />
using System;
using Dandara2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dandara2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220113231407_Dandara")]
    partial class Dandara
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dandara2.Models.CadastroVendedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CadastroVendedor");
                });

            modelBuilder.Entity("Dandara2.Models.ClienteCadastro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CartaoCredito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ClienteCadastro");
                });

            modelBuilder.Entity("Dandara2.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condicoesdepagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricaoproduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<string>("categoriaa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoriab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoriac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoriad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoriae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoriag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicaoeentrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contatovendendor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datavalidade")
                        .HasColumnType("datetime2");

                    b.Property<double>("moeda")
                        .HasColumnType("float");

                    b.Property<string>("tamanho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videodosprodutos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
