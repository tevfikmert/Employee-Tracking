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

namespace frmPersonelTakipSistemi
{
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            DurumKapali();
            Personel p = new Personel();
            p.PersonelleriGetir(lvPersonel);
            txtByAdi.Focus();


        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            DurumAcik();
            cbDurum.Enabled = false;
            dtpIstenCikis.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Personel p = new Personel();
            Temizle();
            txtTCKN.Focus();

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            double a;
            if (Double.TryParse(txtSabitMaas.Text, out a) && txtTCKN.Text.Trim() != "" && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtDepartman.Text.Trim() != "" && txtIseGiris.Text.Trim() != "" && txtIBAN.Text.Trim() != "" && txtSabitMaas.Text.Trim() != "")
            {
                Personel p = new Personel();
                if (p.PersonelKontrol(txtID.Text, txtTCKN.Text))
                {
                    MessageBox.Show("Bu personel önceden kayıtlı!");
                    txtTCKN.Focus();
                }
                else
                {
                    p.PersonelID = Convert.ToInt32(txtID.Text);
                    p.TCKN = txtTCKN.Text;
                    p.PersonelAd = txtAdi.Text;
                    p.PersonelSoyad = txtSoyadi.Text;
                    p.Telefon = txtTelefon.Text;
                    p.Adres = txtAdres.Text;
                    p.Departman = txtDepartman.Text;
                    p.IBAN = txtIBAN.Text;
                    p.SabitMaas = Convert.ToDouble(txtSabitMaas.Text);
                    p.GirisTarihi = txtIseGiris.Text;

                    if (cbDurum.SelectedItem.ToString() == "Pasif" && txtIstenCikis.Text != "")
                    {
                        p.Durum = cbDurum.SelectedItem.ToString();
                        p.CikisTarihi = txtIstenCikis.Text;
                    }
                    if(cbDurum.SelectedItem.ToString()=="Aktif")
                    {
                        p.Durum = cbDurum.SelectedItem.ToString();
                        
                    }

                    if (cbDurum.SelectedItem.ToString() == "Pasif")
                    {



                        if (p.PersonelGuncelleWithLeft(p))
                        {
                            MessageBox.Show("Personel Bilgileri değiştirildi.");
                            p.PersonelleriGetir(lvPersonel);
                            Temizle();
                            DurumKapali();
                        }
                        else
                        {
                            MessageBox.Show("Personel Bilgileri Değiştirilemedi!");
                        }

                    }
                    else if (cbDurum.SelectedItem.ToString() == "Aktif")
                    {
                        if (p.PersonelGuncelleWithoutLeft(p))
                        {
                            MessageBox.Show("Personel Bilgileri değiştirildi.");
                            p.PersonelleriGetir(lvPersonel);
                            Temizle();
                            DurumKapali();
                        }
                        else { MessageBox.Show("Personel Bilgileri Değiştirilemedi!"); }

                    }
                }

            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz!"); }

        }
                        


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            double a;
            if (Double.TryParse(txtSabitMaas.Text, out a)&&txtTCKN.Text.Trim() != "" && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtDepartman.Text.Trim() != "" && txtIseGiris.Text.Trim() != "" && txtIBAN.Text.Trim() != "" && txtSabitMaas.Text.Trim() != "")
            {

                if (p.PersonelKontrol(txtTCKN.Text))
                {
                    MessageBox.Show("Bu personel zaten kayıtlı!");
                    txtTCKN.Focus();
                }
                else
                {

                    p.TCKN = txtTCKN.Text;
                    p.PersonelAd = txtAdi.Text;
                    p.PersonelSoyad = txtSoyadi.Text;
                    p.Telefon = txtTelefon.Text;
                    p.Adres = txtAdres.Text;
                    p.Departman = txtDepartman.Text;
                    p.Durum = cbDurum.SelectedItem.ToString();
                    p.IBAN = txtIBAN.Text;
                    p.SabitMaas = Convert.ToDouble(txtSabitMaas.Text);
                    p.GirisTarihi = txtIseGiris.Text;


                    if (p.PersonelEkle(p))
                    {
                        MessageBox.Show("Personel Bilgileri Kayıt Edildi.", "Başarılı");
                        Temizle();

                        DurumKapali();
                    }
                    else {
                        MessageBox.Show("Personel kayıt işlemi gerçekleşmedi!", "Başarısız!");

                    }
                }
                
            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");

            p.PersonelleriGetir(lvPersonel);


        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Personel p = new Personel();
                bool Sonuc = p.PersonelSil(Convert.ToInt32(txtID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Personel bilgileri silindi.");
                    Temizle();
                    DurumKapali();
                    p.PersonelleriGetir(lvPersonel);
                }
            }
        }
        private void Temizle()
        {
            txtID.Clear();
            txtTCKN.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtDepartman.Clear();
            cbDurum.SelectedIndex = 0;
            txtIseGiris.Clear();
            txtIstenCikis.Clear();
            txtIBAN.Clear();
            txtSabitMaas.Clear();
        }

