namespace wfPersonelTakipSistemi
{
    partial class frmIzinLimitGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzinLimitGuncelle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtYeniLimit = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbIzinTipi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(166, 144);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 51);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtYeniLimit
            // 
            this.txtYeniLimit.Location = new System.Drawing.Point(16, 175);
            this.txtYeniLimit.Name = "txtYeniLimit";
            this.txtYeniLimit.Size = new System.Drawing.Size(100, 20);
            this.txtYeniLimit.TabIndex = 10;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(166, 82);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 9;
            // 
            // cbIzinTipi
            // 
            this.cbIzinTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzinTipi.FormattingEnabled = true;
            this.cbIzinTipi.Items.AddRange(new object[] {
            "Raporlu",
            "Ücretli",
            "Ücretsiz"});
            this.cbIzinTipi.Location = new System.Drawing.Point(16, 78);
            this.cbIzinTipi.Name = "cbIzinTipi";
            this.cbIzinTipi.Size = new System.Drawing.Size(121, 21);
            this.cbIzinTipi.TabIndex = 8;
            this.cbIzinTipi.SelectedIndexChanged += new System.EventHandler(this.cbIzinTipi_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "İZİN TİPİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(162, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "İZİN LİMİTİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "YENİ LİMİT";
            // 
            // frmIzinLimitGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniLimit);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.cbIzinTipi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIzinLimitGuncelle";
            this.Text = "İZİN LİMİTLERİ";
            this.Load += new System.EventHandler(this.frmIzinLimitGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtYeniLimit;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.ComboBox cbIzinTipi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}