using frmPersonelTakipSistemi;
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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        

        private void izinHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            
            frmGirisEkrani frm = new frmGirisEkrani();
            frm.ShowDialog();
            if (frmGirisEkrani.Sonuc)
            {

            }
            else
                Application.Exit();
                

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleri frm = new frmPersonelIslemleri();
            frm.ShowDialog();
        }

        private void FormAc(string AcilacakForm)
        {
           
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleri frm = new frmPersonelIslemleri();
            frm.ShowDialog();
        }

        private void btnIzınIslemleri_Click(object sender, EventArgs e)
        {
            frmIzinIslemleri frm = new frmIzinIslemleri();
            frm.ShowDialog();
        }

        private void btnMesaiIslemleri_Click(object sender, EventArgs e)
        {
            frmMesaiIslemleri frm = new frmMesaiIslemleri();
            frm.ShowDialog();
        }

        private void btnMaasIslemleri_Click(object sender, EventArgs e)
        {
            frmMaasIslemleri frm = new frmMaasIslemleri();
            frm.ShowDialog();
        }

        private void mesaiHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaiIslemleri frm = new frmMesaiIslemleri();
            frm.ShowDialog();
        }

        private void izinHareketleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmIzinIslemleri frm = new frmIzinIslemleri();
            frm.ShowDialog();
        }

        private void maaşHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaasIslemleri frm = new frmMaasIslemleri();
            frm.ShowDialog();
        }

        private void btnPrimler_Click(object sender, EventArgs e)
        {
            frmPrimIslemleri frm = new frmPrimIslemleri();
            frm.ShowDialog();
        }
    }
}
