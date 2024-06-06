using Microsoft.EntityFrameworkCore;

class SQLServerContext : UserContext {
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=my-database;User Id=sa;Password=dockerStrongPwd123;Connection Timeout=30;TrustServerCertificate=true");
    }
}