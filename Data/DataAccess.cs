
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskTamer.Data.Models;

namespace TaskTamer.Data;

public class AppDBContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDBContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("PostgresDBConnection"));
    }

   // Add DbSet for Task
    public DbSet<TaskItem> TaskItems { get; set; }
    
}