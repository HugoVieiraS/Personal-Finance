using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PersonalFinance.WebApi.Model;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.WebApi.DAL;

namespace PersonalFinance.WebAPI
{
    public class Startup
    {
        #region Properties
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddTransient<IDataService, DataService>();

            #region Adicionar classes para injeção de dependencia
            services.AddTransient<IRepository<Usuarios>, RepositorioBase<Usuarios>>();
            services.AddTransient<IRepository<Salario>, RepositorioBase<Salario>>();
            services.AddTransient<IRepository<Investimentos>, RepositorioBase<Investimentos>>();
            services.AddTransient<IRepository<Gastos>, RepositorioBase<Gastos>>();
            services.AddTransient<IRepository<GanhoExtra>, RepositorioBase<GanhoExtra>>();
            services.AddTransient<IRepository<ContaBancaria>, RepositorioBase<ContaBancaria>>();
            services.AddTransient<IRepository<Competencia>, RepositorioBase<Competencia>>();
            #endregion

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Garantir que o banco está criado
            serviceProvider.GetService<IDataService>().InicializaBD();
        }
        #endregion
    }
}
