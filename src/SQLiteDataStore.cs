using Microsoft.EntityFrameworkCore;

class SQLiteDataStore : DataStore
{
    protected override UserContext CreateContext()
    {
        return new SQLiteContext();
    }
}