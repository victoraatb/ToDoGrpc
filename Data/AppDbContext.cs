using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoGrpc.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {

  }
  public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();

    internal Task FirstOrDefaultAsync(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}