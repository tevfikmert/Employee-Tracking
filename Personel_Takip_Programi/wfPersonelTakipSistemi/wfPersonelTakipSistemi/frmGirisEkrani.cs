using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfPersonelTakipSistemi.Classes;

namespace wfPersonelTakipSistemi
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }
        public static bool Sonuc = false;
        SqlConnection conn = new SqlConnection(Genel.connStr);
        private object wfPersonelTakip;

        private void btnGiris_Click(object sender, EventArgs e)
        {


            SqlCommand comm = new SqlCommand("Select KullaniciAdi, Parola from Admin", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            
            bool Adi = false;


            while (dr.Read())
            {
                if (txtKullaniciAdi.Text.Trim() == dr["KullaniciAdi"].ToString() && txtParola.Text.Trim() == dr["Parola"].ToString())
                {
                    Sonuc = true;

                    //MessageBox.Show("Girdiğiniz kullanıcı adı mevcut değil! ");
                    //txtKullaniciAdi.Focus();
                }
                else if (txtKullaniciAdi.Text.Trim() == dr["KullaniciAdi"].ToString() && txtParola.Text.Trim() != dr["Parola"].ToString())
                {
                    Adi = true;
                }
            }
            dr.Close();
            conn.Close();

            if(Sonuc)
            {
                
                this.Close();

            }
            else if(Adi==true&&Sonuc==false)
            {
                MessageBox.Show("Girdiğiniz parola yanlış! ");
                txtParola.Focus();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı mevcut değil! ");
                txtKullaniciAdi.Focus();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

