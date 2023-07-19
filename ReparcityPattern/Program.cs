using DataLayer;
using Entityes;
using LogicLayer;
using Microsoft.EntityFrameworkCore;

namespace ReparcityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connection = builder.Configuration.GetConnectionString("dataBase");
            builder.Services.AddDbContextPool<EnployeeDetails>(option => option.UseSqlServer(connection));
            builder.Services.AddScoped<IDataLayer, DataLyerClass>();
            builder.Services.AddScoped<ILogicLayer, LogicLayerClass>();


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
        }
    }
}