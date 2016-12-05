using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPersonelTakipSistemi.Classes
{
    class Izin
    {
        private int _izinID;
        private int _personelID;
        private string _izinTipi;
        private double _izinGunSayisi;
        private string _izinBaslangic;
        private string _izinBitis;

        #region Properties
        public int IzinID
        {
            get
            {
                return _izinID;
            }

            set
            {
                _izinID = value;
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

        public string IzinTipi
        {
            get
            {
                return _izinTipi;
            }

            set
            {
                _izinTipi = value;
            }
        }

        public double IzinGunSayisi
        {
            get
            {
                return _izinGunSayisi;
            }

            set
            {
                _izinGunSayisi = value;
            }
        }

        public string IzinBaslangic
        {
            get
            {
                return _izinBaslangic;
            }

            set
            {
                _izinBaslangic = value;
            }
        }

        public string IzinBitis
        {
            get
            {
                return _izinBitis;
            }

            set
            {
                _izinBitis = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void IzinleriGetir(int ID,ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select IzinID,PersonelAd,PersonelSoyad, IzinTipi, IzinGunSayisi,IzinBaslangic, IzinBitis from Personel p inner join IzinHareketleri ih on p.PersonelID=ih.PersonelID where ih.PersonelID=@ID and ih.Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public void IzinleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select IzinID,PersonelAd,PersonelSoyad, IzinTipi, IzinGunSayisi,IzinBaslangic, IzinBitis from IzinHareketleri ih inner join Personel p on ih.PersonelID=p.PersonelID where ih.Silindi=0", conn);
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
                    liste.Items[i].SubItems.Add(dr[6].ToString());

                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public int IzinIDOlustur ()
        {
            int ID = 0;
            SqlCommand comm = new SqlCommand("Select max(IzinID) from IzinHareketleri", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (comm.ExecuteScalar().ToString() == "")
                ID = 1;
            else
            {
                ID = Convert.ToInt32(comm.ExecuteScalar()) + 1;
            }
            return ID;
        }

        public bool IzinKontrol(int ID, string Baslangic, string Bitis)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from IzinHareketleri where PersonelID = @ID and IzinBaslangic=@Baslangic and IzinBitis=@Bitis", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic;
            comm.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }

        public bool IzinSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update IzinHareketleri set Silindi=1 where IzinID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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

        public bool IzinKontrol(int ID,string IzinTipi, string Baslangic, string Bitis)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from IzinHareketleri where PersonelID = @ID and IzinTipi=@IzinTipi and IzinBaslangic=@Baslangic and IzinBitis=@Bitis", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@IzinTipi", SqlDbType.VarChar).Value = IzinTipi;
            comm.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic;
            comm.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }

        public bool IzinEkle(Izin iz)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into IzinHareketleri (PersonelID, IzinTipi, IzinGunSayisi, IzinBaslangic, IzinBitis) values(@ID, @Tip, @Gun, @Baslangic, @Bitis)", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = iz._personelID;
            comm.Parameters.Add("@Tip", SqlDbType.VarChar).Value = iz._izinTipi;
            comm.Parameters.Add("@Gun", SqlDbType.Int).Value = iz._izinGunSayisi;
            comm.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = iz._izinBaslangic;
            comm.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = iz._izinBitis;
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

        public bool IzinGuncelle(Izin iz)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update IzinHareketleri set PersonelID=@PersonelID, IzinTipi=@IzinTipi, IzinGunSayisi=@Gun, IzinBaslangic=@Baslangic, IzinBitis=@Bitis where IzinID=@IzinID", conn);
            comm.Parameters.Add("@IzinID", SqlDbType.Int).Value = iz._izinID;
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = iz._personelID;
            comm.Parameters.Add("@IzinTipi", SqlDbType.VarChar).Value = iz._izinTipi;
            comm.Parameters.Add("@Gun", SqlDbType.Int).Value = iz._izinGunSayisi;
            comm.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = iz._izinBaslangic;
            comm.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = iz._izinBitis;
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

        public int IzinKalan(string IzinTipi,int YapilanIzin)
        {
            int limit = 0;
            if (IzinTipi == "Ücretli")
                IzinTipi = "Ucretli";
            if (IzinTipi == "Ücretsiz")
                IzinTipi = "Ucretsiz";
            SqlCommand comm = new SqlCommand("Select Limit from IzinLimitleri where IzinTipi=@IzinTipi",conn);
            comm.Parameters.Add("@IzinTipi", SqlDbType.VarChar).Value = IzinTipi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                limit = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            
            
            return limit-YapilanIzin ;
        }
        public bool IzneCikabilirmi(int kalan,int istenen)
        {
            bool cikacak = false;
            if (istenen <= kalan)
                cikacak = true;  
            return cikacak;
        }

        public bool IzinleriSifirla()
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update IzinHareketleri set Silindi=1", conn);
            
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public int IzinLimitGetir(string IzinTipi)
        {
            if (IzinTipi == "Ücretli")
                IzinTipi = "Ucretli";
            if (IzinTipi == "Ücretsiz")
                IzinTipi = "Ucretsiz";
            SqlCommand comm = new SqlCommand("Select Limit from IzinLimitleri where IzinTipi=@IzinTipi", conn);
            comm.Parameters.Add("@IzinTipi", SqlDbType.VarChar).Value = IzinTipi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int a = 0;
            try
            {
                a = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return a;
        }

        public bool IzinLimitGuncelle(string IzinTipi, int YeniLimit)
        {
            if (IzinTipi == "Ücretli")
                IzinTipi = "Ucretli";
            if (IzinTipi == "Ücretsiz")
                IzinTipi = "Ucretsiz";
            SqlCommand comm = new SqlCommand("Update IzinLimitleri set Limit=@YeniLimit where IzinTipi=@IzinTipi", conn);
            comm.Parameters.Add("@IzinTipi", SqlDbType.VarChar).Value = IzinTipi;
            comm.Parameters.Add("@YeniLimit", SqlDbType.Int).Value = YeniLimit;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = false;
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public void EskiIzinGetir(int IzinID,string[] deger)
        {
            deger[0] = "";
            deger[1] = "";
            
            SqlCommand comm = new SqlCommand("Select IzinTipi from IzinHareketleri where IzinID=@IzinID", conn);
            comm.Parameters.Add("@IzinID", SqlDbType.VarChar).Value = IzinID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            
            try
            {
                deger[0]=comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            SqlCommand comma = new SqlCommand("Select IzinGunSayisi from IzinHareketleri where IzinID=@IzinID", conn);
            comma.Parameters.Add("@IzinID", SqlDbType.VarChar).Value = IzinID;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                deger[1] = comma.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
    }
}
