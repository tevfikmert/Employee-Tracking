using System;
using System.Collections;
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
    public partial class frmIzinIslemleri : Form
    {
        public frmIzinIslemleri()
        {
            InitializeComponent();
        }

        private void frmIzinIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            DurumKapali();
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            Personel p = new Personel();
            p.PersonelleriGetirForIzin(lvPersonel);
            Temizle();


        }
        private void DurumKapali()
        {
            txtPersonelID.Enabled = false;
            txtAdi.Enabled = false;
            txtSoyadi.Enabled = false;
            txtIzinID.Enabled = false;
            cbIzinTipi.Enabled = false;
            dtpIzinBaslangic.Enabled = false;
            dtpIzinBitis.Enabled = false;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;


        }

        private void DurumAcik()
        {
            txtPersonelID.Enabled = true;
            txtAdi.Enabled = true;
            txtSoyadi.Enabled = true;
            txtIzinID.Enabled = true;
            cbIzinTipi.Enabled = true;
            dtpIzinBaslangic.Enabled = true;
            dtpIzinBitis.Enabled = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
        }

        private void Temizle()
        {
            txtPersonelID.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtIzinID.Clear();
            txtGunSayisi.Clear();
            txtBaslangic.Clear();
            txtBitis.Clear();
            txtIzinTipi.Clear();
            txtToplamRaporlu.Text="0";
            txtToplamUcretli.Text="0";
            txtToplamUcretsiz.Text="0";
            txtKalanIzin.Clear();


        }

        private void TemizleForIzin()
        {

            txtIzinID.Clear();
            txtGunSayisi.Clear();
            txtBaslangic.Clear();
            txtBitis.Clear();
            txtIzinTipi.Clear();
            txtKalanIzin.Clear();

        }





        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            PersonelleriGetir();
        }
        private void PersonelleriGetir()
        {
            Personel p = new Personel();
            p.PersonelleriGetirByIzinArama(txtAdi.Text, txtSoyadi.Text, lvPersonel);
        }
        private void PersonelleriFulGetir()
        {
            Personel p = new Personel();
            p.PersonelleriGetirByIzinArama("", "", lvPersonel);
        }
        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel p = new Personel();
            Izin iz = new Izin();
            TemizleForIzin();
            txtPersonelID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            p.PersonelleriGetir(Convert.ToInt32(txtPersonelID.Text), p);
            txtAdi.Text = p.PersonelAd;
            txtSoyadi.Text = p.PersonelSoyad;
            txtToplamRaporlu.Text = p.ToplamRaporlu.ToString();
            txtToplamUcretli.Text = p.ToplamUcretli.ToString();
            txtToplamUcretsiz.Text = p.ToplamUcretsiz.ToString();
            iz.IzinleriGetir(Convert.ToInt32(txtPersonelID.Text), lvIzinHareketleri);
            PersonelleriFulGetir();
            txtAdi.Enabled = true;
            DurumKapali();
            DurumAcik();
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtIzinID.Text = iz.IzinIDOlustur().ToString();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            DurumAcik();
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();


            txtIzinID.Text = iz.IzinIDOlustur().ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text != "" && txtIzinTipi.Text != "" && txtGunSayisi.Text != "" && txtBaslangic.Text != "" && txtBitis.Text != "")
            {
                Personel p = new Personel();
                Izin iz = new Izin();
                if (iz.IzinKontrol(Convert.ToInt32(txtPersonelID.Text), txtBaslangic.Text, txtBitis.Text))
                {

                    MessageBox.Show("Bu izin zaten kayıtlı!");
                }

                else
                {
                    iz.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    iz.IzinTipi = txtIzinTipi.Text;
                    iz.IzinGunSayisi = Convert.ToInt32(txtGunSayisi.Text);
                    iz.IzinBaslangic = txtBaslangic.Text;
                    iz.IzinBitis = txtBitis.Text;

                    if (iz.IzneCikabilirmi(Convert.ToInt32(txtKalanIzin.Text), Convert.ToInt32(txtGunSayisi.Text)) && iz.IzinEkle(iz) && p.IzinGunSayisiEkle(Convert.ToInt32(txtPersonelID.Text), txtIzinTipi.Text, Convert.ToInt32(txtGunSayisi.Text)))
                    {
                        MessageBox.Show("İzin bilgileri kayıt edildi.");
                        iz.IzinleriGetir(lvIzinHareketleri);
                        Temizle();
                        DurumKapali();
                    }
                    else { MessageBox.Show("İzin kayıt işlemi gerçekleşmedi!"); }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz!");
            }


        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            Personel p = new Personel();
            string[] deger = new string[2];
            iz.EskiIzinGetir(Convert.ToInt32(txtIzinID.Text),deger);
            string eskitip = deger[0];
            int eskigun = Convert.ToInt32(deger[1]);
            if (txtPersonelID.Text != "")

            {
                
                if (iz.IzinKontrol(Convert.ToInt32(txtIzinID.Text), txtIzinTipi.Text, txtBaslangic.Text, txtBitis.Text))
                {
                    MessageBox.Show("Bu izin bilgisi zaten kayıtlı!");

                }
                else
                {
                    iz.IzinID = Convert.ToInt32(txtIzinID.Text);
                    iz.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    iz.IzinTipi = txtIzinTipi.Text;
                    iz.IzinGunSayisi = Convert.ToInt32(txtGunSayisi.Text);
                    iz.IzinBaslangic = txtBaslangic.Text;
                    iz.IzinBitis = txtBitis.Text;
                    if (iz.IzneCikabilirmi(Convert.ToInt32(txtKalanIzin.Text), Convert.ToInt32(txtGunSayisi.Text)) && p.IzinGunSayisiEkleByDegistir(iz.PersonelID, eskitip, txtIzinTipi.Text, eskigun, Convert.ToInt32(txtGunSayisi.Text))&& iz.IzinGuncelle(iz))
                    {
                        MessageBox.Show("İzin Bilgileri değiştirildi.");
                        iz.IzinleriGetir(lvIzinHareketleri);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else { MessageBox.Show("İzin güncelleme işlemi gerçekleşmedi!"); }
                }
            }
            else
                MessageBox.Show("Lütfen personeller tablosundan personeli seçiniz!");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text != "")
            {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Izin iz = new Izin();
                    Personel p = new Personel();
                    bool Sonuc = iz.IzinSil(Convert.ToInt32(txtIzinID.Text));
                    if (Sonuc && p.IzinGunSayisiEkle(Convert.ToInt32(txtPersonelID.Text), txtIzinTipi.Text, Convert.ToInt32(txtGunSayisi.Text) * (-1)))
                    {
                        MessageBox.Show("İzin bilgileri silindi.");
                        Temizle();
                        DurumKapali();
                        iz.IzinleriGetir(lvIzinHareketleri);
                    }
                }
            }
            else
                MessageBox.Show("Lütfen personeller tablosundan personeli seçiniz!");

        }

        private void lvIzinHareketleri_DoubleClick(object sender, EventArgs e)
        {

            txtIzinID.Text = lvIzinHareketleri.SelectedItems[0].SubItems[0].Text;
            txtIzinTipi.Text = lvIzinHareketleri.SelectedItems[0].SubItems[3].Text;
            txtGunSayisi.Text = lvIzinHareketleri.SelectedItems[0].SubItems[4].Text;
            txtBaslangic.Text = lvIzinHareketleri.SelectedItems[0].SubItems[5].Text;
            txtBitis.Text = lvIzinHareketleri.SelectedItems[0].SubItems[6].Text;
            DurumAcik();
            btnKaydet.Enabled = false;
        }

        private void dtpIzinBaslangic_ValueChanged(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpIzinBaslangic.Text;
        }
        //TimeSpan GunFarki = dateTimePicker1.Value.Subtract(dateTimePicker2.Value);
        //lblGun.Text = GunFarki.Days.ToString();
        private void dtpIzinBitis_ValueChanged(object sender, EventArgs e)
        {
            txtBitis.Text = dtpIzinBitis.Text;
            if (txtBaslangic.Text != "" && txtBaslangic.Text != txtBitis.Text)
            {
                if (Convert.ToDateTime(txtBitis.Text) > Convert.ToDateTime(txtBaslangic.Text))
                {
                    txtGunSayisi.Text = (Convert.ToInt32((Convert.ToDateTime(txtBitis.Text).Subtract(Convert.ToDateTime(txtBaslangic.Text)).Days)).ToString());
                    btnKaydet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("İzin bitiş tarihi, izin başlangıç tarihinden önce olamaz!");
                    btnKaydet.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("İzin başlangıç tarihi boş veya izin bitiş tarihiyle aynı olamaz!");
                btnKaydet.Enabled = false;
                txtBitis.Clear();
            }
        }

        private void cbIzinTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIzinTipi.Text = cbIzinTipi.SelectedItem.ToString();
        }

        private void txtIzinTipi_TextChanged(object sender, EventArgs e)
        {
            int yapilanizin = 0;
            Izin iz = new Izin();
            if (txtIzinTipi.Text == "Raporlu")
                yapilanizin = Convert.ToInt32(txtToplamRaporlu.Text);
            else if (txtIzinTipi.Text == "Ücretli")
                yapilanizin = Convert.ToInt32(txtToplamUcretli.Text);
            else if (txtIzinTipi.Text == "Ücretsiz")
                yapilanizin = Convert.ToInt32(txtToplamUcretsiz.Text);
            txtKalanIzin.Text = iz.IzinKalan(txtIzinTipi.Text, yapilanizin).ToString();

        }

        private void txtIzinleriSifirla_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bütün İzinleri Sıfırlamak İstiyor musunuz?", "HEPSİ SIFIRLANSIN MI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Izin iz = new Izin();
                Personel p = new Personel();

                if (iz.IzinleriSifirla() && p.IzinleriSifirla())
                {
                    MessageBox.Show("Yıllık İzinler Sıfırlandı.");
                    Temizle();
                    DurumKapali();
                    p.PersonelleriGetirForIzin(lvPersonel);
                    iz.IzinleriGetir(lvIzinHareketleri);
                }
            }

        }

        private void lvPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimitGuncelle_Click(object sender, EventArgs e)
        {
            frmIzinLimitGuncelle frm = new frmIzinLimitGuncelle();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
