using AvaloniaProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaProject.DataBaseContext;

public class DataBaseContext: DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseHelper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
    
    
    public void SaveUser(User user)
    {
        Users.Add(user);
        SaveChanges();
    }
}