using System.IO;

using Android.App;

namespace AppContacts.Droid
{
    public class FileAccessHelper_Droid
    {
        public static void CopyDatabaseIfNotExists(string dbPath, string SQLiteAsset)
        {
            if (!File.Exists(dbPath))
            {
                using (var br = new BinaryReader(Application.Context.Assets.Open(SQLiteAsset)))
                {
                    using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, length);
                        }
                    }
                }
            }
        }
    }

}