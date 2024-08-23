using AspNetCoreRateLimit;
using Library_Ap�_Sysytem.Data;
using Library_Ap�_Sysytem.Entities;
using Library_Ap�_Sysytem.Extensions;
using Library_Ap�_Sysytem.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("mssqlconnection"));
});
builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApiDbContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<EmailService>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = "localhost",
        ValidAudience = "localhost",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
        ClockSkew = TimeSpan.Zero
    };
});
builder.Services.AddScoped<JwtService>();
builder.Services.AddMemoryCache();
builder.Services.ConfigureRateLimitingOptions();
builder.Services.AddHttpContextAccessor();

builder.Services.ConfigureSwagger();

builder.Services.ConfigureCors();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "Softito V1");
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "Softito V2");
    });
}

app.UseIpRateLimiting();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//Kaynaklar
//
//Softito Rafet G�rel
//
//Btk Akademi Zafer C�mert
//
//Youtube ProgrammerRohan

//Yotube Gencay Yildiz



