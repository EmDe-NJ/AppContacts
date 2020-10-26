using SQLite;

namespace AppContacts.SQLiteDb
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
