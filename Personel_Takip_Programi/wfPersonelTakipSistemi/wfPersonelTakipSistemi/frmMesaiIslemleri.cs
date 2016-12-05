using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfPersonelTakipSistemi.Classes;

namespace wfPersonelTakipSistemi
{
    public partial class frmMesaiIslemleri : Form
    {
        public frmMesaiIslemleri()
        {
            InitializeComponent();
        }
        bool YeniMesaiKaydi = false;

        private void DurumKapali()
        {
            dtpMesaiTarih.Enabled = false;
            cbDonemAy.Enabled = false;
            cbDonemYil.Enabled = false;
            txtPersonelID.Enabled = false;
            txtAdi.Enabled = false;
            txtSoyadi.Enabled = false;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            cbGirisSaat.Enabled = false;
            cbGirisDakika.Enabled = false;
            cbCikisSaat.Enabled = false;
            cbCikisDakika.Enabled = false;

        }

        private void DurumAcik()
        {
            dtpMesaiTarih.Enabled = true;
            cbDonemAy.Enabled = true;
            cbDonemYil.Enabled = true;
            txtPersonelID.Enabled = true;
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnGetir.Enabled = true;
            cbGirisSaat.Enabled = true;
            cbGirisDakika.Enabled = true;
            cbCikisSaat.Enabled = true;
            cbCikisDakika.Enabled = true;
        }

        private void Temizle()
        {
            txtMesaiTarih.Clear();
            txtDonem.Clear();
            txtMesaiID.Clear();
            txtPersonelID.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtGiris.Clear();
            txtCikis.Clear();
            cbDonemAy.Text = "";
            cbDonemYil.Text = "";
            lvMesai.Items.Clear();
            cbGirisSaat.Text = "";
            cbGirisDakika.Text = "";
            cbCikisSaat.Text = "";
            cbCikisDakika.Text = "";

        }

        private void frmMesaiIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            DurumKapali();
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            Personel p = new Personel();
            p.PersonelleriGetirForMesai(lvPersonel);
            //txtMesaiTarih.Text = DateTime.Now.ToShortDateString();
            //txtDonem.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }

        private void dtpMesaiTarih_ValueChanged(object sender, EventArgs e)
        {
            
            
            if(dtpMesaiTarih.Value.Month<10)
                txtDonem.Text ="0"+dtpMesaiTarih.Value.Month.ToString() + "/" + dtpMesaiTarih.Value.Year.ToString();
            else
                txtDonem.Text =dtpMesaiTarih.Value.Month.ToString() + "/" + dtpMesaiTarih.Value.Year.ToString();
            txtMesaiTarih.Text = dtpMesaiTarih.Value.ToShortDateString();
        }
        private void txtMesaiTarih_TextChanged(object sender, EventArgs e)
        {
            if (dtpMesaiTarih.Value.Month < 10)
                txtDonem.Text = "0" + dtpMesaiTarih.Value.Month.ToString() + "/" + dtpMesaiTarih.Value.Year.ToString();
            else
                txtDonem.Text = dtpMesaiTarih.Value.Month.ToString() + "/" + dtpMesaiTarih.Value.Year.ToString();
            MesaileriGetir();
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void cbDonemAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDonemYil.Text != "")
                txtDonem.Text = cbDonemAy.Text + "/" + cbDonemYil.Text;

            if(cbDonemYil.Text!=""&&txtPersonelID.Text!="")
            {
                MesaileriGetir();
            }

        }

