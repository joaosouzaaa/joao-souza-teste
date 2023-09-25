﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaComercial.API.Infra.Context;

#nullable disable

namespace SistemaComercial.API.Migrations
{
    [DbContext(typeof(SistemaComercialDbContext))]
    partial class SistemaComercialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaComercial.API.Entities.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("valor_unitario");

                    b.HasKey("Codigo");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Codigo = 1,
                            Nome = "produto aleatorio",
                            ValorUnitario = 10m
                        },
                        new
                        {
                            Codigo = 2,
                            Nome = "produto 2",
                            ValorUnitario = 30m
                        },
                        new
                        {
                            Codigo = 3,
                            Nome = "sabonete",
                            ValorUnitario = 2m
                        },
                        new
                        {
                            Codigo = 4,
                            Nome = "ventilador",
                            ValorUnitario = 90m
                        });
                });

            modelBuilder.Entity("SistemaComercial.API.Entities.ProdutoVenda", b =>
                {
                    b.Property<int>("CodigoProdutoVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoProdutoVenda"));

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal (5, 2)")
                        .HasColumnName("desconto");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("ValorProduto")
                        .HasColumnType("decimal (18, 2)")
                        .HasColumnName("valor_produto");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal (18, 2)")
                        .HasColumnName("valor_total");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("CodigoProdutoVenda");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ProdutosVenda");
                });

            modelBuilder.Entity("SistemaComercial.API.Entities.Venda", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime")
                        .HasColumnName("data");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("valor_total");

                    b.HasKey("Numero");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("SistemaComercial.API.Entities.ProdutoVenda", b =>
                {
                    b.HasOne("SistemaComercial.API.Entities.Produto", "Produto")
                        .WithMany("ProdutosVenda")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercial.API.Entities.Venda", "Venda")
                        .WithMany("Produtos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("SistemaComercial.API.Entities.Produto", b =>
                {
                    b.Navigation("ProdutosVenda");
                });

            modelBuilder.Entity("SistemaComercial.API.Entities.Venda", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}