namespace Count
{
    partial class Transfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxCounts = new System.Windows.Forms.ComboBox();
            this.tabControlTransfer = new System.Windows.Forms.TabControl();
            this.tabPageOfline = new System.Windows.Forms.TabPage();
            this.comboBoxCharacter = new System.Windows.Forms.ComboBox();
            this.labelPathInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelOnlineInfo = new System.Windows.Forms.Label();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.labelProgram = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.labelDataBase = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.ButtonBackToMain = new System.Windows.Forms.Button();
            this.checkBoxSpecialChar = new System.Windows.Forms.CheckBox();
            this.textBoxSpecialChar = new System.Windows.Forms.TextBox();
            this.labelWareHouse = new System.Windows.Forms.Label();
            this.comboBoxWareHouse = new System.Windows.Forms.ComboBox();
            this.tabControlTransfer.SuspendLayout();
            this.tabPageOfline.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(240, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "SAYIMLARI AKTAR (Sayım Seçin)";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCounts
            // 
            this.comboBoxCounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCounts.FormattingEnabled = true;
            this.comboBoxCounts.Location = new System.Drawing.Point(0, 24);
            this.comboBoxCounts.Name = "comboBoxCounts";
            this.comboBoxCounts.Size = new System.Drawing.Size(240, 21);
            this.comboBoxCounts.TabIndex = 5;
            // 
            // tabControlTransfer
            // 
            this.tabControlTransfer.Controls.Add(this.tabPageOfline);
            this.tabControlTransfer.Controls.Add(this.tabPage2);
            this.tabControlTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTransfer.Location = new System.Drawing.Point(0, 45);
            this.tabControlTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlTransfer.Name = "tabControlTransfer";
            this.tabControlTransfer.SelectedIndex = 0;
            this.tabControlTransfer.Size = new System.Drawing.Size(240, 275);
            this.tabControlTransfer.TabIndex = 6;
            // 
            // tabPageOfline
            // 
            this.tabPageOfline.Controls.Add(this.textBoxSpecialChar);
            this.tabPageOfline.Controls.Add(this.checkBoxSpecialChar);
            this.tabPageOfline.Controls.Add(this.comboBoxCharacter);
            this.tabPageOfline.Controls.Add(this.labelPathInfo);
            this.tabPageOfline.Controls.Add(this.label1);
            this.tabPageOfline.Location = new System.Drawing.Point(4, 22);
            this.tabPageOfline.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageOfline.Name = "tabPageOfline";
            this.tabPageOfline.Size = new System.Drawing.Size(232, 249);
            this.tabPageOfline.TabIndex = 0;
            this.tabPageOfline.Text = "OFFLINE";
            this.tabPageOfline.UseVisualStyleBackColor = true;
            // 
            // comboBoxCharacter
            // 
            this.comboBoxCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharacter.FormattingEnabled = true;
            this.comboBoxCharacter.Items.AddRange(new object[] {
            "TAB",
            "SPACE",
            "COMMA",
            "SEMICOL"});
            this.comboBoxCharacter.Location = new System.Drawing.Point(136, 12);
            this.comboBoxCharacter.Name = "comboBoxCharacter";
            this.comboBoxCharacter.Size = new System.Drawing.Size(88, 21);
            this.comboBoxCharacter.TabIndex = 3;
            // 
            // labelPathInfo
            // 
            this.labelPathInfo.AutoSize = true;
            this.labelPathInfo.Location = new System.Drawing.Point(20, 177);
            this.labelPathInfo.Name = "labelPathInfo";
            this.labelPathInfo.Size = new System.Drawing.Size(194, 13);
            this.labelPathInfo.TabIndex = 2;
            this.labelPathInfo.Text = "Dosyalarınız Export Klasörüne Kaydedilir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod ve Miktar Ayırıcı : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelOnlineInfo);
            this.tabPage2.Controls.Add(this.comboBoxWareHouse);
            this.tabPage2.Controls.Add(this.comboBoxProgram);
            this.tabPage2.Controls.Add(this.labelWareHouse);
            this.tabPage2.Controls.Add(this.labelProgram);
            this.tabPage2.Controls.Add(this.textBoxPassword);
            this.tabPage2.Controls.Add(this.labelPassword);
            this.tabPage2.Controls.Add(this.textBoxUser);
            this.tabPage2.Controls.Add(this.labelUser);
            this.tabPage2.Controls.Add(this.textBoxDataBase);
            this.tabPage2.Controls.Add(this.labelDataBase);
            this.tabPage2.Controls.Add(this.textBoxServer);
            this.tabPage2.Controls.Add(this.labelServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ONLINE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelOnlineInfo
            // 
            this.labelOnlineInfo.AutoSize = true;
            this.labelOnlineInfo.Location = new System.Drawing.Point(9, 151);
            this.labelOnlineInfo.Name = "labelOnlineInfo";
            this.labelOnlineInfo.Size = new System.Drawing.Size(0, 13);
            this.labelOnlineInfo.TabIndex = 13;
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.Enabled = false;
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Items.AddRange(new object[] {
            "WINNER",
            "NEBIM V3"});
            this.comboBoxProgram.Location = new System.Drawing.Point(76, 117);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(148, 21);
            this.comboBoxProgram.TabIndex = 12;
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Enabled = false;
            this.labelProgram.Location = new System.Drawing.Point(6, 121);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(52, 13);
            this.labelProgram.TabIndex = 3;
            this.labelProgram.Text = "Program :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(76, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Enabled = false;
            this.labelPassword.Location = new System.Drawing.Point(6, 95);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(34, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Şifre :";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(76, 65);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(148, 20);
            this.textBoxUser.TabIndex = 9;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Enabled = false;
            this.labelUser.Location = new System.Drawing.Point(6, 69);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Kullanıcı : ";
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Enabled = false;
            this.textBoxDataBase.Location = new System.Drawing.Point(76, 39);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(148, 20);
            this.textBoxDataBase.TabIndex = 10;
            // 
            // labelDataBase
            // 
            this.labelDataBase.AutoSize = true;
            this.labelDataBase.Enabled = false;
            this.labelDataBase.Location = new System.Drawing.Point(6, 43);
            this.labelDataBase.Name = "labelDataBase";
            this.labelDataBase.Size = new System.Drawing.Size(70, 13);
            this.labelDataBase.TabIndex = 6;
            this.labelDataBase.Text = "Veri Tabanı : ";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Enabled = false;
            this.textBoxServer.Location = new System.Drawing.Point(76, 13);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(148, 20);
            this.textBoxServer.TabIndex = 11;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Enabled = false;
            this.labelServer.Location = new System.Drawing.Point(6, 17);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(53, 13);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Sunucu : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTransfer);
            this.panel1.Controls.Add(this.ButtonBackToMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 60);
            this.panel1.TabIndex = 7;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.Lime;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.Location = new System.Drawing.Point(59, 0);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(177, 60);
            this.buttonTransfer.TabIndex = 2;
            this.buttonTransfer.Text = "AKTAR";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // ButtonBackToMain
            // 
            this.ButtonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackToMain.Image")));
            this.ButtonBackToMain.Location = new System.Drawing.Point(0, 0);
            this.ButtonBackToMain.Name = "ButtonBackToMain";
            this.ButtonBackToMain.Size = new System.Drawing.Size(60, 60);
            this.ButtonBackToMain.TabIndex = 1;
            this.ButtonBackToMain.UseVisualStyleBackColor = true;
            this.ButtonBackToMain.Click += new System.EventHandler(this.ButtonBackToMain_Click);
            // 
            // checkBoxSpecialChar
            // 
            this.checkBoxSpecialChar.AutoSize = true;
            this.checkBoxSpecialChar.Location = new System.Drawing.Point(9, 54);
            this.checkBoxSpecialChar.Name = "checkBoxSpecialChar";
            this.checkBoxSpecialChar.Size = new System.Drawing.Size(129, 17);
            this.checkBoxSpecialChar.TabIndex = 4;
            this.checkBoxSpecialChar.Text = "Özel karakter kullan : ";
            this.checkBoxSpecialChar.UseVisualStyleBackColor = true;
            this.checkBoxSpecialChar.CheckedChanged += new System.EventHandler(this.checkBoxSpecialChar_CheckedChanged);
            // 
            // textBoxSpecialChar
            // 
            this.textBoxSpecialChar.Enabled = false;
            this.textBoxSpecialChar.Location = new System.Drawing.Point(136, 54);
            this.textBoxSpecialChar.MaxLength = 5;
            this.textBoxSpecialChar.Name = "textBoxSpecialChar";
            this.textBoxSpecialChar.Size = new System.Drawing.Size(88, 20);
            this.textBoxSpecialChar.TabIndex = 5;
            // 
            // labelWareHouse
            // 
            this.labelWareHouse.AutoSize = true;
            this.labelWareHouse.Location = new System.Drawing.Point(6, 151);
            this.labelWareHouse.Name = "labelWareHouse";
            this.labelWareHouse.Size = new System.Drawing.Size(42, 13);
            this.labelWareHouse.TabIndex = 3;
            this.labelWareHouse.Text = "Depo : ";
            // 
            // comboBoxWareHouse
            // 
            this.comboBoxWareHouse.FormattingEnabled = true;
            this.comboBoxWareHouse.Location = new System.Drawing.Point(76, 147);
            this.comboBoxWareHouse.Name = "comboBoxWareHouse";
            this.comboBoxWareHouse.Size = new System.Drawing.Size(148, 21);
            this.comboBoxWareHouse.TabIndex = 12;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlTransfer);
            this.Controls.Add(this.comboBoxCounts);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.tabControlTransfer.ResumeLayout(false);
            this.tabPageOfline.ResumeLayout(false);
            this.tabPageOfline.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxCounts;
        private System.Windows.Forms.TabControl tabControlTransfer;
        private System.Windows.Forms.TabPage tabPageOfline;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBackToMain;
        private System.Windows.Forms.Label labelPathInfo;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.ComboBox comboBoxCharacter;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.Label labelDataBase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelOnlineInfo;
        private System.Windows.Forms.TextBox textBoxSpecialChar;
        private System.Windows.Forms.CheckBox checkBoxSpecialChar;
        private System.Windows.Forms.ComboBox comboBoxWareHouse;
        private System.Windows.Forms.Label labelWareHouse;
    }
}