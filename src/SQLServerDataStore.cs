class SQLServerDataStore : DataStore
{
  SQLServerContext context;

  public SQLServerDataStore(SQLServerContext context) {
    this.context = context;
  }

  protected override UserContext CreateContext()
    {
        return context;
    }
}