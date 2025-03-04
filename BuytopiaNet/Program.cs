
using Buytopia.DAL;
using Buytopia.DAL.Repository;
using Buytopia.BLL;
using Buytopia.PL.Configuration;
using Microsoft.EntityFrameworkCore;
using Buytopia.DAL.Repository.Interfaces;
using Buytopia.BLL.Service.Interfaces;
using Buytopia.BLL.Service;



namespace Buytopia.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<BuytopiaDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("BuytopiaDbContext"));
            });


            //Aggiunti gli scope per le repo
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            //Aggiunti gli scope per i serv
            
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IUserService, UserService>();
            
            


            //Aggiunti per la repo generica
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            



            // Add services to the container.

            builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));

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
