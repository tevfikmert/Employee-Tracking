namespace wfPersonelTakipSistemi
{
    partial class frmPrimler
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvPrimler = new System.Windows.Forms.ListView();
            this.txtPrimTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(369, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "PRİM LİSTESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "* Prim vermek istediğiniz çalışanı listeden seçiniz.";
            // 
            // lvPrimler
            // 
            this.lvPrimler.Location = new System.Drawing.Point(23, 62);
            this.lvPrimler.Name = "lvPrimler";
            this.lvPrimler.Size = new System.Drawing.Size(794, 144);
            this.lvPrimler.TabIndex = 24;
            this.lvPrimler.UseCompatibleStateImageBehavior = false;
            // 
            // txtPrimTutar
            // 
            this.txtPrimTutar.Location = new System.Drawing.Point(114, 294);
            this.txtPrimTutar.Multiline = true;
            this.txtPrimTutar.Name = "txtPrimTutar";
            this.txtPrimTutar.Size = new System.Drawing.Size(180, 27);
            this.txtPrimTutar.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prim Tutarı:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(644, 278);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 51);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(420, 278);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 51);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(532, 278);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(106, 51);
            this.btnDegistir.TabIndex = 28;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(308, 278);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(106, 51);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // frmPrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 420);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvPrimler);
            this.Controls.Add(this.txtPrimTutar);
            this.Controls.Add(this.label2);
            this.Name = "frmPrimler";
            this.Text = "PRİMLER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvPrimler;
        private System.Windows.Forms.TextBox txtPrimTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnYeni;
    }
}