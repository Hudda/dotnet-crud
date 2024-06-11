class DotNetCRUD {
  public static void Main() {
    DataStore store = new SQLiteDataStore();
    TestCRUD(store);
    store = new SQLServerDataStore();
    TestCRUD(store);
    DataStore sqliteStore = new DataStoreProvider(new SQLiteContext());
    TestCRUD(sqliteStore);
    DataStore sqlServerStore = new DataStoreProvider(new SQLServerContext());
    TestCRUD(sqlServerStore);
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
    if (users.Count == 0) {
      Console.WriteLine("No User Found");
    }
    foreach (User user in users) {
      Console.WriteLine($"User ${user.Id} : ${user.Name}");
    }
  }
}