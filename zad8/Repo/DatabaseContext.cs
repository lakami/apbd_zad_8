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
    
    //umożliwienie pracy na tablicy Doctors
    public virtual DbSet<Doctor> Doctor { get; set; }
    
}