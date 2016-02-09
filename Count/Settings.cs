using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.Sql;

namespace Count
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.Show();
        }

        public void ControlComponents()
        {
            if (textBoxServer.Text == "" && textBoxDataBase.Text == "" && textBoxServer.Text == "" && textBoxUser.Text == "" && textBoxPassword.Text == "" && comboBoxProgram.SelectedIndex > -1)
            {
                labelInfo.Text = "Tüm detayları doldurunuz...";
            }
            else
            {
                try
                {
                    dbase.ServerName = textBoxServer.Text.ToString();
                    dbase.DataBase = textBoxDataBase.Text.ToString();
                    dbase.User = textBoxUser.Text.ToString();
                    dbase.Password = textBoxPassword.Text.ToString();
                    dbase.Program = comboBoxProgram.SelectedText.ToString();
                    dbase.OpenmsConnection();
                    MessageBox.Show("Ayar dosyası hatasız", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dbase.ClosemsConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbase.ClosemsConnection();
                }
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ControlComponents();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Settings.txt", textBoxServer.Text.ToString() + Environment.NewLine + textBoxDataBase.Text.ToString() + Environment.NewLine + textBoxUser.Text.ToString() + Environment.NewLine + textBoxPassword.Text.ToString() + Environment.NewLine + comboBoxProgram.Text.ToString());
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"Settings.txt"))
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(@"Settings.txt");
                    textBoxServer.Text = lines[0];
                    textBoxDataBase.Text = lines[1];
                    textBoxUser.Text = lines[2];
                    textBoxPassword.Text = lines[3];
                    comboBoxProgram.SelectedText = lines[4];
                }
                catch (Exception)
                {
                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
