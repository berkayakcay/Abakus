namespace Count
{
    partial class Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.checkBoxIsWithQty = new System.Windows.Forms.CheckBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelSave = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.dataGridViewBarcodes = new System.Windows.Forms.DataGridView();
            this.Barcodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarcodes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBoxQty);
            this.panelTop.Controls.Add(this.checkBoxIsWithQty);
            this.panelTop.Controls.Add(this.textBoxBarcode);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(240, 50);
            this.panelTop.TabIndex = 1;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Enabled = false;
            this.textBoxQty.Location = new System.Drawing.Point(205, 4);
            this.textBoxQty.MaxLength = 9999;
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(32, 20);
            this.textBoxQty.TabIndex = 106;
            // 
            // checkBoxIsWithQty
            // 
            this.checkBoxIsWithQty.AutoSize = true;
            this.checkBoxIsWithQty.Checked = true;
            this.checkBoxIsWithQty.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxIsWithQty.Location = new System.Drawing.Point(140, 6);
            this.checkBoxIsWithQty.Name = "checkBoxIsWithQty";
            this.checkBoxIsWithQty.Size = new System.Drawing.Size(59, 17);
            this.checkBoxIsWithQty.TabIndex = 105;
            this.checkBoxIsWithQty.Text = "Miktarlı";
            this.checkBoxIsWithQty.UseVisualStyleBackColor = true;
            this.checkBoxIsWithQty.CheckedChanged += new System.EventHandler(this.checkBoxIsWithQty_CheckedChanged);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.ForeColor = System.Drawing.Color.Green;
            this.textBoxBarcode.Location = new System.Drawing.Point(0, 28);
            this.textBoxBarcode.MaxLength = 25;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(240, 22);
            this.textBoxBarcode.TabIndex = 2;
            this.textBoxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarcoce_KeyDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "OFFLINE SAYIM";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelSave);
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 270);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(240, 50);
            this.panelBottom.TabIndex = 3;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Location = new System.Drawing.Point(75, 13);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(153, 24);
            this.labelSave.TabIndex = 8;
            this.labelSave.Text = "SAYIMI KAYDET";
            this.labelSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(9, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 50);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.dataGridViewBarcodes);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 50);
            this.panelMiddle.Margin = new System.Windows.Forms.Padding(0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(240, 220);
            this.panelMiddle.TabIndex = 4;
            // 
            // dataGridViewBarcodes
            // 
            this.dataGridViewBarcodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBarcodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarcodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcodes,
            this.Qty});
            this.dataGridViewBarcodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBarcodes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBarcodes.MultiSelect = false;
            this.dataGridViewBarcodes.Name = "dataGridViewBarcodes";
            this.dataGridViewBarcodes.ReadOnly = true;
            this.dataGridViewBarcodes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewBarcodes.RowHeadersWidth = 25;
            this.dataGridViewBarcodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBarcodes.Size = new System.Drawing.Size(240, 220);
            this.dataGridViewBarcodes.TabIndex = 0;
            this.dataGridViewBarcodes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewBarcodes_RowsAdded);
            // 
            // Barcodes
            // 
            this.Barcodes.HeaderText = "Barkod";
            this.Barcodes.Name = "Barcodes";
            this.Barcodes.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Miktar";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline";
            this.Load += new System.EventHandler(this.Counter_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarcodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewBarcodes;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.CheckBox checkBoxIsWithQty;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}