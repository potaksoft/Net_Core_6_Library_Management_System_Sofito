using AspNetCoreRateLimit;
using Microsoft.OpenApi.Models;

namespace Library_Apı_Sysytem.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRateLimitingOptions(this IServiceCollection services)
        {
            var rateLimitRules = new List<RateLimitRule>()
            {
                new RateLimitRule()
                {
                    Endpoint = "*",
                    Limit = 10,                               //1 dakikda en fazla 10 istek atilabilir
                    Period = "1m"
                }
            };

            services.Configure<IpRateLimitOptions>(opt =>
            {
                opt.GeneralRules = rateLimitRules;
            });

            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Softito Akademi",
                        Version = "v1",
                        Description = "Softito Akademi ASP.NET Core Web API",
                        TermsOfService = new Uri("https://www.softito.com.tr/"),
                        Contact = new OpenApiContact
                        {
                            Name = "Ahmet Potak",
                            Email = "youremail@gmail.com",
                            Url = new Uri("https://www.softito.com.tr/")
                        }
                    });

                s.SwaggerDoc("v2", new OpenApiInfo { Title = "Softito Akademi", Version = "v2" });

                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id="Bearer"
                            },
                            Name = "Bearer"
                        },
                        new List<string>()
                    }
                });
            });
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    //.WithExposedHeaders("X-Pagination")
                );
            });
        }
        public static void ConfigureVersioning(this IServiceCollection services)
        {
            //services.AddApiVersioning(opt =>
            //{
            //    opt.ReportApiVersions = true;
            //    opt.AssumeDefaultVersionWhenUnspecified = true;
            //    opt.DefaultApiVersion = new ApiVersion(1, 0);
            //    opt.ApiVersionReader = new HeaderApiVersionReader("api-version");

            //    opt.Conventions.Controller<BooksController>()
            //        .HasApiVersion(new ApiVersion(1, 0));

            //    opt.Conventions.Controller<BooksV2Controller>()
            //        .HasDeprecatedApiVersion(new ApiVersion(2, 0));
            //});
        }

    }
}
