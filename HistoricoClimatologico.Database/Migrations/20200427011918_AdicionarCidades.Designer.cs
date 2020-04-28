﻿// <auto-generated />
using System;
using HistoricoClimatologico.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HistoricoClimatologico.Database.Migrations
{
    [DbContext(typeof(HistoricoClimatologicoContext))]
    [Migration("20200427011918_AdicionarCidades")]
    partial class AdicionarCidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("HistoricoClimatologico.Database.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Porto Velho"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Manaus"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Rio Branco"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Campo Grande"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Macapá"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Brasília"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Boa Vista"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Cuiabá"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Palmas"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Teresina"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Belém"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "São Luís"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Goiânia"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Salvador[nota 1]"
                        },
                        new
                        {
                            Id = 17,
                            Nome = "Maceió"
                        },
                        new
                        {
                            Id = 18,
                            Nome = "Porto Alegre"
                        },
                        new
                        {
                            Id = 19,
                            Nome = "Curitiba"
                        },
                        new
                        {
                            Id = 20,
                            Nome = "Florianópolis"
                        },
                        new
                        {
                            Id = 21,
                            Nome = "Belo Horizonte"
                        },
                        new
                        {
                            Id = 22,
                            Nome = "Fortaleza"
                        },
                        new
                        {
                            Id = 23,
                            Nome = "Recife"
                        },
                        new
                        {
                            Id = 24,
                            Nome = "João Pessoa"
                        },
                        new
                        {
                            Id = 25,
                            Nome = "Aracaju"
                        },
                        new
                        {
                            Id = 26,
                            Nome = "Natal"
                        },
                        new
                        {
                            Id = 27,
                            Nome = "Vitória"
                        });
                });

            modelBuilder.Entity("HistoricoClimatologico.Database.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Base")
                        .HasColumnType("TEXT");

                    b.Property<int>("CodigoCidade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Data")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCidade")
                        .HasColumnType("TEXT");

                    b.Property<float>("Temperatura")
                        .HasColumnType("REAL");

                    b.Property<int>("Timezone")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Umidade")
                        .HasColumnType("REAL");

                    b.Property<int>("Visibilidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Historico");
                });
#pragma warning restore 612, 618
        }
    }
}
