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
    [Migration("20221030171956_addcampoconteudotranscricao")]
    partial class addcampoconteudotranscricao
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

                    b.Property<string>("textoTranscricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("AtaTexto");

                    b.HasData(
                        new
                        {
                            id = -1,
                            caminho = "c:\\teste\\teste",
                            dataAlteracao = new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(5666),
                            excluido = false,
                            nome = "PrimeiroArquivo",
                            tamanho = "50mb",
                            textoTranscricao = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
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
                            dataAlteracao = new DateTime(2022, 10, 30, 14, 19, 55, 966, DateTimeKind.Local).AddTicks(4408),
                            duracao = "1:00:10",
                            excluido = false,
                            nome = "PrimeiroArquivo"
                        });
                });

            modelBuilder.Entity("Loba.Domain.Entities.UsuarioAudioTextoEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("idArquivoAudio")
                        .HasColumnType("int");

                    b.Property<int>("idArquivoTexto")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UsuarioAudioTextoEntity");

                    b.HasData(
                        new
                        {
                            id = -1,
                            dataAlteracao = new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(8328),
                            excluido = false,
                            idArquivoAudio = -1,
                            idArquivoTexto = -1,
                            idUsuario = -1
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
                            dataAlteracao = new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(7232),
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
