using Microsoft.EntityFrameworkCore;

class SQLServerContext : UserContext {
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Server=my-server;Database=my-database;User Id=my-username;Password=my-password;Connection Timeout=30");
    }
}