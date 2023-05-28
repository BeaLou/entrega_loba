﻿// <auto-generated />
using System;
using Loba.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Loba.Infrastructure.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221011011827_addTBusuario")]
    partial class addTBusuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Loba.Domain.Entities.AtaEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("caminho")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("dataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("tamanho")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("AtaTexto");

                    b.HasData(
                        new
                        {
                            id = -1,
                            caminho = "c:\\teste\\teste",
                            dataAlteracao = new DateTime(2022, 10, 10, 22, 18, 26, 833, DateTimeKind.Local).AddTicks(1930),
                            excluido = false,
                            nome = "PrimeiroArquivo",
                            tamanho = "50mb"
                        });
                });

            modelBuilder.Entity("Loba.Domain.Entities.TranscribeEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("caminho")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("dataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("duracao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("TranscricaoAudio");

                    b.HasData(
                        new
                        {
                            id = -1,
                            caminho = "c:\\teste\\teste",
                            dataAlteracao = new DateTime(2022, 10, 10, 22, 18, 26, 831, DateTimeKind.Local).AddTicks(8359),
                            duracao = "1:00:10",
                            excluido = false,
                            nome = "PrimeiroArquivo"
                        });
                });

            modelBuilder.Entity("Loba.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            id = -1,
                            dataAlteracao = new DateTime(2022, 10, 10, 22, 18, 26, 833, DateTimeKind.Local).AddTicks(3843),
                            email = "bea@bea.com",
                            excluido = false,
                            nome = "Bea",
                            senha = "123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
