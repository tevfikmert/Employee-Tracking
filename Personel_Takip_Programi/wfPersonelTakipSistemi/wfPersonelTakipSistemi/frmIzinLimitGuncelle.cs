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
    public partial class frmIzinLimitGuncelle : Form
    {
        public frmIzinLimitGuncelle()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtLimit.Clear();
            txtYeniLimit.Clear();
            cbIzinTipi.Text = "";

        }

        private void cbIzinTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            txtLimit.Text = iz.IzinLimitGetir(cbIzinTipi.SelectedItem.ToString()).ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Izin iz = new Izin();
            int a;
            if (Int32.TryParse(txtYeniLimit.Text, out a) && cbIzinTipi.SelectedItem.ToString() != "")
            {
                if (iz.IzinLimitGuncelle(cbIzinTipi.SelectedItem.ToString(), Convert.ToInt32(txtYeniLimit.Text)))
                {
                    MessageBox.Show("Limit Güncellendi.");
                    Temizle();
                }
            }
            else { MessageBox.Show("Lütfen İzin Tipini Seçiniz veya Sayısal Bir Değer Giriniz."); }
        }

        private void frmIzinLimitGuncelle_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = 20;
        }
    }
}
