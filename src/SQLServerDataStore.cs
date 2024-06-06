class SQLServerDataStore : DataStore
{
  protected override UserContext CreateContext()
    {
        return new SQLServerContext();
    }
}