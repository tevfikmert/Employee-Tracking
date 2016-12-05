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
    public partial class frmMaasIslemleri : Form
    {
        public frmMaasIslemleri()
        {
            InitializeComponent();
        }

        Maas m = new Maas();
        Personel p = new Personel();

        private void frmMaasIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            btnHesapla.Enabled = false;
            m.PersonelleriMaaslaGetir(lvPersonel);
            m.OdenenMaaslariGetir(lvOdenenMaaslar);
            cbDonem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonem.SelectedIndex = 0;
        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            if (cbDonem.Text == "" || cbDonem.Text == null)
            {
                MessageBox.Show("Lütfen Dönem Seçiniz. ");
            }
            else
            {
                m.MaaslariGetir(lvMaaslar, cbDonem, lvPersonel.SelectedItems[0].SubItems[0].Text);
                txtPersonelID.Text = lvMaaslar.Items[0].SubItems[0].Text;
                txtPersonelAd.Text = lvMaaslar.Items[0].SubItems[1].Text;
                txtPersonelSoyad.Text = lvMaaslar.Items[0].SubItems[2].Text;
                txtSabitMaas.Text = lvMaaslar.Items[0].SubItems[4].Text;
                txtFazlaMesai.Text = (Convert.ToInt32(lvMaaslar.Items[0].SubItems[5].Text) * 20).ToString();
                txtEksikMesai.Text = (Convert.ToInt32(lvMaaslar.Items[0].SubItems[6].Text) * 10).ToString();
                txtCalistigiGun.Text = lvMaaslar.Items[0].SubItems[8].Text;
                txtToplamMaas.Text = lvMaaslar.Items[0].SubItems[7].Text;
            }
        }

        private void cbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPersonel.Items[0].Selected = true;
            lvPersonel.Select();
            m.MaaslariGetir(lvMaaslar, cbDonem, lvPersonel.SelectedItems[0].SubItems[0].Text);

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool Sonuc = Convert.ToBoolean(m.MaasSil(lvOdenenMaaslar));
                if (Sonuc)
                {
                    MessageBox.Show("Seçilen maaş bilgileri silindi.");
                    Temizle();
                    btnHesapla.Enabled = false;
                    m.OdenenMaaslariGetir(lvOdenenMaaslar);
                }
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double a;
            if (m.MaasKontrol(txtPersonelID.Text, cbDonem.SelectedItem.ToString()))
            {
                MessageBox.Show("Bu personelin seçili dönem ödemesi zaten yapılmış! ");
                Temizle();
            }
            else
            {

                if (Double.TryParse(txtOdenecekTutar.Text, out a))
                {
                    double alacak, borc;
                    if ((Convert.ToDouble(txtOdenecekTutar.Text)) < (Convert.ToDouble(txtToplamMaas.Text)))
                    {
                        alacak = (Convert.ToDouble(txtToplamMaas.Text)) - (Convert.ToDouble(txtOdenecekTutar.Text));
                        borc = 0;
                    }
                    else if ((Convert.ToDouble(txtToplamMaas.Text)) < (Convert.ToDouble(txtOdenecekTutar.Text)))
                    {
                        borc = (Convert.ToDouble(txtOdenecekTutar.Text) - (Convert.ToDouble(txtToplamMaas.Text)));
                        alacak = 0;
                    }
                    else
                    {
                        borc = 0;
                        alacak = 0;
                    }

                    m.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    m.Donem = cbDonem.SelectedItem.ToString();
                    m.CalistigiGun = Convert.ToDouble(txtCalistigiGun.Text);
                    m.Hakedis = Convert.ToDouble(txtToplamMaas.Text);
                    m.Alacak = alacak;
                    m.Borc = borc;
                    m.MaasOde(m);
                    m.ToplamAlacakBorcGuncelle(txtPersonelID.Text, alacak, borc);
                    Temizle();
                }
                else
                    MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz.");
            }
        }
        private void Temizle()
        {
            txtPersonelID.Clear();
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtSabitMaas.Clear();
            txtFazlaMesai.Clear();
            txtEksikMesai.Clear();
            txtCalistigiGun.Clear();
            txtToplamMaas.Clear();
            txtOdenecekTutar.Clear();
            txtPersonelID.Focus();
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);
            m.MaaslariGetirByArama(txtPersonelID.Text, lvOdenenMaaslar);
        }

        private void txtPersonelAd_TextChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);
        }

        private void txtPersonelSoyad_TextChanged(object sender, EventArgs e)
        {
            m.PersonelleriGetirByArama(txtPersonelID.Text, txtPersonelAd.Text, txtPersonelSoyad.Text, lvPersonel);
        }

        private void lvOdenenMaaslar_DoubleClick(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;

        }

    }
}
