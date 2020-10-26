using AppContacts.Droid.SQLiteDb;
using AppContacts.SQLiteDb;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb_Droid))]
namespace AppContacts.Droid.SQLiteDb
{
    public class SQLiteDb_Droid : ISQLite
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment
                                     .SpecialFolder.MyDocuments);
            var path = System.IO.Path.Combine(documentsPath, "MyContacts.db3");

            return new SQLiteAsyncConnection(path);
        }

    }
}