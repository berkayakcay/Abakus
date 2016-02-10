using System;
using System.Data.SqlClient;
using System.Data.SQLite;


namespace Count
{
    class dbase
    {

        #region Variables
        public static string slconnectionstring = "Data Source=db/main.db; Version=3;";
        public static SQLiteConnection slConnection;
        public static string slQueryText;
        public static SQLiteCommand slCommand;
        public static SQLiteDataReader slDataReader;

        private static string _msconnectionstring;
        public static SqlConnection msConnection;
        public static string msQueryText;
        public static SqlCommand msCommand;
        public static SqlDataAdapter msDataAdapter;
        public static SqlDataReader msDataReader;

        public static string ServerName;
        public static string DataBase;
        public static string User;
        public static string Password;
        public static string Program;

        public static string Msconnectionstring
        {
            get
            {
                try
                {
                    if (System.IO.File.Exists(@"Settings.txt"))
                    {
                        string[] lines = System.IO.File.ReadAllLines(@"Settings.txt");
                        dbase.ServerName = lines[0];
                        dbase.DataBase = lines[1];
                        dbase.User = lines[2];
                        dbase.Password = lines[3];
                        dbase.Program = lines[4];
                    }
                    else
                    {
                        throw new System.InvalidOperationException("file not found!"); 
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return "Server=" + ServerName + ";Database=" + DataBase + ";User Id=" + User + ";Password=" + Password + "; MultipleActiveResultSets=True;";

            }
            set
            {
                _msconnectionstring = value;
            }
        }

        #endregion

        #region Functions

        public static void OpenslConnection()
        {
            try
            {
                if (slConnection == null || slConnection.State.ToString() == "Closed")
                {
                    slConnection = new SQLiteConnection(slconnectionstring);
                    slConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   // OPEN SQLite

        public static void CloseslConnection()
        {
            try
            {
                if (slConnection == null || slConnection.State.ToString() == "Open")
                {
                    slConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   // CLOSE SQLite

        public static void OpenmsConnection()
        {
            try
            {
                if (msConnection == null || msConnection.State.ToString() == "Closed")
                {
                    msConnection = new SqlConnection(Msconnectionstring.ToString());
                    msConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }   // OPEN MSSQL

        public static void ClosemsConnection()
        {
            try
            {
                if (msConnection == null || msConnection.State.ToString() == "Open")
                {
                    msConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   // CLOSE MSSQL
        #endregion

    }
}
