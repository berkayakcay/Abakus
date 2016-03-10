using System;

using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

using Count.Model;


namespace Count.Manager
{
    public class ConnectionManager
    {

        private static ConnectionManager _instance = new ConnectionManager();
        private static readonly object _lockObject = new object();

        public static ConnectionManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ConnectionManager();
                    }
                    return _instance;
                }
            }
        }

        public ConnectionManager()
        {
        }

        public string ConnectionString
        {
            get
            {
                if (ConfigurationManager.Instance.Configuration != null)
                {
                    return string.Format("Data Source ={0},{1}; initial catalog={2}; user id ={3}; password={4}",
                       ConfigurationManager.Instance.Configuration.Server,
                       ConfigurationManager.Instance.Configuration.Port,
                       ConfigurationManager.Instance.Configuration.Database,
                       ConfigurationManager.Instance.Configuration.Username,
                       ConfigurationManager.Instance.Configuration.Password
                       );
                }
                return null;
            }
        }

        public void ConnectionTest()
        {
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    sqlCon.Close();
                }
                MessageBox.Show("Test sorunsuz bir şekilde gerçekleştirildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Belirtilen parametreler hatalı.\n Hata : {0}", ex.Message));
            }
        }

        public List<Warehouse> GetWarehouses()
        {
            List<Warehouse> warehouselist = null;
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    using (var sqlCommand = new SqlCommand(@"SELECT DISTINCT w.WarehouseCode,wd.WarehouseDescription
                    FROM [cdWarehouse] w
                    INNER JOIN cdWarehouseDesc wd on w.WarehouseCode = wd.WarehouseCode
                    Where LangCode = 'TR'", sqlCon))
                    {
                        sqlCon.Open();
                        using (IDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            warehouselist = new List<Warehouse>();

                            while (dr.Read())
                            {
                                warehouselist.Add(new Warehouse()
                                {
                                    Code = dr["WarehouseCode"].ToString(),
                                    Name = dr["WarehouseDescription"].ToString()
                                });
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yüklenirken hata oluştu.\n Hata:{0}", ex.Message);
            }
            return warehouselist;
        }

        public List<ActiveProgram> GetActivePrograms()
        {
            List<ActiveProgram> activeprograms = null;

            activeprograms = new List<ActiveProgram>();
            activeprograms.Add(new ActiveProgram()
            {
                Name = "Nebim V3",
                Version = "10.0"
            });

            activeprograms.Add(new ActiveProgram()
            {
                Name = "Nebim Winner",
                Version = "1.0"
            });
            return activeprograms;
        }

        public List<Count> GetCounts()
        {
            List<Count> counts = null;
            // write count 
            return counts;
        }



    }
}