        private void cbDonemYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDonemAy.Text != "")
                txtDonem.Text = cbDonemAy.Text + "/" + cbDonemYil.Text;
            if (cbDonemAy.Text != ""&&txtPersonelID.Text != "")
            {
                MesaileriGetir();
            }
        }
        private void txtDonem_TextChanged(object sender, EventArgs e)
        {
            MesaileriGetir();
        }

        private void PersonelleriGetir()
        {
            Personel p = new Personel();
            p.PersonelleriGetirByIzinArama(txtAdi.Text, txtSoyadi.Text, lvPersonel);
        }

        private void MesaileriGetir()
        {
            lvMesai.Items.Clear();
            Mesai m = new Mesai();
            m.MesaileriGetir(Convert.ToInt32(txtPersonelID.Text), txtDonem.Text, txtMesaiTarih.Text, lvMesai);
        }


        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel p = new Personel();
            txtPersonelID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            p.PersonelleriGetir(Convert.ToInt32(txtPersonelID.Text), p);
            txtAdi.Text = p.PersonelAd;
            txtSoyadi.Text = p.PersonelSoyad;
            if(YeniMesaiKaydi)
            {
                txtGiris.Enabled = true;
                txtCikis.Enabled = true;
                btnKaydet.Enabled = true;
                cbDonemAy.Enabled = false;
                cbDonemYil.Enabled = false;
                cbDonemAy.Text = DateTime.Now.Month.ToString();
                cbDonemYil.Text = DateTime.Now.Year.ToString();
                txtMesaiTarih.Text = DateTime.Now.ToShortDateString();
                cbDonemAy.Text = DateTime.Now.Month.ToString();
                cbDonemYil.Text = DateTime.Now.Year.ToString();
            }
            else
            {
                
                DurumAcik();
                cbGirisSaat.Enabled = false;
                cbGirisDakika.Enabled = false;
                cbCikisSaat.Enabled = false;
                cbCikisDakika.Enabled = false;
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                

            }

            
            MesaileriGetir();


        }

        private void lvMesai_DoubleClick(object sender, EventArgs e)
        {
            Mesai m = new Mesai();
            txtMesaiID.Text = lvMesai.SelectedItems[0].SubItems[0].Text;
            m.MesaiGetir(Convert.ToInt32(txtMesaiID.Text), m);
            txtGiris.Text = m.GirisSaat;
            txtCikis.Text = m.CikisSaat;
            txtDonem.Text = m.Donem;
            txtMesaiTarih.Text = m.MesaiTarihi;
            DurumAcik();
            YeniMesaiKaydi = false;
            btnKaydet.Enabled = false;
            cbDonemAy.Enabled = false;
            cbDonemYil.Enabled = false;
            
            
        }



        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniMesaiKaydi = true;
            DurumAcik();
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            cbDonemAy.Enabled = false;
            cbDonemYil.Enabled = false;
            Temizle();
            txtPersonelID.Text = "0";
            txtMesaiTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Mesai m = new Mesai();
            m.MesaiID=Convert.ToInt32(txtMesaiID.Text);
            m.MesaiTarihi = txtMesaiTarih.Text;
            m.GirisSaat = txtGiris.Text;
            m.CikisSaat = txtCikis.Text;
            m.Donem = txtDonem.Text;
            if (txtCikis.Text != "" && txtGiris.Text != "" && txtMesaiTarih.Text != "" && txtMesaiID.Text != ""&&txtPersonelID.Text!="")
            {
                if (m.MesaiKontrol(Convert.ToInt32(txtMesaiID.Text),Convert.ToInt32(txtPersonelID.Text),txtMesaiTarih.Text)==false &&m.MesaiGuncelle(m))
                {
                    MessageBox.Show("Mesai Kaydı Güncellendi.");
                    Temizle();
                    DurumKapali();
                }
                else
                    MessageBox.Show("Aynı gün için mesai kaydı buluyor.","Kayıt Güncellenemedi!");
            }
            else
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text != "" && txtMesaiTarih.Text != "" && txtDonem.Text != "" && txtGiris.Text != "" && txtCikis.Text != "")
            {

                Mesai m = new Mesai();
                if (m.MesaiKontrol(Convert.ToInt32(txtPersonelID.Text), txtMesaiTarih.Text))
                {

                    MessageBox.Show("Lütfen ilgili personele ait farklı bir gün seçin!","MESAİ ÇAKIŞMASI!");
                }

                else
                {
                    m.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    m.MesaiTarihi = txtMesaiTarih.Text;
                    m.Donem = txtDonem.Text;
                    m.GirisSaat = txtGiris.Text;
                    m.CikisSaat = txtCikis.Text;


                    if ( m.MesaiEkle(m) )
                    {
                        MessageBox.Show("Mesai bilgileri kayıt edildi.");
                        YeniMesaiKaydi = false;
                        Temizle();
                        DurumKapali();
                        txtAdi.Enabled = true;
                        txtSoyadi.Enabled = true;
                    }
                    else { MessageBox.Show("Mesai bilgileri kayıt işlemi gerçekleşmedi!"); }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz!");
            }


            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtMesaiID.Text != "")
            {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mesai m = new Mesai();
                    Personel p = new Personel();
                    bool Sonuc = m.MesaiSil(Convert.ToInt32(txtMesaiID.Text));
                    if (Sonuc)
                    {
                        MessageBox.Show("İzin bilgileri silindi.");
                        Temizle();
                        DurumKapali();
                        
                    }
                }
            }
            
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text == "")
            {
                MessageBox.Show("Lütfen bir personel seçiniz.");
                txtAdi.Focus();
            }
            else
            {
                txtMesaiTarih.Text = "";
                txtDonem.Text = "";
                MesaileriGetir();
            }
        }

        private void cbGirisDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGirisSaat.Text != "")
                txtGiris.Text = cbGirisSaat.Text + ":" + cbGirisDakika.Text;
        }

        private void cbCikisDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCikisSaat.Text != "")
                txtCikis.Text = cbCikisSaat.Text + ":" + cbCikisDakika.Text;
        }

        private void cbGirisSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGirisDakika.Text != "")
                txtGiris.Text = cbGirisSaat.Text + ":" + cbGirisDakika.Text;
        }

        private void cbCikisSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCikisDakika.Text != "")
                txtCikis.Text = cbCikisSaat.Text + ":" + cbCikisDakika.Text;
        }
    }
}
