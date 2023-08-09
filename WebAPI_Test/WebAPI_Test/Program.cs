using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebAPI_Test;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Reggy API",
        Description = "An ASP.NET Core Web API for managing Reggy items",
        TermsOfService = new Uri("https://Reggy.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Reggy Contact",
            Url = new Uri("https://Reggy.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Reggy License",
            Url = new Uri("https://Reggy.com/license")
        }
    });
});
builder.Services.AddDbContext<SchoolDBContext>(options => options.UseSqlServer(builder.Configuration["DbConnection"]));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();
app.MapPost("student", (Student student, SchoolDBContext db) =>
{
    db.Add(student);
    db.SaveChanges();
    return student;
});
app.MapGet("student", (SchoolDBContext db) =>
{
    return db.Students.ToList();
});
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corsapp");

app.Run();
