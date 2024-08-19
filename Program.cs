
using Microsoft.EntityFrameworkCore;
using BlogUsersAPI.Data;

namespace BlogUsersAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var connectionString = builder.Configuration.GetConnectionString("LitLoungeContextConnection") ?? throw new InvalidOperationException("Connection string 'Snackis4ContextConnection' not found.");

            builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(connectionString));

            //builder.Services.AddDbContext<LitLoungeContext>(options =>
            //options.UseSqlServer(connectionString));

            // builder.Services.AddDefaultIdentity<LitLoungeUser>()
            //.AddEntityFrameworkStores<LitLoungeContext>();

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
        }
    }
}
