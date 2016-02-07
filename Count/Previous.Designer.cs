namespace Count
{
    partial class Previous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Previous));
            this.dataGridViewCounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.ButtonBackToMain = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCounts
            // 
            this.dataGridViewCounts.AllowDrop = true;
            this.dataGridViewCounts.AllowUserToAddRows = false;
            this.dataGridViewCounts.AllowUserToDeleteRows = false;
            this.dataGridViewCounts.AllowUserToResizeRows = false;
            this.dataGridViewCounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCounts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCounts.GridColor = System.Drawing.Color.White;
            this.dataGridViewCounts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCounts.MultiSelect = false;
            this.dataGridViewCounts.Name = "dataGridViewCounts";
            this.dataGridViewCounts.ReadOnly = true;
            this.dataGridViewCounts.RowHeadersWidth = 25;
            this.dataGridViewCounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCounts.Size = new System.Drawing.Size(240, 236);
            this.dataGridViewCounts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTransfer);
            this.panel1.Controls.Add(this.checkBoxStatus);
            this.panel1.Controls.Add(this.ButtonBackToMain);
            this.panel1.Controls.Add(this.buttonResume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 60);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatus.Location = new System.Drawing.Point(139, 3);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(99, 19);
            this.checkBoxStatus.TabIndex = 1;
            this.checkBoxStatus.Text = "ONLINE SAY.";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // ButtonBackToMain
            // 
            this.ButtonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackToMain.Image")));
            this.ButtonBackToMain.Location = new System.Drawing.Point(0, 0);
            this.ButtonBackToMain.Name = "ButtonBackToMain";
            this.ButtonBackToMain.Size = new System.Drawing.Size(60, 60);
            this.ButtonBackToMain.TabIndex = 0;
            this.ButtonBackToMain.UseVisualStyleBackColor = true;
            this.ButtonBackToMain.Click += new System.EventHandler(this.ButtonBackToMain_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.Location = new System.Drawing.Point(139, 22);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(100, 38);
            this.buttonResume.TabIndex = 0;
            this.buttonResume.Text = "DEVAM";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖNCEKİ SAYIMLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCounts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 236);
            this.panel2.TabIndex = 4;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.Red;
            this.buttonTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTransfer.BackgroundImage")));
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.Location = new System.Drawing.Point(66, 0);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(67, 60);
            this.buttonTransfer.TabIndex = 2;
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // Previous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Previous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Previous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBackToMain;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTransfer;
    }
}