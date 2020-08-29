﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalFinance.WebApi.DAL;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200822224246_MudancaAuth")]
    partial class MudancaAuth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalFinance.WebApi.DAL.Usuarios.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = "ffc7f604-3550-4a44-910e-bc5a531019d3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5edda6eb-9ead-4bff-9402-99e779be5c4a",
                            Email = "admin@example.org",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAED0tb8N23CW0B1uLCmdSzL1kfJKD1NqSU6VxzkJ/ATsHW8awVv+bBSmNiACpNR9Iqw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "05b6d4b8-e5c1-477d-a4e4-000ae9646364",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Competencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<double>("ValorGanho")
                        .HasColumnType("float");

                    b.Property<double>("ValorGasto")
                        .HasColumnType("float");

                    b.Property<double>("ValorSobra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Competencia");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.ContaBancaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetenciaId")
                        .HasColumnType("int");

                    b.Property<string>("NomeBanco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rendimento")
                        .HasColumnType("float");

                    b.Property<double>("ValorConta")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompetenciaId");

                    b.ToTable("ContaBancaria");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.GanhoExtra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetenciaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompetenciaId");

                    b.ToTable("GanhoExtra");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Gastos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetenciaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataGasto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeConta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompetenciaId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Investimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetenciaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInvestimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeInvestimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rendimento")
                        .HasColumnType("float");

                    b.Property<double>("ValorInvestido")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompetenciaId");

                    b.ToTable("Investimentos");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Salario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetenciaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<double>("Desconto1")
                        .HasColumnType("float");

                    b.Property<double>("Desconto2")
                        .HasColumnType("float");

                    b.Property<double>("Imposto")
                        .HasColumnType("float");

                    b.Property<string>("OrigemGanho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorAdicional")
                        .HasColumnType("float");

                    b.Property<double>("ValorBruto")
                        .HasColumnType("float");

                    b.Property<double>("ValorLiquido")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompetenciaId");

                    b.ToTable("Salario");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Seguranca.LoginModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoginModel");
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.ContaBancaria", b =>
                {
                    b.HasOne("PersonalFinance.WebApi.Model.Competencia", "Competencia")
                        .WithMany("ContaBancaria")
                        .HasForeignKey("CompetenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.GanhoExtra", b =>
                {
                    b.HasOne("PersonalFinance.WebApi.Model.Competencia", "Competencia")
                        .WithMany("GanhoExtra")
                        .HasForeignKey("CompetenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Gastos", b =>
                {
                    b.HasOne("PersonalFinance.WebApi.Model.Competencia", "Competencia")
                        .WithMany("Gastos")
                        .HasForeignKey("CompetenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Investimentos", b =>
                {
                    b.HasOne("PersonalFinance.WebApi.Model.Competencia", "Competencia")
                        .WithMany("Investimentos")
                        .HasForeignKey("CompetenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalFinance.WebApi.Model.Salario", b =>
                {
                    b.HasOne("PersonalFinance.WebApi.Model.Competencia", "Competencia")
                        .WithMany("Salario")
                        .HasForeignKey("CompetenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
