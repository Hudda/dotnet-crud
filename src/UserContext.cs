using Microsoft.EntityFrameworkCore;

class UserContext : DbContext {
  public DbSet<User> Users { get; set; }
}