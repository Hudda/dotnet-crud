class DotNetCRUD {
  public static void Main() {
    DataStore store = new SQLiteDataStore();
    TestCRUD(store);
    store = new SQLServerDataStore();
    TestCRUD(store);
  }

  private static void TestCRUD(DataStore store) {
    store.CreateUser(new User{ Id = 1, Name = "Jon Doe"});
    PrintUsers(store);
    store.UpdateUser(new User{ Id = 1, Name = "Jane Doe" });
    PrintUsers(store);
    store.DeleteUser(1);
    PrintUsers(store);
  }

  private static void PrintUsers(DataStore store) {
    List<User> users = store.GetUsers();
    foreach (User user in users) {
      Console.WriteLine($"User ${user.Id} : ${user.Name}");
    }
  }
}