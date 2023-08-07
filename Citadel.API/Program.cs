using Citadel.API.Mappers;
using Citadel.API.Models;
using Citadel.API.Validation;
using Citadel.Core.Services;
using Citadel.DataAccess;
using Citadel.DataAccess.Repositories;
using Citadel.Domain.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Citadel.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddCors(options =>
            {
                //Allow anything, just for the purposes of this app
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();

                    });
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApplicationInsightsTelemetry();
            builder.Services.AddFluentValidationAutoValidation();

            // Services
            builder.Services.AddScoped<IUserDetailService, UserDetailService>();

            //Repository and DBContext
            builder.Services.AddDbContext<IDbContext, CitadelDbContext>();
            builder.Services.AddScoped<IUserDetailRepository, UserDetailRepository>();

            // Mappers
            builder.Services.AddScoped<IUserDetailMapper, UserDetailMapper>();


            // Validators
            builder.Services.AddScoped<IValidator<UserDetailRequest>, UserDetailRequestValidator>();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();
            app.Run();
        }
    }
}