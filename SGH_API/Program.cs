using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;

var builder = WebApplication.CreateBuilder(args);

////datecoverter
//builder.Services.AddControllers()
//    .AddJsonOptions(options =>
//    {
//        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
//    });


///##############
//adding db service
builder.Services.AddDbContext<GuesthouseDbContext>(op =>
op.UseSqlServer(builder.Configuration.GetConnectionString("myCon")));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
