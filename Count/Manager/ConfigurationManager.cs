using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

using Count.Model;
using System.Data.SqlClient;

namespace Count.Manager
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance = new ConfigurationManager();
        private static readonly object _lockObject = new object();
        public Configuration Configuration;

        public static ConfigurationManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                    return _instance;
                }
            }
        }

        private string configurationFilePath;

        private ConfigurationManager()
        {
            configurationFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Configuration.xml");
            Get();
        }

        public Configuration Get()
        {
            if (File.Exists(configurationFilePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                    using (StreamReader srConfigurationFile = new StreamReader(configurationFilePath))
                    {
                        Configuration = (Configuration)serializer.Deserialize(srConfigurationFile);
                        return Configuration;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Bir hata oluştur. {0}",ex.Message));
                }
            }
            else
            {
                MessageBox.Show("Ayar dosyası daha önce oluşturulmamış");
            }

            return null;
        }

        public void CreateOrUpdate(Configuration configuration)
        {
            try
            {
                using (StreamWriter swFile = new StreamWriter(configurationFilePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                    serializer.Serialize(swFile, configuration);
                    Configuration = configuration;
                }
                MessageBox.Show("Bilgiler kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Bir hata oluştur. {0}", ex.Message));
            }
        }

    }
}
