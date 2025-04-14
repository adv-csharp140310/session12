using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace AppTransaction.Model;
internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140310_transaction;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EFCodeFirst");
        optionsBuilder.UseSqlite("Data Source=databse.dat");
        optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}

