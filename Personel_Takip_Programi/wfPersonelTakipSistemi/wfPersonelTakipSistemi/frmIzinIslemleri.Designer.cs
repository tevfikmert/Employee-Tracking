namespace wfPersonelTakipSistemi
{
    partial class frmIzinIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzinIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIzinTipi = new System.Windows.Forms.ComboBox();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpIzinBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpIzinBitis = new System.Windows.Forms.DateTimePicker();
            this.lvIzinHareketleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtToplamRaporlu = new System.Windows.Forms.TextBox();
            this.txtToplamUcretli = new System.Windows.Forms.TextBox();
            this.txtToplamUcretsiz = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKalanIzin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIzinTipi = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIzinID = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtIzinleriSifirla = new System.Windows.Forms.Button();
            this.btnLimitGuncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(94, 22);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.ReadOnly = true;
            this.txtPersonelID.Size = new System.Drawing.Size(38, 22);
            this.txtPersonelID.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(94, 47);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(114, 22);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(94, 72);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(114, 22);
            this.txtSoyadi.TabIndex = 5;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İzin Tipi:";
            // 
            // cbIzinTipi
            // 
            this.cbIzinTipi.DropDownWidth = 60;
            this.cbIzinTipi.FormattingEnabled = true;
            this.cbIzinTipi.Items.AddRange(new object[] {
            "Raporlu",
            "Ücretli",
            "Ücretsiz"});
            this.cbIzinTipi.Location = new System.Drawing.Point(207, 59);
            this.cbIzinTipi.Name = "cbIzinTipi";
            this.cbIzinTipi.Size = new System.Drawing.Size(16, 24);
            this.cbIzinTipi.TabIndex = 8;
            this.cbIzinTipi.Text = "Ücretsiz";
            this.cbIzinTipi.SelectedIndexChanged += new System.EventHandler(this.cbIzinTipi_SelectedIndexChanged);
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(94, 87);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.ReadOnly = true;
            this.txtGunSayisi.Size = new System.Drawing.Size(38, 22);
            this.txtGunSayisi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "İzin Gün Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "İzin Başlangıç:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "İzin Bitiş:";
            // 
            // dtpIzinBaslangic
            // 
            this.dtpIzinBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIzinBaslangic.Location = new System.Drawing.Point(207, 113);
            this.dtpIzinBaslangic.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.dtpIzinBaslangic.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpIzinBaslangic.Name = "dtpIzinBaslangic";
            this.dtpIzinBaslangic.Size = new System.Drawing.Size(16, 22);
            this.dtpIzinBaslangic.TabIndex = 15;
            this.dtpIzinBaslangic.Value = new System.DateTime(2016, 9, 30, 22, 59, 53, 0);
            this.dtpIzinBaslangic.ValueChanged += new System.EventHandler(this.dtpIzinBaslangic_ValueChanged);
            // 
            // dtpIzinBitis
            // 
            this.dtpIzinBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIzinBitis.Location = new System.Drawing.Point(207, 139);
            this.dtpIzinBitis.Name = "dtpIzinBitis";
            this.dtpIzinBitis.Size = new System.Drawing.Size(16, 22);
            this.dtpIzinBitis.TabIndex = 16;
            this.dtpIzinBitis.ValueChanged += new System.EventHandler(this.dtpIzinBitis_ValueChanged);
            // 
            // lvIzinHareketleri
            // 
            this.lvIzinHareketleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvIzinHareketleri.FullRowSelect = true;
            this.lvIzinHareketleri.Location = new System.Drawing.Point(368, 291);
            this.lvIzinHareketleri.Name = "lvIzinHareketleri";
            this.lvIzinHareketleri.Size = new System.Drawing.Size(523, 178);
            this.lvIzinHareketleri.TabIndex = 17;
            this.lvIzinHareketleri.UseCompatibleStateImageBehavior = false;
            this.lvIzinHareketleri.View = System.Windows.Forms.View.Details;
            this.lvIzinHareketleri.DoubleClick += new System.EventHandler(this.lvIzinHareketleri_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İzin Tipi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İzin Gün Sayısı";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İzin Başlangıç";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İzin Bitiş";
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.Location = new System.Drawing.Point(368, 53);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(523, 192);
            this.lvPersonel.TabIndex = 18;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.SelectedIndexChanged += new System.EventHandler(this.lvPersonel_SelectedIndexChanged);
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 46;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Adı";
            this.columnHeader9.Width = 72;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Soyadı";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Telefon";
            this.columnHeader11.Width = 73;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adres";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Raporlu";
            this.columnHeader14.Width = 53;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ucretli";
            this.columnHeader15.Width = 44;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ucretsiz";
            this.columnHeader16.Width = 56;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(47, 338);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(63, 36);
            this.btnYeni.TabIndex = 22;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtToplamRaporlu);
            this.groupBox1.Controls.Add(this.txtToplamUcretli);
            this.groupBox1.Controls.Add(this.txtToplamUcretsiz);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 105);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(231, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Raporlu Top.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(231, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ücretli Top.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(231, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "ÜcretsizTop.";
            // 
            // txtToplamRaporlu
            // 
            this.txtToplamRaporlu.Location = new System.Drawing.Point(302, 21);
            this.txtToplamRaporlu.Name = "txtToplamRaporlu";
            this.txtToplamRaporlu.ReadOnly = true;
            this.txtToplamRaporlu.Size = new System.Drawing.Size(39, 22);
            this.txtToplamRaporlu.TabIndex = 8;
            // 
            // txtToplamUcretli
            // 
            this.txtToplamUcretli.Location = new System.Drawing.Point(302, 47);
            this.txtToplamUcretli.Name = "txtToplamUcretli";
            this.txtToplamUcretli.ReadOnly = true;
            this.txtToplamUcretli.Size = new System.Drawing.Size(39, 22);
            this.txtToplamUcretli.TabIndex = 6;
            // 
            // txtToplamUcretsiz
            // 
            this.txtToplamUcretsiz.Location = new System.Drawing.Point(302, 72);
            this.txtToplamUcretsiz.Name = "txtToplamUcretsiz";
            this.txtToplamUcretsiz.ReadOnly = true;
            this.txtToplamUcretsiz.Size = new System.Drawing.Size(39, 22);
            this.txtToplamUcretsiz.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKalanIzin);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtIzinTipi);
            this.groupBox2.Controls.Add(this.txtBitis);
            this.groupBox2.Controls.Add(this.txtBaslangic);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIzinID);
            this.groupBox2.Controls.Add(this.txtGunSayisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbIzinTipi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpIzinBitis);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpIzinBaslangic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 174);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İzin Bilgileri";
            // 
            // txtKalanIzin
            // 
            this.txtKalanIzin.Location = new System.Drawing.Point(290, 85);
            this.txtKalanIzin.Name = "txtKalanIzin";
            this.txtKalanIzin.ReadOnly = true;
            this.txtKalanIzin.Size = new System.Drawing.Size(51, 22);
            this.txtKalanIzin.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(231, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Kalan İzin";
            // 
            // txtIzinTipi
            // 
            this.txtIzinTipi.Location = new System.Drawing.Point(94, 60);
            this.txtIzinTipi.Name = "txtIzinTipi";
            this.txtIzinTipi.ReadOnly = true;
            this.txtIzinTipi.Size = new System.Drawing.Size(114, 22);
            this.txtIzinTipi.TabIndex = 21;
            this.txtIzinTipi.TextChanged += new System.EventHandler(this.txtIzinTipi_TextChanged);
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(94, 139);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.ReadOnly = true;
            this.txtBitis.Size = new System.Drawing.Size(114, 22);
            this.txtBitis.TabIndex = 20;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(94, 113);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.ReadOnly = true;
            this.txtBaslangic.Size = new System.Drawing.Size(114, 22);
            this.txtBaslangic.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "İzin ID:";
            // 
            // txtIzinID
            // 
            this.txtIzinID.Location = new System.Drawing.Point(94, 32);
            this.txtIzinID.Name = "txtIzinID";
            this.txtIzinID.ReadOnly = true;
            this.txtIzinID.Size = new System.Drawing.Size(129, 22);
            this.txtIzinID.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(116, 338);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 36);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(185, 338);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(63, 36);
            this.btnDegistir.TabIndex = 26;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(254, 338);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(63, 36);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtIzinleriSifirla
            // 
            this.txtIzinleriSifirla.Location = new System.Drawing.Point(47, 401);
            this.txtIzinleriSifirla.Name = "txtIzinleriSifirla";
            this.txtIzinleriSifirla.Size = new System.Drawing.Size(132, 36);
            this.txtIzinleriSifirla.TabIndex = 28;
            this.txtIzinleriSifirla.Text = "Yıllık İzinleri Sıfırla";
            this.txtIzinleriSifirla.UseVisualStyleBackColor = true;
            this.txtIzinleriSifirla.Click += new System.EventHandler(this.txtIzinleriSifirla_Click);
            // 
            // btnLimitGuncelle
            // 
            this.btnLimitGuncelle.Location = new System.Drawing.Point(185, 401);
            this.btnLimitGuncelle.Name = "btnLimitGuncelle";
            this.btnLimitGuncelle.Size = new System.Drawing.Size(132, 36);
            this.btnLimitGuncelle.TabIndex = 29;
            this.btnLimitGuncelle.Text = "İzin Limitlerini Güncelle";
            this.btnLimitGuncelle.UseVisualStyleBackColor = true;
            this.btnLimitGuncelle.Click += new System.EventHandler(this.btnLimitGuncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(368, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "PERSONEL LİSTESİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(368, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "PERSONEL İZİN HAREKETLERİ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmIzinIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 481);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimitGuncelle);
            this.Controls.Add(this.txtIzinleriSifirla);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.lvIzinHareketleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIzinIslemleri";
            this.Text = "İZİN İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmIzinIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIzinTipi;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIzinBitis;
        private System.Windows.Forms.ListView lvIzinHareketleri;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIzinID;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.DateTimePicker dtpIzinBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtIzinTipi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtToplamRaporlu;
        private System.Windows.Forms.TextBox txtToplamUcretli;
        private System.Windows.Forms.TextBox txtToplamUcretsiz;
        private System.Windows.Forms.TextBox txtKalanIzin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button txtIzinleriSifirla;
        private System.Windows.Forms.Button btnLimitGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}