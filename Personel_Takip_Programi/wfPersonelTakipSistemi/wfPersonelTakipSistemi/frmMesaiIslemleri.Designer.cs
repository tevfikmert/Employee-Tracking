namespace wfPersonelTakipSistemi
{
    partial class frmMesaiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiIslemleri));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvMesai = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpMesaiTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtMesaiTarih = new System.Windows.Forms.TextBox();
            this.cbDonemAy = new System.Windows.Forms.ComboBox();
            this.cbDonemYil = new System.Windows.Forms.ComboBox();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtCikis = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.cbGirisSaat = new System.Windows.Forms.ComboBox();
            this.cbGirisDakika = new System.Windows.Forms.ComboBox();
            this.cbCikisSaat = new System.Windows.Forms.ComboBox();
            this.cbCikisDakika = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "* Silme işlemi için listeden personel seçiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(261, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "PERSONEL LİSTESİ";
            // 
            // lvMesai
            // 
            this.lvMesai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvMesai.FullRowSelect = true;
            this.lvMesai.Location = new System.Drawing.Point(255, 305);
            this.lvMesai.Name = "lvMesai";
            this.lvMesai.Size = new System.Drawing.Size(580, 144);
            this.lvMesai.TabIndex = 27;
            this.lvMesai.UseCompatibleStateImageBehavior = false;
            this.lvMesai.View = System.Windows.Forms.View.Details;
            this.lvMesai.DoubleClick += new System.EventHandler(this.lvMesai_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MesaiID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mesai Tarih";
            this.columnHeader10.Width = 113;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ad";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Soyad";
            this.columnHeader12.Width = 69;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giriş Saat";
            this.columnHeader13.Width = 76;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Çıkış Saat";
            this.columnHeader14.Width = 84;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Dönem";
            this.columnHeader15.Width = 183;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "* Lütfen mesai eklemek istediğiniz personeli listeden tıklayarak seçiniz.";
            // 
            // dtpMesaiTarih
            // 
            this.dtpMesaiTarih.Location = new System.Drawing.Point(211, 66);
            this.dtpMesaiTarih.Name = "dtpMesaiTarih";
            this.dtpMesaiTarih.Size = new System.Drawing.Size(19, 20);
            this.dtpMesaiTarih.TabIndex = 22;
            this.dtpMesaiTarih.ValueChanged += new System.EventHandler(this.dtpMesaiTarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mesai Günü:";
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.Location = new System.Drawing.Point(255, 63);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(580, 183);
            this.lvPersonel.TabIndex = 33;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyadı";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 63;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adres";
            this.columnHeader6.Width = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Dönem:";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(140, 390);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 36);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(46, 390);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 36);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(140, 348);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(86, 36);
            this.btnDegistir.TabIndex = 37;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(46, 348);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(86, 36);
            this.btnYeni.TabIndex = 36;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(116, 165);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(114, 20);
            this.txtAdi.TabIndex = 43;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(116, 140);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.ReadOnly = true;
            this.txtPersonelID.Size = new System.Drawing.Size(38, 20);
            this.txtPersonelID.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(116, 190);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(114, 20);
            this.txtSoyadi.TabIndex = 45;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(34, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Giriş Saati:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Çıkış Saati:";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(37, 210);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.ReadOnly = true;
            this.txtMesaiID.Size = new System.Drawing.Size(22, 20);
            this.txtMesaiID.TabIndex = 52;
            // 
            // txtMesaiTarih
            // 
            this.txtMesaiTarih.Location = new System.Drawing.Point(116, 66);
            this.txtMesaiTarih.Name = "txtMesaiTarih";
            this.txtMesaiTarih.ReadOnly = true;
            this.txtMesaiTarih.Size = new System.Drawing.Size(98, 20);
            this.txtMesaiTarih.TabIndex = 53;
            this.txtMesaiTarih.TextChanged += new System.EventHandler(this.txtMesaiTarih_TextChanged);
            // 
            // cbDonemAy
            // 
            this.cbDonemAy.FormattingEnabled = true;
            this.cbDonemAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbDonemAy.Location = new System.Drawing.Point(116, 113);
            this.cbDonemAy.Name = "cbDonemAy";
            this.cbDonemAy.Size = new System.Drawing.Size(38, 21);
            this.cbDonemAy.TabIndex = 54;
            this.cbDonemAy.SelectedIndexChanged += new System.EventHandler(this.cbDonemAy_SelectedIndexChanged);
            // 
            // cbDonemYil
            // 
            this.cbDonemYil.FormattingEnabled = true;
            this.cbDonemYil.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbDonemYil.Location = new System.Drawing.Point(164, 113);
            this.cbDonemYil.Name = "cbDonemYil";
            this.cbDonemYil.Size = new System.Drawing.Size(65, 21);
            this.cbDonemYil.TabIndex = 55;
            this.cbDonemYil.SelectedIndexChanged += new System.EventHandler(this.cbDonemYil_SelectedIndexChanged);
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(116, 90);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.ReadOnly = true;
            this.txtDonem.Size = new System.Drawing.Size(62, 20);
            this.txtDonem.TabIndex = 56;
            this.txtDonem.TextChanged += new System.EventHandler(this.txtDonem_TextChanged);
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(116, 226);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(38, 20);
            this.txtGiris.TabIndex = 57;
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(116, 252);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(38, 20);
            this.txtCikis.TabIndex = 58;
            // 
            // btnGetir
            // 
            this.btnGetir.Enabled = false;
            this.btnGetir.Location = new System.Drawing.Point(46, 313);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(181, 21);
            this.btnGetir.TabIndex = 59;
            this.btnGetir.Text = "Personelin Tüm Mesailerini Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // cbGirisSaat
            // 
            this.cbGirisSaat.FormattingEnabled = true;
            this.cbGirisSaat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbGirisSaat.Location = new System.Drawing.Point(160, 226);
            this.cbGirisSaat.Name = "cbGirisSaat";
            this.cbGirisSaat.Size = new System.Drawing.Size(38, 21);
            this.cbGirisSaat.TabIndex = 60;
            this.cbGirisSaat.SelectedIndexChanged += new System.EventHandler(this.cbGirisSaat_SelectedIndexChanged);
            // 
            // cbGirisDakika
            // 
            this.cbGirisDakika.FormattingEnabled = true;
            this.cbGirisDakika.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbGirisDakika.Location = new System.Drawing.Point(204, 226);
            this.cbGirisDakika.Name = "cbGirisDakika";
            this.cbGirisDakika.Size = new System.Drawing.Size(38, 21);
            this.cbGirisDakika.TabIndex = 61;
            this.cbGirisDakika.SelectedIndexChanged += new System.EventHandler(this.cbGirisDakika_SelectedIndexChanged);
            // 
            // cbCikisSaat
            // 
            this.cbCikisSaat.FormattingEnabled = true;
            this.cbCikisSaat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbCikisSaat.Location = new System.Drawing.Point(160, 252);
            this.cbCikisSaat.Name = "cbCikisSaat";
            this.cbCikisSaat.Size = new System.Drawing.Size(38, 21);
            this.cbCikisSaat.TabIndex = 62;
            this.cbCikisSaat.SelectedIndexChanged += new System.EventHandler(this.cbCikisSaat_SelectedIndexChanged);
            // 
            // cbCikisDakika
            // 
            this.cbCikisDakika.FormattingEnabled = true;
            this.cbCikisDakika.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbCikisDakika.Location = new System.Drawing.Point(204, 253);
            this.cbCikisDakika.Name = "cbCikisDakika";
            this.cbCikisDakika.Size = new System.Drawing.Size(38, 21);
            this.cbCikisDakika.TabIndex = 63;
            this.cbCikisDakika.SelectedIndexChanged += new System.EventHandler(this.cbCikisDakika_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(261, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "MESAİ LİSTESİ";
            // 
            // frmMesaiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCikisDakika);
            this.Controls.Add(this.cbCikisSaat);
            this.Controls.Add(this.cbGirisDakika);
            this.Controls.Add(this.cbGirisSaat);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtCikis);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.cbDonemYil);
            this.Controls.Add(this.cbDonemAy);
            this.Controls.Add(this.txtMesaiTarih);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvMesai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpMesaiTarih);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMesaiIslemleri";
            this.Text = "MESAİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmMesaiIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvMesai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpMesaiTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtMesaiTarih;
        private System.Windows.Forms.ComboBox cbDonemAy;
        private System.Windows.Forms.ComboBox cbDonemYil;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtCikis;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ComboBox cbGirisSaat;
        private System.Windows.Forms.ComboBox cbGirisDakika;
        private System.Windows.Forms.ComboBox cbCikisSaat;
        private System.Windows.Forms.ComboBox cbCikisDakika;
        private System.Windows.Forms.Label label4;
    }
}