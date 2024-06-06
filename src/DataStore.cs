abstract class DataStore
{
  readonly UserContext context;

  public DataStore() {
    context = CreateContext();
  }
  
  protected abstract UserContext CreateContext();

  public void CreateUser(User user) {
    context.Users.Add(user);
    context.SaveChanges();
  }

  public List<User> GetUsers() {
    return context.Users.ToList();
  }

  public void UpdateUser(User user) {
    var userObj = context.Users.Find(user.Id);
    if (userObj == null) {
      Console.WriteLine($"Didn't find user with id: {user.Id}");
      return;
    }
    userObj.Name = user.Name;
    context.SaveChanges();
  }

  public void DeleteUser(int id) {
    var user = context.Users.Find(id);
    if (user == null) {
      Console.WriteLine($"Didn't find user with id: {id}");
      return;
    }
    context.Users.Remove(user);
    context.SaveChanges();
  }
}