using Microsoft.EntityFrameworkCore;

class SQLiteContext : UserContext {
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mytest.db");
    }
}