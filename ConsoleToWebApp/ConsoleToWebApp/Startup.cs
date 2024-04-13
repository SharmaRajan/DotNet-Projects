using System;
using ConsoleToWebApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebApp
{
	public class Startup
	{
		// This is for dependency injection
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddTransient<CustomMiddleware>();

            // register an Singleton service in ASP.NET Core web app
            //services.AddSingleton<IProductRepo, ProductRepository>();
            //services.AddScoped<IProductRepo, ProductRepository>();
            //services.AddTransient<IProductRepo, ProductRepository>();

            services.TryAddTransient<IProductRepo, ProductRepository>();
            services.TryAddTransient<IProductRepo, TestRepository>();
        }

		// Used to configure HTTP request Pipelines, All the middlewares are configured here
		public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
		{
			// 2. Use() method -> To insert a new middleware in the Pipeline
			//app.Use(async (context,next) =>
			//{
			//	await context.Response.WriteAsync("Use() from Configure in StartUp class-1\n");
			//	await next();
   //             await context.Response.WriteAsync("Use() from Configure in StartUp class-2\n");
   //         });

			// 4. Custom middleware -> Insert the code in HTTP Pipeline
			//app.UseMiddleware<CustomMiddleware>();

			// 3. Map() method -> To map the middleware to a specific URL
			//app.Map("/rajan",CustomCode);

			// 1. Run() method -> To complete the middleware execution
			//app.Run(async context =>
			//{
			//	await context.Response.WriteAsync("Run() from Configure in StartUp class\n");
			//});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// 5. To Map the incoming HTTP request (URL) to a particular resource
			// we need two middleware in the HTTP pipeline to enable Routing
			// 1. UseRouting() 2. UseEndpoints()
			app.UseRouting();

			// Now we will tell the mapping of URL to a particular resource
			app.UseEndpoints(endPoints => {
				/*
				 *  This is for basic when we don't define the controller in ConfigureServices() method
				 * 
				endPoints.MapGet("/", async context =>
				{
					await context.Response.WriteAsync("Hello from new Web API app");
				});

                endPoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello from new Web API app Test");
                });
				*/

				// This is for AddControllers()
				endPoints.MapControllers();

            });
		}

        private void CustomCode(IApplicationBuilder app)
        {
			app.Use(async (context, next) => {
				await context.Response.WriteAsync("Hello from Rajan\n");
				await next();
			});
        }
    }
}

