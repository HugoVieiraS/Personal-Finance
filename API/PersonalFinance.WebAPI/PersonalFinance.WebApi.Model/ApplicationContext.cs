using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApi.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Para fazer o mapeamento da classe para o banco, é necessário adicionar logo a baixo
            modelBuilder.Entity<Usuarios>().HasKey(t => t.Id);
            modelBuilder.Entity<Renda>().HasKey(t => t.Id);
            modelBuilder.Entity<Investimentos>().HasKey(t => t.Id);
            modelBuilder.Entity<GastosMensais>().HasKey(t => t.Id);
            modelBuilder.Entity<GanhoFixo>().HasKey(t => t.Id);

            //Relacionamento entre as tabelas
            modelBuilder.Entity<Renda>().HasOne(t => t.IdUsuario);
            modelBuilder.Entity<Investimentos>().HasOne(t => t.IdRenda);
            modelBuilder.Entity<GastosMensais>().HasOne(t => t.IdRenda);
            modelBuilder.Entity<GanhoFixo>().HasOne(t => t.IdRenda);
        }
    }
}
