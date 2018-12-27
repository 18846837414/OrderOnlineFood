using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderOnlineFood.Data;
using OrderOnlineFood.Services;

namespace OrderOnlineFood
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<OrderFoodOnlineDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IRestaurantData, SqlServerRestaurantData>();
            services.AddTransient<IEmailProvider,EmailGreeter>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IConfiguration configuration,IGreeter greeter,IEmailProvider emailProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name:"about-route",
                //    template:"about",
                //    defaults: new { controller = "About", action = "Address" }

                //);
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=index}/{id?}"
                );
            });
            app.Run(async (context) =>
            {
                //var greeting = configuration["Greeting"];
                var emailSender = emailProvider.SendEmail();
               // string greeting = greeter.GetMessageToPrint();
                await context.Response.WriteAsync(emailSender.ToString());
            });
        }
    }
}
