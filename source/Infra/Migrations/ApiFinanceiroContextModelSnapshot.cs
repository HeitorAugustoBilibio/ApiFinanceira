﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(ApiFinanceiroContext))]
    partial class ApiFinanceiroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entidades.CategoriaMovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int>("TipoMovimentacaoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TipoMovimentacaoId");

                    b.ToTable("CategoriaMovis");
                });

            modelBuilder.Entity("Domain.Entidades.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Lançamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumeroParcela")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Pagamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("QuantidadeParcela")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoMovimentacaoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorJuros")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("TipoMovimentacaoId");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("Domain.Entidades.TipoMovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Entrada")
                        .HasColumnType("boolean");

                    b.Property<bool>("Saida")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("TipoMovimentacao");
                });

            modelBuilder.Entity("Domain.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cargo")
                        .HasColumnType("integer");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Entidades.CategoriaMovi", b =>
                {
                    b.HasOne("Domain.Entidades.TipoMovi", "TipoMovimentacao")
                        .WithMany()
                        .HasForeignKey("TipoMovimentacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMovimentacao");
                });

            modelBuilder.Entity("Domain.Entidades.Movimentacao", b =>
                {
                    b.HasOne("Domain.Entidades.TipoMovi", "TipoMovimentacao")
                        .WithMany()
                        .HasForeignKey("TipoMovimentacaoId");

                    b.Navigation("TipoMovimentacao");
                });
#pragma warning restore 612, 618
        }
    }
}
