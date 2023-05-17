using WebAppAPI.Models.KoalaCustomerDto;
using WebAppAPI.Repository.IRepository;
using WebAppAPI.Repository;
using WebAppMVC.Models;

namespace WebAppAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //MappingSettings
            //builder.Services.AddAutoMapper(typeof(MappingConfig)); //Automapper required for mapper to function
            //builder.Services.AddScoped<IRepository<KoalaCustomer>, Repository<KoalaCustomer>>();
            //builder.Services.AddScoped<IRepository<KoalaCustomer>, Repository<KoalaCustomer>>();
            //EndofMapping

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