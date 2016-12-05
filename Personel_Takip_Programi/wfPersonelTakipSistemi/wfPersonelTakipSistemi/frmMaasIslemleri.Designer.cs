namespace wfPersonelTakipSistemi
{
    partial class frmMaasIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaasIslemleri));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOdenenMaaslar = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMaaslar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOdenecekTutar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCalistigiGun = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSabitMaas = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.txtToplamMaas = new System.Windows.Forms.TextBox();
            this.txtEksikMesai = new System.Windows.Forms.TextBox();
            this.txtFazlaMesai = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Eksik Mesai";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gün";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 57;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Borç";
            this.columnHeader22.Width = 101;
            // 
            // lvOdenenMaaslar
            // 
            this.lvOdenenMaaslar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.lvOdenenMaaslar.FullRowSelect = true;
            this.lvOdenenMaaslar.Location = new System.Drawing.Point(12, 337);
            this.lvOdenenMaaslar.Name = "lvOdenenMaaslar";
            this.lvOdenenMaaslar.Size = new System.Drawing.Size(662, 256);
            this.lvOdenenMaaslar.TabIndex = 147;
            this.lvOdenenMaaslar.UseCompatibleStateImageBehavior = false;
            this.lvOdenenMaaslar.View = System.Windows.Forms.View.Details;
            this.lvOdenenMaaslar.DoubleClick += new System.EventHandler(this.lvOdenenMaaslar_DoubleClick);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Maaş ID";
            this.columnHeader16.Width = 66;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Personel ID";
            this.columnHeader17.Width = 85;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Dönem";
            this.columnHeader18.Width = 82;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Gün";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Hakedilen Maaş";
            this.columnHeader20.Width = 96;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Alacak";
            this.columnHeader21.Width = 93;
            // 
            // cbDonem
            // 
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "10/2016",
            "11/2016",
            "12/2016"});
            this.cbDonem.Location = new System.Drawing.Point(973, 326);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(101, 21);
            this.cbDonem.TabIndex = 141;
            this.cbDonem.SelectedIndexChanged += new System.EventHandler(this.cbDonem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "Dönem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 145;
            this.label3.Text = "Personal ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Personel Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Personal Ad:";
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader15,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.Location = new System.Drawing.Point(725, 39);
            this.lvPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(582, 262);
            this.lvPersonel.TabIndex = 142;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 37;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "IBAN";
            this.columnHeader15.Width = 154;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Personel Adı";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 86;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Personel Soyadı";
            this.columnHeader12.Width = 94;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Telefon";
            this.columnHeader13.Width = 93;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Adres";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Toplam";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 77;
            // 
            // lvMaaslar
            // 
            this.lvMaaslar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.lvMaaslar.FullRowSelect = true;
            this.lvMaaslar.Location = new System.Drawing.Point(12, 39);
            this.lvMaaslar.Name = "lvMaaslar";
            this.lvMaaslar.Size = new System.Drawing.Size(662, 262);
            this.lvMaaslar.TabIndex = 140;
            this.lvMaaslar.UseCompatibleStateImageBehavior = false;
            this.lvMaaslar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dönem";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sabit Maaş";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fazla Mesai";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 99;
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.Location = new System.Drawing.Point(973, 501);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(100, 20);
            this.txtOdenecekTutar.TabIndex = 139;
            this.txtOdenecekTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(879, 504);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 138;
            this.label16.Text = "Ödenecek Tutar:";
            // 
            // txtCalistigiGun
            // 
            this.txtCalistigiGun.Location = new System.Drawing.Point(973, 434);
            this.txtCalistigiGun.Name = "txtCalistigiGun";
            this.txtCalistigiGun.ReadOnly = true;
            this.txtCalistigiGun.Size = new System.Drawing.Size(100, 20);
            this.txtCalistigiGun.TabIndex = 136;
            this.txtCalistigiGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(872, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 135;
            this.label14.Text = "Çalıştığı Gün Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "Toplam Maaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Sabit Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 131;
            this.label6.Text = "Eksik Mesai Kesintisi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(855, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 130;
            this.label7.Text = "Fazladan Mesai Ücreti:";
            // 
            // txtSabitMaas
            // 
            this.txtSabitMaas.Location = new System.Drawing.Point(973, 356);
            this.txtSabitMaas.Name = "txtSabitMaas";
            this.txtSabitMaas.ReadOnly = true;
            this.txtSabitMaas.Size = new System.Drawing.Size(100, 20);
            this.txtSabitMaas.TabIndex = 129;
            this.txtSabitMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(973, 541);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(101, 28);
            this.btnOde.TabIndex = 137;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // txtToplamMaas
            // 
            this.txtToplamMaas.Location = new System.Drawing.Point(973, 464);
            this.txtToplamMaas.Name = "txtToplamMaas";
            this.txtToplamMaas.ReadOnly = true;
            this.txtToplamMaas.Size = new System.Drawing.Size(100, 20);
            this.txtToplamMaas.TabIndex = 134;
            this.txtToplamMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEksikMesai
            // 
            this.txtEksikMesai.Location = new System.Drawing.Point(973, 408);
            this.txtEksikMesai.Name = "txtEksikMesai";
            this.txtEksikMesai.ReadOnly = true;
            this.txtEksikMesai.Size = new System.Drawing.Size(100, 20);
            this.txtEksikMesai.TabIndex = 128;
            this.txtEksikMesai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFazlaMesai
            // 
            this.txtFazlaMesai.Location = new System.Drawing.Point(973, 382);
            this.txtFazlaMesai.Name = "txtFazlaMesai";
            this.txtFazlaMesai.ReadOnly = true;
            this.txtFazlaMesai.Size = new System.Drawing.Size(100, 20);
            this.txtFazlaMesai.TabIndex = 127;
            this.txtFazlaMesai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(726, 541);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 28);
            this.btnHesapla.TabIndex = 126;
            this.btnHesapla.Text = "SİL";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(726, 345);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelID.TabIndex = 125;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(726, 387);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAd.TabIndex = 123;
            this.txtPersonelAd.TextChanged += new System.EventHandler(this.txtPersonelAd_TextChanged);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(726, 432);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyad.TabIndex = 124;
            this.txtPersonelSoyad.TextChanged += new System.EventHandler(this.txtPersonelSoyad_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1117, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 149;
            this.label9.Text = "MAAŞLAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(12, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 150;
            this.label10.Text = "ÖDENMİŞ MAAŞLAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(722, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 151;
            this.label11.Text = "PERSONEL LİSTESİ";
            // 
            // frmMaasIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 601);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvOdenenMaaslar);
            this.Controls.Add(this.cbDonem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.lvMaaslar);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCalistigiGun);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSabitMaas);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtToplamMaas);
            this.Controls.Add(this.txtEksikMesai);
            this.Controls.Add(this.txtFazlaMesai);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMaasIslemleri";
            this.Text = "MAAŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmMaasIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ListView lvOdenenMaaslar;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvMaaslar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtOdenecekTutar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCalistigiGun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSabitMaas;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.TextBox txtToplamMaas;
        private System.Windows.Forms.TextBox txtEksikMesai;
        private System.Windows.Forms.TextBox txtFazlaMesai;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}