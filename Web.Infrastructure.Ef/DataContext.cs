using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Web.Domain.Entities;

namespace Web.Infrastructure.Ef;

public class DataContext:DbContext 
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DataContext)) ?? throw new InvalidOperationException());
    }
public DbSet<Car> Cars { get; set; }
public DbSet<Client>Clients { get; set; }
public DbSet<Service> Services { get; set; }
public DbSet<Advantage> Advantages { get; set; }
public DbSet<Payment> Payments { get; set; }
public DbSet<Product> Products { get; set; }
public DbSet<Schedule> Schedules { get; set; }

public DbSet<Subscription> Subscriptions { get; set; }

public DbSet<Trainer> Trainers { get; set; }
}