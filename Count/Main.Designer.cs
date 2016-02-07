namespace Count
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelPrevious = new System.Windows.Forms.Label();
            this.labelOffline = new System.Windows.Forms.Label();
            this.labelOnline = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonOffline = new System.Windows.Forms.Button();
            this.buttonOnline = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCountInfo = new System.Windows.Forms.Label();
            this.textBoxCountName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelMiddle.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(4, 1);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 49);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.buttonOptions);
            this.panelMiddle.Controls.Add(this.labelOptions);
            this.panelMiddle.Controls.Add(this.labelPrevious);
            this.panelMiddle.Controls.Add(this.labelOffline);
            this.panelMiddle.Controls.Add(this.labelOnline);
            this.panelMiddle.Controls.Add(this.buttonPrevious);
            this.panelMiddle.Controls.Add(this.buttonOffline);
            this.panelMiddle.Controls.Add(this.buttonOnline);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 60);
            this.panelMiddle.Margin = new System.Windows.Forms.Padding(0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(240, 260);
            this.panelMiddle.TabIndex = 0;
            // 
            // buttonOptions
            // 
            this.buttonOptions.AutoSize = true;
            this.buttonOptions.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOptions.BackgroundImage")));
            this.buttonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(9, 150);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(50, 50);
            this.buttonOptions.TabIndex = 6;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // labelOptions
            // 
            this.labelOptions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.Location = new System.Drawing.Point(62, 150);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(167, 50);
            this.labelOptions.TabIndex = 5;
            this.labelOptions.Text = "PROGRAM AYAR";
            this.labelOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // labelPrevious
            // 
            this.labelPrevious.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevious.Location = new System.Drawing.Point(62, 100);
            this.labelPrevious.Name = "labelPrevious";
            this.labelPrevious.Size = new System.Drawing.Size(167, 50);
            this.labelPrevious.TabIndex = 5;
            this.labelPrevious.Text = "ÖNCEKİ SAYIM";
            this.labelPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelOffline
            // 
            this.labelOffline.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffline.Location = new System.Drawing.Point(62, 50);
            this.labelOffline.Name = "labelOffline";
            this.labelOffline.Size = new System.Drawing.Size(167, 50);
            this.labelOffline.TabIndex = 4;
            this.labelOffline.Text = "OFFLINE SAYIM";
            this.labelOffline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOffline.Click += new System.EventHandler(this.buttonOffline_Click);
            // 
            // labelOnline
            // 
            this.labelOnline.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnline.Location = new System.Drawing.Point(62, 0);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(167, 50);
            this.labelOnline.TabIndex = 0;
            this.labelOnline.Text = "ONLINE SAYIM";
            this.labelOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOnline.Click += new System.EventHandler(this.buttonOnline_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.BackgroundImage")));
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Location = new System.Drawing.Point(9, 100);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(50, 50);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonOffline
            // 
            this.buttonOffline.AutoSize = true;
            this.buttonOffline.BackColor = System.Drawing.Color.Transparent;
            this.buttonOffline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOffline.BackgroundImage")));
            this.buttonOffline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOffline.FlatAppearance.BorderSize = 0;
            this.buttonOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOffline.Location = new System.Drawing.Point(9, 50);
            this.buttonOffline.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOffline.Name = "buttonOffline";
            this.buttonOffline.Size = new System.Drawing.Size(50, 50);
            this.buttonOffline.TabIndex = 2;
            this.buttonOffline.UseVisualStyleBackColor = false;
            this.buttonOffline.Click += new System.EventHandler(this.buttonOffline_Click);
            // 
            // buttonOnline
            // 
            this.buttonOnline.AutoSize = true;
            this.buttonOnline.BackColor = System.Drawing.Color.Transparent;
            this.buttonOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOnline.BackgroundImage")));
            this.buttonOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOnline.FlatAppearance.BorderSize = 0;
            this.buttonOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnline.Location = new System.Drawing.Point(9, 0);
            this.buttonOnline.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(50, 50);
            this.buttonOnline.TabIndex = 1;
            this.buttonOnline.UseVisualStyleBackColor = false;
            this.buttonOnline.Click += new System.EventHandler(this.buttonOnline_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelCountInfo);
            this.panelTop.Controls.Add(this.textBoxCountName);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(240, 60);
            this.panelTop.TabIndex = 1;
            // 
            // labelCountInfo
            // 
            this.labelCountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCountInfo.ForeColor = System.Drawing.Color.Red;
            this.labelCountInfo.Location = new System.Drawing.Point(0, 43);
            this.labelCountInfo.Name = "labelCountInfo";
            this.labelCountInfo.Size = new System.Drawing.Size(240, 18);
            this.labelCountInfo.TabIndex = 2;
            // 
            // textBoxCountName
            // 
            this.textBoxCountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountName.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxCountName.Location = new System.Drawing.Point(0, 21);
            this.textBoxCountName.MaxLength = 50;
            this.textBoxCountName.Name = "textBoxCountName";
            this.textBoxCountName.Size = new System.Drawing.Size(240, 22);
            this.textBoxCountName.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(240, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ON/OFF SAYIM";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelClose);
            this.panelBottom.Controls.Add(this.buttonClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 270);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(240, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // labelClose
            // 
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(57, 1);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(172, 49);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "PROGRAMI KAPAT";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count";
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelOffline;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonOffline;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrevious;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.TextBox textBoxCountName;
        private System.Windows.Forms.Label labelCountInfo;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelOnline;
        private System.Windows.Forms.Button buttonOnline;
    }
}