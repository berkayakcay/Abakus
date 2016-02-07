using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

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


        public static DataTable DataTable;
        public static DataSet DataSet;

        public static string ServerName;
        public static string DataBase;
        public static string User;
        public static string Password;
        public static string Program;

        public static string Msconnectionstring
        {
            get
            {

                    if (System.IO.File.Exists(@"Settings.txt"))
                    {
                        try
                        {
                            string[] lines = System.IO.File.ReadAllLines(@"Settings.txt");
                            dbase.ServerName = lines[0];
                            dbase.DataBase = lines[1];
                            dbase.User = lines[2];
                            dbase.Password = lines[3];
                            dbase.Program = lines[4];
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ayar dosyası bozuk!");
                        }

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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {

            }

        }   // OPEN SQLite

        public static void ClosemsConnection()
        {
            try
            {
                if (msConnection == null || msConnection.State.ToString() == "Open")
                {
                    msConnection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }   // CLOSE SQLite
        #endregion

    }
}
