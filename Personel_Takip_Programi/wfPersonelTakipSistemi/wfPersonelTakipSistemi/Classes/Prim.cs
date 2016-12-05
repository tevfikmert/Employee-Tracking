using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPersonelTakipSistemi.Classes
{
    class Prim
    {
        private int _primID;
        private string _personelAd;
        private string _personelSoyad;
        private int _personelID;
        private double _primTutar;
        private string _donem;

        #region Properties
        public int PrimID
        {
            get
            {
                return _primID;
            }

            set
            {
                _primID = value;
            }
        }

        public int PersonelID
        {
            get
            {
                return _personelID;
            }

            set
            {
                _personelID = value;
            }
        }

        public double PrimTutar
        {
            get
            {
                return _primTutar;
            }

            set
            {
                _primTutar = value;
            }
        }

        public string Donem
        {
            get
            {
                return _donem;
            }

            set
            {
                _donem = value;
            }
        }

        public string PersonelAd
        {
            get
            {
                return _personelAd;
            }

            set
            {
                _personelAd = value;
            }
        }

        public string PersonelSoyad
        {
            get
            {
                return _personelSoyad;
            }

            set
            {
                _personelSoyad = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void PrimleriGetir(string ad, string soyad, string donem, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PrimID,pr.PersonelID, PersonelAd, PersonelSoyad,PrimTutar,Donem from Personel p inner join Primler pr on p.PersonelID=pr.PersonelID where pr.Silindi=0 and PersonelAd like @ad + '%' and PersonelSoyad like @soyad + '%' and Donem like @Donem+'%'", conn);
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = donem;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public Prim PrimleriGetir(int ID, Prim p)
        {

            SqlCommand comm = new SqlCommand("Select pr.PersonelID, PersonelAd, PersonelSoyad,PrimTutar,Donem from Personel p inner join Primler pr on p.PersonelID=pr.PersonelID where pr.Silindi=0 and PrimID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                p.PersonelID = Convert.ToInt32(dr[0]);
                p.PersonelAd = dr[1].ToString();
                p.PersonelSoyad = dr[2].ToString();
                p.PrimTutar = Convert.ToDouble(dr[3]);
                p.Donem = dr[4].ToString();
            }
            dr.Close();
            conn.Close();
            return p;
        }
        public bool PrimGuncelle(Prim p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Primler set PersonelID=@PersonelID, PrimTutar=@Tutar, Donem=@Donem where PrimID=@PrimID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = p._personelID;
            comm.Parameters.Add("@Tutar", SqlDbType.Float).Value = p._primTutar;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = p._donem;
            comm.Parameters.Add("@PrimID", SqlDbType.Int).Value = p._primID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool PrimEkle(Prim p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Primler (PersonelID,PrimTutar,Donem) values(@PersonelID,@Tutar,@Donem)", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = p._personelID;
            comm.Parameters.Add("@Tutar", SqlDbType.Float).Value = p._primTutar;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = p._donem;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool PrimSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Primler set Silindi=1 where PrimID=@PrimID", conn);
            comm.Parameters.Add("@PrimID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
    }
}
