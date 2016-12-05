namespace wfPersonelTakipSistemi
{
    partial class frmPrimIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimIslemleri));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPersonelSec = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader13
            // 
            this.columnHeader13.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adı";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TCKN";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dönem";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Prim Tutar";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Soyadı";
            this.columnHeader11.Width = 73;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Adı";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PersonelID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PrimID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 0;
            // 
            // lvPersonelSec
            // 
            this.lvPersonelSec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader13});
            this.lvPersonelSec.FullRowSelect = true;
            this.lvPersonelSec.Location = new System.Drawing.Point(642, 79);
            this.lvPersonelSec.Name = "lvPersonelSec";
            this.lvPersonelSec.Size = new System.Drawing.Size(187, 238);
            this.lvPersonelSec.TabIndex = 67;
            this.lvPersonelSec.UseCompatibleStateImageBehavior = false;
            this.lvPersonelSec.View = System.Windows.Forms.View.Details;
            this.lvPersonelSec.DoubleClick += new System.EventHandler(this.lvPersonelSec_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Prim Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(158, 196);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(117, 20);
            this.txtTutar.TabIndex = 66;
            // 
            // cbDonem
            // 
            this.cbDonem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonem.DropDownWidth = 50;
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "01/2016",
            "02/2016",
            "03/2016",
            "04/2016",
            "05/2016",
            "06/2016",
            "07/2016",
            "08/2016",
            "09/2016",
            "10/2016",
            "11/2016",
            "12/2016",
            "01/2017",
            "02/2017",
            "03/2017",
            "04/2017",
            "05/2017",
            "06/2017",
            "07/2017",
            "08/2017",
            "09/2017",
            "10/2017",
            "11/2017",
            "12/2017"});
            this.cbDonem.Location = new System.Drawing.Point(254, 222);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(21, 21);
            this.cbDonem.TabIndex = 64;
            this.cbDonem.SelectedIndexChanged += new System.EventHandler(this.cbDonem_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Dönem:";
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(158, 222);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.ReadOnly = true;
            this.txtDonem.Size = new System.Drawing.Size(98, 20);
            this.txtDonem.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Prim ID:";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(158, 94);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.ReadOnly = true;
            this.txtPrimID.Size = new System.Drawing.Size(117, 20);
            this.txtPrimID.TabIndex = 61;
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.lvPersonel.FullRowSelect = true;
            this.lvPersonel.Location = new System.Drawing.Point(336, 79);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(300, 238);
            this.lvPersonel.TabIndex = 54;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            this.lvPersonel.DoubleClick += new System.EventHandler(this.lvPersonel_DoubleClick);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(158, 145);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(117, 20);
            this.txtAdi.TabIndex = 51;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(158, 120);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.ReadOnly = true;
            this.txtPersonelID.Size = new System.Drawing.Size(117, 20);
            this.txtPersonelID.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(158, 170);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(117, 20);
            this.txtSoyadi.TabIndex = 53;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(245, 281);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 36);
            this.btnSil.TabIndex = 59;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(176, 281);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(65, 36);
            this.btnDegistir.TabIndex = 58;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(107, 281);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(65, 36);
            this.btnKaydet.TabIndex = 57;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(38, 281);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(65, 36);
            this.btnYeni.TabIndex = 56;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(332, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 20);
            this.label10.TabIndex = 151;
            this.label10.Text = "ÖDENEN PRİM LİSTESİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(638, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 152;
            this.label7.Text = "PERSONEL LİSTESİ";
            // 
            // frmPrimIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 371);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lvPersonelSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cbDonem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrimIslemleri";
            this.Text = "PRİM İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmPrimIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvPersonelSec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}