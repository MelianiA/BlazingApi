using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MyApp.Models.Opts;
using MyApp.Services;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;

namespace MyApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //services.AddSingleton<IWeatherForecastService,InMemoryWeatherForecastService>();
            services.AddHttpClient<IWeatherForecastService,HttpWeatherForecastService>
                ((serviceProvider, client) => 
                    {
                        var options = serviceProvider.GetRequiredService<IOptions<ApiOptions>>();
                        client.BaseAddress = new Uri(options.Value.Url);
                    }
                ).AddPolicyHandler(GetHttpPolicy());

            services.AddOptions();
            services.Configure<ApiOptions>(Configuration.GetSection("Api"));

        }

        private IAsyncPolicy<HttpResponseMessage> GetHttpPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(5, retry => TimeSpan.FromMilliseconds(200+(retry*150)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
