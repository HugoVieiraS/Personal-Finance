using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using PersonalFinance.WebApi.Model;
using PersonalFinance.WebApi.DAL.Usuarios;
using PersonalFinance.WebApi.Seguranca;

namespace PersonalFinance.WebApi.DAL
{
    public class ApplicationContext : DbContext 
    {
        #region Properties
        public DbSet<Investimentos> Investimentos { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<GanhoExtra> GanhoExtra { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        #endregion

        #region Constructor
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();

        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Usuario>(new UsuarioConfiguration());


            #region Para fazer o mapeamento da classe para o banco, é necessário adicionar logo a baixo
            modelBuilder.Entity<Competencia>().HasKey(t => t.Id);
            modelBuilder.Entity<GanhoExtra>().HasKey(t => t.Id);
            modelBuilder.Entity<Gastos>().HasKey(t => t.Id);
            modelBuilder.Entity<Investimentos>().HasKey(t => t.Id);
            modelBuilder.Entity<Salario>().HasKey(t => t.Id);           
            modelBuilder.Entity<ContaBancaria>().HasKey(t => t.Id);
            #endregion

            #region Relacionamento entre as tabelas;
            modelBuilder.Entity<Salario>().HasOne(t => t.Competencia);
            modelBuilder.Entity<Investimentos>().HasOne(t => t.Competencia);
            modelBuilder.Entity<Gastos>().HasOne(t => t.Competencia);
            modelBuilder.Entity<GanhoExtra>().HasOne(t => t.Competencia);
            modelBuilder.Entity<ContaBancaria>().HasOne(t => t.Competencia);
            #endregion
        }
        #endregion
    }
}
