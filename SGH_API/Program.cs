using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Interface;
using SolmileGuesthouseAPI.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals;
            });
//adding db service
builder.Services.AddDbContext<GuesthouseDbContext>(op =>
op.UseSqlServer(builder.Configuration.GetConnectionString("myCon")));
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ComplaintInterface, ComplaintRepo>();
builder.Services.AddScoped<AttendanceInterface, AttendanceRepo>();
builder.Services.AddScoped<LogInterface, LogRepo>();
builder.Services.AddScoped<FeedBackInterface, FeedBackRepo>();
builder.Services.AddScoped<PayrollInterface, PayrollRepo>();
builder.Services.AddScoped<TaxInterface, TaxRepo>();
builder.Services.AddScoped<PaymentInterface, PaymentRepo>();
builder.Services.AddScoped<PaymentMethodInterface, PaymentMethodRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Enable Reference Handling
builder.Services.AddControllers()
        .AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            x.JsonSerializerOptions.WriteIndented = true;
        });

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
