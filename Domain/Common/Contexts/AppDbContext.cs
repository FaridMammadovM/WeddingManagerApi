using Microsoft.EntityFrameworkCore;
using Domain.Common.Entities;

namespace Domain.Common.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantPhone> RestaurantPhones { get; set; }
    public DbSet<RestaurantUser> RestaurantUsers { get; set; }
    public DbSet<TableType> TableTypes { get; set; }
    public DbSet<RestaurantHall> RestaurantHalls { get; set; }
    public DbSet<HallTable> HallTables { get; set; }
    public DbSet<HallTableGuest> HallTableGuests { get; set; }
    public DbSet<ResTableLimit> ResTableLimits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}