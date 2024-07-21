using Microsoft.EntityFrameworkCore;

namespace ADO_Task_6;

public class MiniInstaContext:DbContext
{
    public DbSet<Posts> posts { get; set; }
    public DbSet<Tags> tags { get; set; }
    public DbSet<Users> users { get; set; }

    public MiniInstaContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MiniInsta;Integrated Security=SSPI;");

    }

}
