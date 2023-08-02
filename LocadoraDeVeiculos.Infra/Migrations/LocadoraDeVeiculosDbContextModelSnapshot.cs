﻿// <auto-generated />
using System;
using LocadoraDeVeiculos.Infra.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Migrations
{
    [DbContext(typeof(LocadoraDeVeiculosDbContext))]
    partial class LocadoraDeVeiculosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Alugado")
                        .HasColumnType("bit");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeDeCombustivel")
                        .HasColumnType("int");

                    b.Property<int>("Combustivel")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("GrupoAutomovelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Quilometragem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoAutomovelId");

                    b.ToTable("TBAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Documento do Cliente");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Telefone");

                    b.Property<string>("TipoCliente")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Tipo de Cliente");

                    b.HasKey("Id");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<Guid>("ParceiroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ParceiroId");

                    b.ToTable("TBCupom", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TBGrupoAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloParceiro.Parceiro", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TBParceiro", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloTaxaServico.TaxaServico", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<int>("TipoCalculo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TBTaxaServico", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", "GrupoAutomovel")
                        .WithMany()
                        .HasForeignKey("GrupoAutomovelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("LocadoraDeVeiculos.Dominio.ModuloAutomovel.ImagemVeiculo", "Foto", b1 =>
                        {
                            b1.Property<Guid>("AutomovelId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<byte[]>("ImagemBytes")
                                .IsRequired()
                                .HasColumnType("varbinary(max)");

                            b1.Property<string>("NomeArquivo")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AutomovelId");

                            b1.ToTable("TBAutomovel");

                            b1.WithOwner()
                                .HasForeignKey("AutomovelId");
                        });

                    b.Navigation("Foto")
                        .IsRequired();

                    b.Navigation("GrupoAutomovel");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.OwnsOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("varchar(100)")
                                .HasColumnName("Bairro");

                            b1.Property<string>("Cep")
                                .IsRequired()
                                .HasColumnType("varchar(30)")
                                .HasColumnName("CEP");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("varchar(30)")
                                .HasColumnName("Cidade");

                            b1.Property<string>("Complemento")
                                .IsRequired()
                                .HasColumnType("varchar(30)")
                                .HasColumnName("Complemento");

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasColumnType("varchar(30)")
                                .HasColumnName("Estado");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnType("varchar(250)")
                                .HasColumnName("Logradouro");

                            b1.Property<int>("Numero")
                                .HasColumnType("int")
                                .HasColumnName("Número");

                            b1.HasKey("ClienteId");

                            b1.ToTable("TBCliente");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("Endereco")
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloParceiro.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("ParceiroId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parceiro");
                });
#pragma warning restore 612, 618
        }
    }
}
