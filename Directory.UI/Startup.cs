using Directory.BLL.RepositoryPattern.Concrete;
using Directory.BLL.RepositoryPattern.Interfaces;
using Directory.DAL.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.UI 
{
	public class Startup
	{
		readonly IConfiguration _configuration;//json i�inedeki mssqli �a��r�yoruz.bunu �a��rmak i�in bir �nterfaceden faydalan�yoruz
		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_configuration["ConnectionStrings:Mssql"]));
			// .json i�inedeki mssql i �a��r�yoruz.
			services.AddScoped<IPersonRepository, PersonRepository>();
			services.AddControllersWithViews(); // mvs nin �al��mas� i�in .

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name:"Default",
					pattern:"{controller=Home}/{action=Directory}/{id?}"
					);
			});
		}
	}
}
