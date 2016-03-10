using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Count.Model;
using System.Data.SQLite;

using System.Windows.Forms;

namespace Count.Manager
{
    public class LocalDataManager
    {
        private static LocalDataManager _instance = new LocalDataManager();
        private static readonly object _lockObject = new object();
        public LocalData LocalData = new LocalData { Name = "CounterMain", FileExtension = "db", Version = "3" };

        public static LocalDataManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new LocalDataManager();
                    }
                    return _instance;
                }
            }
        }

        private string localdataFilePath;

        public LocalDataManager()
        {
            localdataFilePath = Path.Combine(Environment.CurrentDirectory, "CounterMain.db");
            Get();
        }

        public LocalData Get()
        {
            if (!File.Exists(localdataFilePath))
            {
                try
                {
                    SQLiteConnection.CreateFile(localdataFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Yerel Veri Tabanı Hatası \n Hata : {0}", ex.Message));
                }
            }
            return LocalData;

        }


    }
}
