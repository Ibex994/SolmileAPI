using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI;
using SolmileAPI.Interface;
using SolmileAPI.Repository;
public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals;
            });
        builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            options.EnableSensitiveDataLogging();
        });
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<userInterface, UserRepo>();
        builder.Services.AddScoped<EmployeeInterface, EmployeeRepo>();
        builder.Services.AddScoped<CustomerInterface, CustomerRepo>();
        builder.Services.AddScoped<ComplaintInterface, ComplaintRepo>();
        builder.Services.AddScoped<ReservationInterface, ReservationRepo>();
        builder.Services.AddScoped<RoomInterface, RoomRepo>();
        builder.Services.AddScoped<RoomAssignmentInterface, RoomAssignmetRepo>();
        builder.Services.AddScoped<BranchInterface, BranchRepo>();
        builder.Services.AddScoped<ContactDetailInterface, ContactDetailRepo>();
        builder.Services.AddScoped<AttendanceInterface, AttendanceRepo>();
        builder.Services.AddScoped<LogInterface, LogRepo>();
        builder.Services.AddScoped<EmployeeTaskInterface, EmployeeTaskRepo>();
        builder.Services.AddScoped<FeedBackInterface, FeedBackRepo>();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        //Enable Reference Handling
        builder.Services.AddControllers()
                .AddJsonOptions(x =>
                {
                    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // or omit this line
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
    }
}