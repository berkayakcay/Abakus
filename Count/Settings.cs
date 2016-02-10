using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    dbase.msConnection = new SqlConnection("Server=" + textBoxServer.Text.ToString() + ";Database=" + textBoxDataBase.Text.ToString() + ";User Id=" + textBoxUser.Text.ToString() + ";Password=" + textBoxPassword.Text.ToString() + "; MultipleActiveResultSets=True;");
                    dbase.msConnection.Open();
                    if (dbase.msConnection.State.ToString() == "Open")
                    {
                        MessageBox.Show("Test sorunsuz bir şekilde gerçekleştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dbase.ClosemsConnection();
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen parametreler hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Belirtilen parametreler hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ControlComponents();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(@"Settings.txt", textBoxServer.Text.ToString() + Environment.NewLine + textBoxDataBase.Text.ToString() + Environment.NewLine + textBoxUser.Text.ToString() + Environment.NewLine + textBoxPassword.Text.ToString() + Environment.NewLine + comboBoxProgram.Text.ToString());
                MessageBox.Show("Ayarlar başarılı bir şekilde kaydedildi.", "Başarılı", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Belirtilern parametreler hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
