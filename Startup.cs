using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;

namespace Daniel15.EFTest
{
	public class Startup
	{
		public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
		{
			// Setup configuration sources.
			var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
				.AddJsonFile("config.json")
				.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfiguration Configuration { get; set; }

		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSingleton<IConfiguration>(_ => Configuration);
			services.AddScoped<MyContext>();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}"
				);
			});
		}
	}
}
