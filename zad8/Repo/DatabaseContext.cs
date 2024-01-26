using Microsoft.EntityFrameworkCore;

namespace zad8.Repo;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<Doctor> Doctors { get; set; }
    
}