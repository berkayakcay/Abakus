using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Count
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Functions   ---   All functions inside

        private void ApplicationClose()
        {
            Environment.Exit(0);
        }   //Close this application

        private void AddNewCount(bool status)
        {
            try
            {
                Count nCount = new Count();
                nCount.IsOnline = status;
                nCount.IsNew = true;
                nCount.Name = textBoxCountName.Text.ToString();
                dbase.OpenslConnection();
                dbase.slQueryText = "SELECT Name FROM cdCount WHERE Name = '" + nCount.Name + "'";
                dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
                dbase.slDataReader = dbase.slCommand.ExecuteReader();
                while (dbase.slDataReader.Read())
                {
                    if (dbase.slDataReader["Name"].ToString() == textBoxCountName.Text.ToString())
                    {
                        MessageBox.Show("Kayıt var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nCount.IsNew = false;
                    }
                }

                if (nCount.IsNew)
                {
                    dbase.slQueryText = "INSERT INTO cdCount (Name,Date) VALUES('" + nCount.Name + "','" + DateTime.Now + "')";
                    dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
                    dbase.slCommand.ExecuteNonQuery();
                    dbase.CloseslConnection();
                    Counter frm = new Counter(nCount);
                    this.Hide();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }   // Add new count

        private void OpenCounter(bool status)
        {
            if (textBoxCountName.Text.ToString() == "")
            {
                labelCountInfo.Text = "Lütfen sayım adı giriniz...";
            }
            else
            {
                if (status)
                {
                    try
                    {
                        dbase.OpenmsConnection();
                        if (dbase.msConnection.State.ToString() == "Open")
                        {
                            AddNewCount(status);
                        }
                        else
                        {
                            MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    AddNewCount(status);
                }
            }

        }   //Create New Counter

        #endregion


        #region Form Elements   ---    All form elements inside

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            OpenCounter(true);
        }
        private void buttonOffline_Click(object sender, EventArgs e)
        {
            OpenCounter(false);
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Previous frm = new Previous();
            this.Hide();
            frm.Show();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            ApplicationClose();
        }
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            this.Hide();
            frm.Show();
        }

        #endregion      


    }
}
