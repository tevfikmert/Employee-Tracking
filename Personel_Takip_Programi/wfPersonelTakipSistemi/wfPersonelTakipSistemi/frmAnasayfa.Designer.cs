namespace wfPersonelTakipSistemi
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaiHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maaşHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnIzınIslemleri = new System.Windows.Forms.Button();
            this.btnMesaiIslemleri = new System.Windows.Forms.Button();
            this.btnMaasIslemleri = new System.Windows.Forms.Button();
            this.btnPrimler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.mesaiHareketleriToolStripMenuItem,
            this.izinHareketleriToolStripMenuItem,
            this.maaşHareketleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelToolStripMenuItem.Image")));
            this.personelToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.personelToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // mesaiHareketleriToolStripMenuItem
            // 
            this.mesaiHareketleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mesaiHareketleriToolStripMenuItem.Image")));
            this.mesaiHareketleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mesaiHareketleriToolStripMenuItem.Name = "mesaiHareketleriToolStripMenuItem";
            this.mesaiHareketleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.mesaiHareketleriToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.mesaiHareketleriToolStripMenuItem.Text = "Mesai Hareketleri";
            this.mesaiHareketleriToolStripMenuItem.Click += new System.EventHandler(this.mesaiHareketleriToolStripMenuItem_Click);
            // 
            // izinHareketleriToolStripMenuItem
            // 
            this.izinHareketleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izinHareketleriToolStripMenuItem.Image")));
            this.izinHareketleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.izinHareketleriToolStripMenuItem.Name = "izinHareketleriToolStripMenuItem";
            this.izinHareketleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.izinHareketleriToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.izinHareketleriToolStripMenuItem.Text = "İzin Hareketleri";
            this.izinHareketleriToolStripMenuItem.Click += new System.EventHandler(this.izinHareketleriToolStripMenuItem_Click_1);
            // 
            // maaşHareketleriToolStripMenuItem
            // 
            this.maaşHareketleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maaşHareketleriToolStripMenuItem.Image")));
            this.maaşHareketleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maaşHareketleriToolStripMenuItem.Name = "maaşHareketleriToolStripMenuItem";
            this.maaşHareketleriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.maaşHareketleriToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.maaşHareketleriToolStripMenuItem.Text = "Maaş İşlemleri";
            this.maaşHareketleriToolStripMenuItem.Click += new System.EventHandler(this.maaşHareketleriToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Cyan;
            this.btnPersonel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.BackgroundImage")));
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPersonel.Location = new System.Drawing.Point(81, 119);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(226, 103);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnIzınIslemleri
            // 
            this.btnIzınIslemleri.BackColor = System.Drawing.Color.Cyan;
            this.btnIzınIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzınIslemleri.BackgroundImage")));
            this.btnIzınIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzınIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzınIslemleri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzınIslemleri.Location = new System.Drawing.Point(555, 119);
            this.btnIzınIslemleri.Name = "btnIzınIslemleri";
            this.btnIzınIslemleri.Size = new System.Drawing.Size(226, 103);
            this.btnIzınIslemleri.TabIndex = 2;
            this.btnIzınIslemleri.UseVisualStyleBackColor = false;
            this.btnIzınIslemleri.Click += new System.EventHandler(this.btnIzınIslemleri_Click);
            // 
            // btnMesaiIslemleri
            // 
            this.btnMesaiIslemleri.BackColor = System.Drawing.Color.Cyan;
            this.btnMesaiIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesaiIslemleri.BackgroundImage")));
            this.btnMesaiIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesaiIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiIslemleri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMesaiIslemleri.Location = new System.Drawing.Point(318, 119);
            this.btnMesaiIslemleri.Name = "btnMesaiIslemleri";
            this.btnMesaiIslemleri.Size = new System.Drawing.Size(226, 103);
            this.btnMesaiIslemleri.TabIndex = 3;
            this.btnMesaiIslemleri.UseVisualStyleBackColor = false;
            this.btnMesaiIslemleri.Click += new System.EventHandler(this.btnMesaiIslemleri_Click);
            // 
            // btnMaasIslemleri
            // 
            this.btnMaasIslemleri.BackColor = System.Drawing.Color.Cyan;
            this.btnMaasIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaasIslemleri.BackgroundImage")));
            this.btnMaasIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaasIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasIslemleri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaasIslemleri.Location = new System.Drawing.Point(81, 248);
            this.btnMaasIslemleri.Name = "btnMaasIslemleri";
            this.btnMaasIslemleri.Size = new System.Drawing.Size(226, 103);
            this.btnMaasIslemleri.TabIndex = 4;
            this.btnMaasIslemleri.UseVisualStyleBackColor = false;
            this.btnMaasIslemleri.Click += new System.EventHandler(this.btnMaasIslemleri_Click);
            // 
            // btnPrimler
            // 
            this.btnPrimler.BackColor = System.Drawing.Color.Cyan;
            this.btnPrimler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrimler.BackgroundImage")));
            this.btnPrimler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrimler.Location = new System.Drawing.Point(318, 248);
            this.btnPrimler.Name = "btnPrimler";
            this.btnPrimler.Size = new System.Drawing.Size(226, 103);
            this.btnPrimler.TabIndex = 5;
            this.btnPrimler.UseVisualStyleBackColor = false;
            this.btnPrimler.Click += new System.EventHandler(this.btnPrimler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Cyan;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Location = new System.Drawing.Point(555, 248);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(226, 103);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 561);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnPrimler);
            this.Controls.Add(this.btnMaasIslemleri);
            this.Controls.Add(this.btnMesaiIslemleri);
            this.Controls.Add(this.btnIzınIslemleri);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmAnasayfa";
            this.Text = "PERSONEL TAKİP SİSTEMİ - ANA SAYFA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaiHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maaşHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnIzınIslemleri;
        private System.Windows.Forms.Button btnMesaiIslemleri;
        private System.Windows.Forms.Button btnMaasIslemleri;
        private System.Windows.Forms.Button btnPrimler;
        private System.Windows.Forms.Button btnCikis;
        internal static bool Disabled;
    }
}