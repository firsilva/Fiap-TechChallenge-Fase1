﻿// <auto-generated />
using System;
using Fiap.TechChallenge.Fase1.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fiap.TechChallenge.Fase1.Data.Migrations
{
    [DbContext(typeof(ContextTechChallenge))]
    [Migration("20240515014622_Alterando_Tipo_Coluna_Role_Usuario")]
    partial class Alterando_Tipo_Coluna_Role_Usuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Data.Entidades.Contato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("DDD")
                        .HasColumnType("INT")
                        .HasColumnName("ddd");

                    b.Property<DateTime>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("email");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(9)")
                        .HasColumnName("telefone");

                    b.HasKey("Id")
                        .HasName("pk_contato");

                    b.ToTable("contato", (string)null);
                });

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Data.Entidades.DDDRegiao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("DDD")
                        .HasColumnType("INT")
                        .HasColumnName("ddd");

                    b.Property<DateTime>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("estado");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Regiao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("regiao");

                    b.HasKey("Id")
                        .HasName("pk_regiao");

                    b.ToTable("regiao", (string)null);
                });

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Data.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("email");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.Property<short>("Role")
                        .HasColumnType("SMALLINT")
                        .HasColumnName("role");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("senha");

                    b.HasKey("Id")
                        .HasName("pk_usuario");

                    b.ToTable("usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
