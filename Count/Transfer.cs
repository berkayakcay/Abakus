using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Count
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            PreviousCounts();

            if (System.IO.File.Exists(@"Settings.txt"))
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(@"Settings.txt");
                    textBoxServer.Text = lines[0];
                    textBoxDataBase.Text = lines[1];
                    textBoxUser.Text = lines[2];
                    textBoxPassword.Text = lines[3];
                    comboBoxProgram.Text = lines[4];
                }
                catch (Exception)
                {
                   labelOnlineInfo.Text = "Ayar dosyası bozuk!";
                }
            }
        }

        public void PreviousCounts()
        {
            dbase.OpenslConnection();
            dbase.slQueryText = "SELECT Name FROM cdCount ORDER BY Date DESC";
            dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
            dbase.slDataReader = dbase.slCommand.ExecuteReader();
            while (dbase.slDataReader.Read())
            {
                comboBoxCounts.Items.Add(dbase.slDataReader[0]);
            }

            dbase.CloseslConnection();
        }   // Populate Grid

        public string FixType()
        {
            switch (comboBoxCharacter.Text.ToString())
            {
                case "TAB":
                    return "\t";
                case "SPACE":
                    return " ";
                case "COMMA":
                    return ",";
                case "SEMICOL":
                    return ";";
                default:
                    return "\t";
            }
        }
        public void OfflineTransfer()
        {
            dbase.OpenslConnection();
            dbase.slQueryText = "SELECT Barcode, Qty FROM prCount WHERE CountName = '" + comboBoxCounts.Text.ToString() + "'";
            dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
            dbase.slDataReader = dbase.slCommand.ExecuteReader();

            List<string> TransferList = new List<string>();

            while (dbase.slDataReader.Read())
            {
                TransferList.Add(dbase.slDataReader["Barcode"].ToString() + FixType() + dbase.slDataReader["Qty"].ToString());
            }
            dbase.CloseslConnection();
            WriteTextFile.RW(TransferList, comboBoxCounts.Text.ToString());
            MessageBox.Show(comboBoxCounts.Text.ToString() + " isimli dosya aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void OnlineTransfer()
        {

            dbase.OpenslConnection();
            dbase.slQueryText = "SELECT Barcode, Qty FROM prCount WHERE CountName = '" + comboBoxCounts.Text.ToString() + "'";
            dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
            dbase.slDataReader = dbase.slCommand.ExecuteReader();

            dbase.OpenmsConnection();
            
            dbase.msQueryText = "SELECT Barcode,ItemCode,ColorCode,ItemDim1Code,ItemDim2Code,ItemDim3Code FROM prItemBarcode WHERE Barcode = @Barcode";
            dbase.msCommand = new SqlCommand(dbase.msQueryText, dbase.msConnection);
            dbase.msCommand.Parameters.Add("@Barcode", SqlDbType.VarChar);
            

            while (dbase.slDataReader.Read())
            {
                dbase.msCommand.Parameters["@Barcode"].Value = dbase.slDataReader["Barcode"].ToString();
                using (dbase.msDataReader = dbase.msCommand.ExecuteReader())
                {
                    while (dbase.msDataReader.Read())
                    {
                        SqlConnection cnn = new SqlConnection(dbase.Msconnectionstring.ToString());
                        cnn.Open();
                        string insert = string.Concat("INSERT INTO [dbo].[xlDepoEnvanteri] ([DepoKodu] ,[Barkod],[UrunKodu],[Renk],[Boyut1],[Boyut2],[Boyut3],[Miktar]) VALUES ('01' , '", dbase.msDataReader["Barcode"].ToString(), "','", dbase.msDataReader["ItemCode"].ToString(), "','", dbase.msDataReader["ColorCode"].ToString(), "','", dbase.msDataReader["ItemDim1Code"].ToString(), "','", dbase.msDataReader["ItemDim2Code"].ToString(), "','", dbase.msDataReader["ItemDim3Code"].ToString(), "','", dbase.slDataReader["Qty"].ToString(), "')");
                        SqlCommand cmd = new SqlCommand(insert, cnn);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }

            }
            dbase.ClosemsConnection();
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                dbase.OpenmsConnection();
                dbase.msCommand.Parameters.Clear();
                dbase.msCommand.Connection = dbase.msConnection;
                dbase.msCommand.CommandType = CommandType.StoredProcedure;
                dbase.msCommand.CommandText = "sp_ImportDepoEnvanteri";
                dbase.msCommand.Parameters.Add("@EnvanterTarihi", SqlDbType.Date);
                dbase.msCommand.Parameters["@EnvanterTarihi"].Value = DateTime.Now.Date;
                dbase.msCommand.ExecuteNonQuery();

                MessageBox.Show("Sayım fişi programa aktarıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dbase.msCommand.CommandType = CommandType.Text;
                dbase.msCommand.CommandText = "DELETE FROM [dbo].[xlDepoEnvanteri] WHERE HeaderID IS NOT NULL";
                dbase.msCommand.ExecuteNonQuery();
                dbase.ClosemsConnection();
                dbase.CloseslConnection();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString(),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }


        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (comboBoxCounts.Text == "")
            {
                MessageBox.Show("Sayım adı seçiniz","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (tabControlTransfer.SelectedTab.Text == "OFFLINE")
                {
                    if (comboBoxCharacter.Text == "")
                    {
                        MessageBox.Show("Ayırıcı karakter seçiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        OfflineTransfer();
                    }
                    
                }
                else
                {
                    OnlineTransfer();
                }
            }

        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            Previous frm = new Previous();
            this.Hide();
            frm.Show();
        }
    }
}
