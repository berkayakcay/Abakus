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
    public partial class Previous : Form
    {
        public Previous()
        {
            InitializeComponent();
        }

        #region Functions
        
        public void PreviousCounts()
        {
            dbase.OpenslConnection();
            dbase.slQueryText = "SELECT Name, Date FROM cdCount ORDER BY Date DESC";
            dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(dbase.slQueryText, dbase.slConnection);
                da.Fill(ds);
                dataGridViewCounts.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            dbase.CloseslConnection();
        }   // Populate Grid



        #endregion

        private void buttonResume_Click(object sender, EventArgs e)
        {
            Count pCount = new Count();
            pCount.Name = dataGridViewCounts.Rows[dataGridViewCounts.CurrentCell.RowIndex].Cells[0].Value.ToString();
            pCount.IsNew = false;
            pCount.IsOnline = checkBoxStatus.Checked;
            if (pCount.IsOnline)
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
                        //comboBoxProgram.SelectedText = lines[4];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        dbase.OpenmsConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (dbase.msConnection.State.ToString() == "Open")
                {
                    Counter frm = new Counter(pCount);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Counter frm = new Counter(pCount);
                this.Hide();
                frm.Show();
            }

        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.Show();
        }

        private void Previous_Load(object sender, EventArgs e)
        {
            PreviousCounts();
            checkBoxStatus.Checked = false;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Transfer frm = new Transfer();
            this.Hide();
            frm.Show();
        }
    }
}

