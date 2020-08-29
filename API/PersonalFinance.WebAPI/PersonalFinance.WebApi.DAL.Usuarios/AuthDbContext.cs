using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.Seguranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinance.WebApi.DAL.Usuarios
{
    public class AuthDbContext : IdentityDbContext<Usuario>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
           : base(options)
        {
            //irá criar o banco e a estrutura de tabelas necessárias
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Usuario>(new UsuarioConfiguration());
        }
    }
}
