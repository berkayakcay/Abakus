using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

using Count.Model;

namespace Count.Manager
{
    public class LocalDataConnectionManager
    {
        private static LocalDataConnectionManager _instance = new LocalDataConnectionManager();
        private static readonly object _lockObject = new object();

        public static LocalDataConnectionManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new LocalDataConnectionManager();
                    }
                    return _instance;
                }
            }
        }

        public LocalDataConnectionManager()
        {

        }

        public string ConnectionString
        {
            get
            {
                if (LocalDataManager.Instance.LocalData == null)
                {
                    return string.Format("Data Source = {0}.{1}; Version = {2}",
                        LocalDataManager.Instance.LocalData.Name,
                        LocalDataManager.Instance.LocalData.FileExtension,
                        LocalDataManager.Instance.LocalData.Version);
                }
                return null;
            }
        }










    }
}
