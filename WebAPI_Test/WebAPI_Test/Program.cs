// Iporting necessary namespaces for entity framework core, OpenAPI and the custome code
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebAPI_Test;

var builder = WebApplication.CreateBuilder(args);//sets up the infrastructure for your API application
builder.Services.AddEndpointsApiExplorer(); //Adding an API  explorere to help with generating documentation

//Adding SwaggerGen to generate Swagger documentation
builder.Services.AddSwaggerGen(options =>
{
    //Defining the API documentation for version "v1"
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
//Adding a database context to the services and configuring it to use SQL server 
builder.Services.AddDbContext<SchoolDBContext>(options => options.UseSqlServer(builder.Configuration["DbConnection"]));
//Add a cross Origin Resource sharing policy
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//Building the API application
var app = builder.Build();
//handling API endpoints for handling requests
app.MapPost("student", (Student student, SchoolDBContext db) =>
{
    //Code to Add Student to the database
    db.Add(student);
    db.SaveChanges();
    return student;
});
app.MapGet("student", ( SchoolDBContext db) =>
{
    //Code to fetch a list of all students from the database
    return db.Students.ToList();
});
app.MapGet("student/{id}", (int id, SchoolDBContext db) =>
{
    //Code to fetch a specific student by ID  from the database
    return db.Students.FirstOrDefault(x => x.Id == id);
});
//Adding Swagger middleware to the API pipeline
app.UseSwagger();
app.UseSwaggerUI();
//Applying the CORS policy to the API
app.UseCors("corsapp");


app.Run(); //Running the API , final
