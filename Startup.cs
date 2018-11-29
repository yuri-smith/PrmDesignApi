using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


using PrmDesignApi.Models;



namespace PrmDesignApi
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
            services.AddCors();
            string con = "Server=(localdb)\\mssqllocaldb;Database=PrmDesign;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<PrmDesignContext>(options => options.UseSqlServer(con));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,                  // укзывает, будет ли валидироваться издатель при валидации токена
                        ValidIssuer = AuthOptions.ISSUER,       // строка, представляющая издателя

                        ValidateAudience = true,                // будет ли валидироваться потребитель токена
                        ValidAudience = AuthOptions.AUDIENCE,   // установка потребителя токена
                        ValidateLifetime = true,                // будет ли валидироваться время существования

                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(), // установка ключа безопасности
                        ValidateIssuerSigningKey = true,        // валидация ключа безопасности
                    };
                }
            );

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod());
            //app.UseCors(builder => builder.AllowAnyOrigin()
            //                            .AllowAnyHeader()
            //                            .AllowAnyMethod());

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
