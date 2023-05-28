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
    [Migration("20221004015252_addFieldsTranscription")]
    partial class addFieldsTranscription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Loba.Domain.Entities.TranscribeEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("caminhoArquivo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("dataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("excluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("extensaoArquivo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("hexaArquivo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("idiomaTranscricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nomeArquivo")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("tempoAudio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Arquivo");

                    b.HasData(
                        new
                        {
                            id = -1,
                            caminhoArquivo = "c:\\teste\\teste",
                            dataAlteracao = new DateTime(2022, 10, 3, 22, 52, 52, 365, DateTimeKind.Local).AddTicks(8605),
                            excluido = false,
                            extensaoArquivo = ".wav",
                            idiomaTranscricao = "pt-BR",
                            nomeArquivo = "PrimeiroArquivo",
                            tempoAudio = "1:00:10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}