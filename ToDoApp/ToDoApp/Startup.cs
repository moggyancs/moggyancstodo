using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Repositories;

namespace ToDoApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connection = @"User ID=cgyqlznpuxxamh;Password=071c1225f1ffe75ff0029222d66c9acc5b06d4a64ff3b80c8068dac4e04d0082;Host=ec2-54-217-217-142.eu-west-1.compute.amazonaws.com;Port=5432;Database=d15oddhtjaj3rd;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;";
            //services.AddDbContext<ToDoContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ToDoContext>(options => options.UseNpgsql(connection));
            services.AddScoped<IDoThingsRepo, ToDoRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
