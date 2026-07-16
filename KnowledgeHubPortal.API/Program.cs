
using KnowledgeHubPortal.Business.Interfaces;
using KnowledgeHubPortal.Data;
using Microsoft.OpenApi;

namespace KnowledgeHubPortal.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Configure CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
            });
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // Register Swagger
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Knowledge Hub Portal API",
                    Version = "v1",
                    Description = "REST API built using ASP.NET Core 10",
                    Contact = new OpenApiContact
                    {
                        Name = "Venkat Shiva Reddy",
                        Email = "venkatshiva.reddy@gmail.com"
                    }
                });
            });


            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IArticlesRepository, ArticlesRepository>();
            //builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
            //builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();



            var app = builder.Build();

            // Enable Swagger
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Knowledge Hub Portal API V1");
                    options.DocumentTitle = "Knowledge Hub Portal API Documentation";
                });
            }


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            // Enable CORS
            app.UseCors("AllowAll");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


            // Secure the API with JWT authentication (optional)
            // ODATA support (optional)
            // Versioning support (optional)
            // Logging and monitoring (optional)
            // Error handling and exception middleware (optional)
            // Caching support (optional)
            // Rate limiting support (optional)
            // Health checks support (optional)
            // Background services support (optional)
            // Async processing support (optional)
            // Dependency injection support (optional) done
            // Unit testing support (optional)
            // Integration testing support (optional)
            // Deployment support (optional)
            // CI/CD support (optional)
            // Documentation support (optional)
            // Microservices support (optional)



        }
    }
}
