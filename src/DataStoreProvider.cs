class DataStoreProvider : DataStore
{
  readonly UserContext context;

  public DataStoreProvider(UserContext context) {
    this.context = context;
  }

  protected override UserContext CreateContext()
    {
        return context;
    }
}