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
    [Migration("20200427014247_AdicionarCodigoCidades")]
    partial class AdicionarCodigoCidades
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

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "3662762",
                            Nome = "Porto Velho"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "3663517",
                            Nome = "Manaus"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "3662574",
                            Nome = "Rio Branco"
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "3467747",
                            Nome = "Campo Grande"
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "3396016",
                            Nome = "Macapá"
                        },
                        new
                        {
                            Id = 6,
                            Codigo = "3469058",
                            Nome = "Brasília"
                        },
                        new
                        {
                            Id = 7,
                            Codigo = "3469745",
                            Nome = "Boa Vista"
                        },
                        new
                        {
                            Id = 8,
                            Codigo = "3465038",
                            Nome = "Cuiabá"
                        },
                        new
                        {
                            Id = 9,
                            Codigo = "3455459",
                            Nome = "Palmas"
                        },
                        new
                        {
                            Id = 10,
                            Codigo = "3386496",
                            Nome = "Teresina"
                        },
                        new
                        {
                            Id = 11,
                            Codigo = "3448439",
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = 12,
                            Codigo = "3451189",
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 13,
                            Codigo = "3405863",
                            Nome = "Belém"
                        },
                        new
                        {
                            Id = 14,
                            Codigo = "3388368",
                            Nome = "São Luís"
                        },
                        new
                        {
                            Id = 15,
                            Codigo = "3462377",
                            Nome = "Goiânia"
                        },
                        new
                        {
                            Id = 16,
                            Codigo = "3450554",
                            Nome = "Salvador"
                        },
                        new
                        {
                            Id = 17,
                            Codigo = "6320645",
                            Nome = "Maceió"
                        },
                        new
                        {
                            Id = 18,
                            Codigo = "3452925",
                            Nome = "Porto Alegre"
                        },
                        new
                        {
                            Id = 19,
                            Codigo = "3464975",
                            Nome = "Curitiba"
                        },
                        new
                        {
                            Id = 20,
                            Codigo = "6323121",
                            Nome = "Florianópolis"
                        },
                        new
                        {
                            Id = 21,
                            Codigo = "2270968",
                            Nome = "Belo Horizonte"
                        },
                        new
                        {
                            Id = 22,
                            Codigo = "3399415",
                            Nome = "Fortaleza"
                        },
                        new
                        {
                            Id = 23,
                            Codigo = "3390760",
                            Nome = "Recife"
                        },
                        new
                        {
                            Id = 24,
                            Codigo = "3397277",
                            Nome = "João Pessoa"
                        },
                        new
                        {
                            Id = 25,
                            Codigo = "3471872",
                            Nome = "Aracaju"
                        },
                        new
                        {
                            Id = 26,
                            Codigo = "3394023",
                            Nome = "Natal"
                        },
                        new
                        {
                            Id = 27,
                            Codigo = "3444924",
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