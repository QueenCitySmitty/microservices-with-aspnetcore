namespace StatlerWaldorfCorp.TeamService
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using StatlerWaldorfCorp.TeamService.Models;
    using StatlerWaldorfCorp.TeamService.Persistence;

    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }
                
        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<ITeamRepository, MemoryTeamRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}