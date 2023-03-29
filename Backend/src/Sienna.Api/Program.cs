using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Sienna.Api.Behaviours;
using Sienna.Api.Filters.Auth;
using Sienna.Api.Filters.Operations;
using Sienna.Application.Services;
using Sienna.Domain.Mappings;
using Sienna.Domain.Validators;
using Sienna.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Enabling cors for development
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllHeaders",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ApiKeyAttribute>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<EspressoShotsOperationFilter>();
});

// Adding our DbContext reference
builder.Services.AddDbContext<EspressoShotRepository>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SiennaConn"),
    builder => builder.MigrationsAssembly("Sienna.Api")));

// Registering our Mapper
var mapperConfig = new MapperConfiguration(config =>
{
    config.AddProfile(new EspressoShotMappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Registering our application deps
builder.Services.AddScoped<IEspressoShotRepository, EspressoShotRepository>();
builder.Services.AddScoped<IEspressoShotsService, EspressoShotsService>();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

// All of our validators
builder.Services.AddValidatorsFromAssemblyContaining<EspressoShotDtoValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllHeaders");

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingBehaviour>();

app.UseMiddleware<RequestLoggingBehaviour>();

app.MapControllers();

app.Run();
