namespace Buytopia.DAL
{ 

using Microsoft.EntityFrameworkCore;

public class BuytopiaDbContext : DbContext
{
    public BuytopiaDbContext(DbContextOptions<BuytopiaDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    //Aggiungere relazioni entita tabelle

}
}
