class SQLiteDataStore : DataStore
{
    SQLiteContext context;

    public SQLiteDataStore(SQLiteContext context) {
        this.context = context;
    }

    protected override UserContext CreateContext()
    {
        return new SQLiteContext();
    }
}