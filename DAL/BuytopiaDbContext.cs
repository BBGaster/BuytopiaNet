namespace Buytopia.DAL
{
    using Buytopia.DAL.Entities;
    using Microsoft.EntityFrameworkCore;

public class BuytopiaDbContext : DbContext
{
    public BuytopiaDbContext(DbContextOptions<BuytopiaDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            //Se vuoi aggiungi Seeds
    }

        //Aggiungere relazioni entita tabelle?
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<User> Users => Set<User>();


    }
}
