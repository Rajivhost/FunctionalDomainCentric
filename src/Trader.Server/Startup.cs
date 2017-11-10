using FluentValidation.AspNetCore;
using Hse.Configuration;
using Hse.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Config;
using Rebus.ServiceProvider;

namespace Trader.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            CompositionRoot.Compose(services);

            services
                .AddMvc()
                .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddRebus(RebusConfig.Configure);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRebus();

            app.UseMvc();
        }
    }
}