        private void DurumKapali()
        {
            txtTCKN.Enabled = false;
            txtAdi.Enabled = false;
            txtSoyadi.Enabled = false;
            txtTelefon.Enabled = false;
            txtAdres.Enabled = false;
            txtDepartman.Enabled = false;
            cbDurum.Enabled = false;
            txtIstenCikis.Enabled = false;
            txtIstenCikis.Visible = false;
            dtpIstenCikis.Enabled = false;
            txtIseGiris.Enabled = false;
            dtpIseGiris.Enabled = false;
            txtIBAN.Enabled = false;
            txtSabitMaas.Enabled = false;
            btnDegistir.Enabled = false;
            btnYeni.Enabled = true;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
        }
        private void DurumAcik()
        {
            txtTCKN.Enabled = true;
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            txtTelefon.Enabled = true;
            txtAdres.Enabled = true;
            txtDepartman.Enabled = true;
            cbDurum.Enabled = true;
            dtpIstenCikis.Enabled = true;
            txtIseGiris.Enabled = false;
            dtpIseGiris.Enabled = true;
            txtIBAN.Enabled = true;
            txtSabitMaas.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = true;
        }

        private void dtpIstenCikis_ValueChanged(object sender, EventArgs e)
        {
            txtIstenCikis.Text = dtpIstenCikis.Value.ToShortDateString();
        }

        private void dtpIseGiris_ValueChanged(object sender, EventArgs e)
        {
            txtIseGiris.Text = dtpIseGiris.Value.ToShortDateString();
        }





        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {

            DurumAcik();
            if (cbDurum.SelectedItem.ToString() == "Aktif")
                txtIstenCikis.Enabled = false;
            else if (cbDurum.SelectedItem.ToString() == "Pasif")
            {
                txtIstenCikis.Enabled = false;
                txtIstenCikis.Visible = true;
            }
            
            Personel p = new Personel();
            txtID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            p.PersonelleriGetir(Convert.ToInt32(txtID.Text), p);
            txtTCKN.Text = p.TCKN;
            txtAdi.Text = p.PersonelAd;
            txtSoyadi.Text = p.PersonelSoyad;
            txtTelefon.Text = p.Telefon;
            txtAdres.Text = p.Adres;
            txtDepartman.Text = p.Departman;
            cbDurum.SelectedItem = p.Durum.ToString();
            if (p.CikisTarihi.ToString() == "31.12.2199 00:00:00")
                txtIstenCikis.Text = "";
            else
                txtIstenCikis.Text = p.CikisTarihi.ToString();
            txtIseGiris.Text = p.GirisTarihi;
            txtSabitMaas.Text = p.SabitMaas.ToString();
            txtIBAN.Text = p.IBAN;
            btnKaydet.Enabled = false;
            dtpIstenCikis.Enabled = false;
        }



        private void txtByID_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtByTCKN_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtByAdi_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtBySoyadi_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtByTelefon_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtByAdres_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtByDepartman_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void FilmleriGetir()
        {
            Personel p = new Personel();
            p.PersonelleriGetirByArama(txtByID.Text, txtByTCKN.Text, txtByAdi.Text, txtBySoyadi.Text, txtByTelefon.Text, txtByAdres.Text, txtByDepartman.Text, lvPersonel);
        }

        private void lvPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDurum.SelectedItem.ToString() == "Pasif")
            {
                txtIstenCikis.Text = DateTime.Now.ToShortDateString();
                txtIstenCikis.Enabled = false;
                txtIstenCikis.Visible = true;
                dtpIstenCikis.Enabled = true;
            }
            else if(cbDurum.SelectedItem.ToString()=="Aktif")
            {
                txtIstenCikis.Text = "";
                txtIstenCikis.Enabled = false;
                txtIstenCikis.Visible = false;
                dtpIstenCikis.Enabled = false;
            }
        }
    }
}
