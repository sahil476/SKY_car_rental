using Microsoft.EntityFrameworkCore;

namespace SKY_car_rental.Context
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {

        }
        public DbSet<RegisterModel> UserTable { get; set; }


    }
}
/*public void ConfigureServices(IServiceCollection services)
{
    // Add DbContext to services
    services.AddDbContext<CarsDbContext>(options =>
    {
        // Configure your DbContext options here
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    });

    // Add other services as needed

    // Add MVC services
    services.AddControllersWithViews();
}
*/
