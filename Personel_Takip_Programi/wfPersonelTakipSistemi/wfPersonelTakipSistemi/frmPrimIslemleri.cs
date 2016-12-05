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
    public partial class frmPrimIslemleri : Form
    {
        public frmPrimIslemleri()
        {
            InitializeComponent();
        }

        private void frmPrimIslemleri_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
            PrimleriGetir();
            PersonelleriGetir();
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
        }
        private void PrimleriGetir()
        {
            Prim p = new Prim();
            p.PrimleriGetir(txtAdi.Text, txtSoyadi.Text, txtDonem.Text, lvPersonel);
        }
        private void PersonelleriGetir()
        {
            Personel p = new Personel();
            p.PersonelleriGetirByArama("", "", txtAdi.Text, txtSoyadi.Text, "", "", "", lvPersonelSec);
        }
        private void Temizle()
        {
            txtDonem.Clear();
            cbDonem.Text = "";
            txtPersonelID.Clear();
            txtPrimID.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTutar.Clear();

        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {

            Prim p = new Prim();
            p.PrimID = Convert.ToInt32(lvPersonel.SelectedItems[0].SubItems[0].Text);
            p.PrimleriGetir(p.PrimID, p);
            txtPrimID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            txtPersonelID.Text = p.PersonelID.ToString();
            txtAdi.Text = p.PersonelAd;
            txtSoyadi.Text = p.PersonelSoyad;
            txtTutar.Text = p.PrimTutar.ToString();
            txtDonem.Text = p.Donem;
            btnDegistir.Enabled = true;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
        }
        private void lvPersonelSec_DoubleClick(object sender, EventArgs e)
        {
            txtPrimID.Clear();
            txtTutar.Clear();
            Personel p = new Personel();
            txtPersonelID.Text = lvPersonelSec.SelectedItems[0].SubItems[0].Text;
            p.PersonelleriGetir(Convert.ToInt32(txtPersonelID.Text), p);
            txtAdi.Text = p.PersonelAd;
            txtSoyadi.Text = p.PersonelSoyad;
            btnDegistir.Enabled = false;
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            string a = "";
            if (Convert.ToInt32(DateTime.Now.Month) < 10)
            {
                a = "0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            else
            {
                a = DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            txtDonem.Text = a;
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            PrimleriGetir();
            PersonelleriGetir();
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            PrimleriGetir();
            PersonelleriGetir();
        }

        private void cbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonem.Text = cbDonem.Text;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            double a;
            if (Double.TryParse(txtTutar.Text, out a) && txtPrimID.Text != "" && txtPersonelID.Text != "" && txtDonem.Text != "")
            {
                Prim p = new Prim();
                p.PrimID = Convert.ToInt32(txtPrimID.Text);
                p.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                p.PrimTutar = Convert.ToDouble(txtTutar.Text);
                p.Donem = txtDonem.Text;
                if (p.PrimGuncelle(p))
                {
                    MessageBox.Show("Prim bilgileri değiştirildi");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    btnKaydet.Enabled = false;

                }
                else
                    MessageBox.Show("Prim bilgileri değiştirilemedi.");
            }
            else
                MessageBox.Show("Lütfen kutuları doğru değerler ile doldurunuz.");
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            double a;
            if (Double.TryParse(txtTutar.Text, out a) && Convert.ToInt32(txtTutar.Text) > 0 && txtPersonelID.Text != "" && txtDonem.Text != "")
            {
                Prim p = new Prim();

                p.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                p.PrimTutar = Convert.ToDouble(txtTutar.Text);
                p.Donem = txtDonem.Text;
                if (p.PrimEkle(p))
                {
                    MessageBox.Show("Prim eklendi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    btnKaydet.Enabled = false;

                }
                else
                    MessageBox.Show("Prim eklenemedi.");
            }
            else
                MessageBox.Show("Lütfen kutuları doğru değerler ile doldurunuz.");
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            string a = "";
            if (Convert.ToInt32(DateTime.Now.Month) < 10)
            {
                a = "0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            else
            {
                a = DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            txtDonem.Text = a;
            btnKaydet.Enabled = true;
            
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPrimID.Text != "" && MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Prim p = new Prim();
                bool Sonuc = p.PrimSil(Convert.ToInt32(txtPrimID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Prim bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    p.PrimleriGetir(txtAdi.Text, txtSoyadi.Text, txtDonem.Text, lvPersonel);
                }
            }
        }

 
    }
}
