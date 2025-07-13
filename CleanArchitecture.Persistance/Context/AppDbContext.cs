using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : DbContext
{
    //AppDbContext context = new();
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("");
    //}
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

   
}
