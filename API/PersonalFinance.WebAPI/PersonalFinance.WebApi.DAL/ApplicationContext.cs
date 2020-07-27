using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using PersonalFinance.WebApi.Model;

namespace PersonalFinance.WebApi.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Investimentos> Investimentos { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<GanhoExtra> GanhoExtra { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<Patrimonio> Patrimonio { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Para fazer o mapeamento da classe para o banco, é necessário adicionar logo a baixo
            modelBuilder.Entity<Competencia>().HasKey(t => t.Id);
            modelBuilder.Entity<GanhoExtra>().HasKey(t => t.Id);
            modelBuilder.Entity<Gastos>().HasKey(t => t.Id);
            modelBuilder.Entity<Investimentos>().HasKey(t => t.Id);
            modelBuilder.Entity<Patrimonio>().HasKey(t => t.Id);
            modelBuilder.Entity<Salario>().HasKey(t => t.Id);
            modelBuilder.Entity<Usuarios>().HasKey(t => t.Id);
            modelBuilder.Entity<ContaBancaria>().HasKey(t => t.Id);

            //Relacionamento entre as tabelas
            modelBuilder.Entity<Patrimonio>().HasOne(t => t.Usuarios);
            modelBuilder.Entity<Patrimonio>().HasOne(t => t.ContaBancaria);
            modelBuilder.Entity<Patrimonio>().HasOne(t => t.Investimentos);

            modelBuilder.Entity<Competencia>().HasOne(t => t.Gastos);
            modelBuilder.Entity<Competencia>().HasOne(t => t.Salario);
            modelBuilder.Entity<Competencia>().HasOne(t => t.GanhoExtra);
            modelBuilder.Entity<Competencia>().HasOne(t => t.Patrimonio);


        }
    }
}
