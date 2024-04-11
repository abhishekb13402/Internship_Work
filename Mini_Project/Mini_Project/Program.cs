using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mini_Project;
using Mini_Project.Data;
using Mini_Project.Models.Interfaces;
using Mini_Project.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IMapper mapper = MappingConfiguration.RegisterMaps().CreateMapper();

builder.Services.AddDbContext<AppConfigDBContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")) );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// lines
builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<ITodoTask, TodoTaskRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
