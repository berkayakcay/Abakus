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
    public partial class Counter : Form
    {
        Count CountDetail;
        public Counter(Count OffCount)
        {
            InitializeComponent();
            CountDetail = OffCount;
        }
        #region Functions

        

        public void AddNewLine(string barcode, int Qty)
        {
            if (CountDetail.IsOnline)
            {
                try
                {
                    dbase.OpenmsConnection();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dbase.msConnection.State.ToString() == "Open")
                {
                    bool IsExist = false;
                    dbase.msQueryText = "SELECT * FROM prItemBarcode WHERE Barcode = @Barcode";
                    dbase.msCommand = new SqlCommand(dbase.msQueryText, dbase.msConnection);
                    dbase.msCommand.Parameters.Add("@Barcode", SqlDbType.VarChar);
                    dbase.msCommand.Parameters["@Barcode"].Value = textBoxBarcode.Text.ToString();
                    dbase.msDataReader = dbase.msCommand.ExecuteReader();
                    while (dbase.msDataReader.Read())
                    {
                        try
                        {
                            dbase.OpenslConnection();
                            dbase.slQueryText = "INSERT INTO prCount (CountName, Barcode, Qty) VALUES('" + CountDetail.Name + "','" + barcode + "','" + Qty + "')";
                            dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
                            dbase.slCommand.ExecuteNonQuery();
                            dbase.CloseslConnection();
                            IsExist = true;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Barkod bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (!IsExist)
                    {
                        MessageBox.Show("Barkod bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewBarcodes.Rows.RemoveAt(dataGridViewBarcodes.Rows.Count - 2);
                    }

                    
                }
                else
                {
                    MessageBox.Show("Ayar dosyası bozuk", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dbase.ClosemsConnection();
            }
            else
            {
                dbase.OpenslConnection();
                dbase.slQueryText = "INSERT INTO prCount (CountName, Barcode, Qty) VALUES('" + CountDetail.Name + "','" + barcode + "','" + Qty + "')";
                dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
                dbase.slCommand.ExecuteNonQuery();
                dbase.CloseslConnection();
            }

        }   // New line
        #endregion

        #region Controls

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void checkBoxIsWithQty_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxIsWithQty.Checked == true)
            {
                textBoxQty.Enabled = true;
            }
            else
            {
                textBoxQty.Enabled = false;
            }

        }
        #endregion

        #region Form Elemetns
        private void Counter_Load(object sender, EventArgs e)
        {
            checkBoxIsWithQty.Checked = false;
            if (CountDetail.IsOnline)
            {
                labelTitle.Text = "Online : " + CountDetail.Name;
            }
            else
            {
                labelTitle.Text = "Offline : " + CountDetail.Name;
            }
            
            if (CountDetail.IsNew)
            {

            }
            else
            {
                dbase.OpenslConnection();
                dbase.slQueryText = "SELECT Barcode, Qty FROM prCount WHERE CountName = '" + CountDetail.Name + "'";
                dbase.slCommand = new SQLiteCommand(dbase.slQueryText, dbase.slConnection);
                dbase.slDataReader = dbase.slCommand.ExecuteReader();
                while (dbase.slDataReader.Read())
                {
                    dataGridViewBarcodes.Rows.Add(dbase.slDataReader["Barcode"].ToString(), dbase.slDataReader["Qty"].ToString());
                }
                dbase.CloseslConnection();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Main CountForm = new Main();
            this.Hide();
            CountForm.Show();
        }
        private void labelSave_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.Show();
        }

        #endregion

        private void textBoxBarcoce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkBoxIsWithQty.Checked)
                {
                    if (textBoxQty.Text == "")
                    {
                        dataGridViewBarcodes.Rows.Add(textBoxBarcode.Text.ToString(), "1");
                        AddNewLine(textBoxBarcode.Text.ToString(), 1);
                        
                    }
                    else
                    {
                        dataGridViewBarcodes.Rows.Add(textBoxBarcode.Text.ToString(), textBoxQty.Text.ToString());
                        AddNewLine(textBoxBarcode.Text.ToString(), int.Parse(textBoxQty.Text.ToString()));
                       
                    }

                }
                else
                {
                    dataGridViewBarcodes.Rows.Add(textBoxBarcode.Text.ToString(), "1");
                    AddNewLine(textBoxBarcode.Text.ToString(), 1);
                    
                }
                textBoxBarcode.Clear();
                textBoxBarcode.Focus();
            }
        }

        private void dataGridViewBarcodes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridViewBarcodes.Rows.Count > 0)
            {
                dataGridViewBarcodes.CurrentCell = dataGridViewBarcodes.Rows[dataGridViewBarcodes.Rows.Count - 1].Cells[0];
                dataGridViewBarcodes.Rows[e.RowIndex].Selected = true;
            }
        }


    }
}
