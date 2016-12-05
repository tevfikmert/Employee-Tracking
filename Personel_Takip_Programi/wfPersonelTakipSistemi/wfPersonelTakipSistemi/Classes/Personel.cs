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
    class Personel
    {
        private int _personelID;
        private string _tCKN;
        private string _personelAd;
        private string _personelSoyad;
        private string _telefon;
        private string _adres;
        private string _departman;
        private string _durum;
        private string _iBAN;
        private double _sabitMaas;
        private string _girisTarihi;
        private string _cikisTarihi;
        private int _toplamRaporlu;
        private int _toplamUcretli;
        private int _toplamUcretsiz;
        private double _toplamAlacak;
        private double _toplamBorc;

        #region Properties
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

        public string TCKN
        {
            get
            {
                return _tCKN;
            }

            set
            {
                _tCKN = value;
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

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string Departman
        {
            get
            {
                return _departman;
            }

            set
            {
                _departman = value;
            }
        }

        public string Durum
        {
            get
            {
                return _durum;
            }

            set
            {
                _durum = value;
            }
        }

        public string IBAN
        {
            get
            {
                return _iBAN;
            }

            set
            {
                _iBAN = value;
            }
        }

        public double SabitMaas
        {
            get
            {
                return _sabitMaas;
            }

            set
            {
                _sabitMaas = value;
            }
        }

        public string GirisTarihi
        {
            get
            {
                return _girisTarihi;
            }

            set
            {
                _girisTarihi = value;
            }
        }

        public string CikisTarihi
        {
            get
            {
                return _cikisTarihi;
            }

            set
            {
                _cikisTarihi = value;
            }
        }

        public int ToplamRaporlu
        {
            get
            {
                return _toplamRaporlu;
            }

            set
            {
                _toplamRaporlu = value;
            }
        }

        public int ToplamUcretli
        {
            get
            {
                return _toplamUcretli;
            }

            set
            {
                _toplamUcretli = value;
            }
        }

        public int ToplamUcretsiz
        {
            get
            {
                return _toplamUcretsiz;
            }

            set
            {
                _toplamUcretsiz = value;
            }
        }

        public double ToplamAlacak
        {
            get
            {
                return _toplamAlacak;
            }

            set
            {
                _toplamAlacak = value;
            }
        }

        public double ToplamBorc
        {
            get
            {
                return _toplamBorc;
            }

            set
            {
                _toplamBorc = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public bool PersonelEkle(Personel p)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert Into Personel (TCKN,PersonelAd,PersonelSoyad,Telefon,Adres,Departman,Durum,IBAN,SabitMaas,GirisTarihi,CikisTarihi) values(@TCKN,@PersonelAd,@PersonelSoyad,@Telefon,@Adres,@Departman,@Durum,@IBAN,@SabitMaas,@GirisTarihi,@CikisTarihi)", conn);
            
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = p._tCKN;
            comm.Parameters.Add("@PersonelAd", SqlDbType.VarChar).Value = p._personelAd;
            comm.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar).Value = p._personelSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = p._departman;
            comm.Parameters.Add("@Durum", SqlDbType.VarChar).Value = p._durum;
            comm.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = p._iBAN;
            comm.Parameters.Add("@SabitMaas", SqlDbType.Money).Value = p._sabitMaas;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = p._girisTarihi;
            comm.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime("31.12.2199 00:00:00.000");
            

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

        public bool PersonelGuncelleWithLeft(Personel p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personel set TCKN=@TCKN, PersonelAd=@PersonelAd, PersonelSoyad=@PersonelSoyad, Telefon=@Telefon, Adres=@Adres, Departman=@Departman, Durum=@Durum, IBAN=@IBAN, SabitMaas=@SabitMaas, GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = p._personelID;
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = p._tCKN;
            comm.Parameters.Add("@PersonelAd", SqlDbType.VarChar).Value = p._personelAd;
            comm.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar).Value = p._personelSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = p._departman;
            comm.Parameters.Add("@Durum", SqlDbType.VarChar).Value = p._durum;
            comm.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = p._iBAN;
            comm.Parameters.Add("@SabitMaas", SqlDbType.Money).Value = p._sabitMaas;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(p._girisTarihi);
            comm.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(p._cikisTarihi);
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

        public bool PersonelGuncelleWithoutLeft(Personel p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personel set TCKN=@TCKN, PersonelAd=@PersonelAd, PersonelSoyad=@PersonelSoyad, Telefon=@Telefon, Adres=@Adres, Departman=@Departman, Durum=@Durum, IBAN=@IBAN, SabitMaas=@SabitMaas, GirisTarihi=@GirisTarihi where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = p._personelID;
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = p._tCKN;
            comm.Parameters.Add("@PersonelAd", SqlDbType.VarChar).Value = p._personelAd;
            comm.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar).Value = p._personelSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = p._departman;
            comm.Parameters.Add("@Durum", SqlDbType.VarChar).Value = p._durum;
            comm.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = p._iBAN;
            comm.Parameters.Add("@SabitMaas", SqlDbType.Money).Value = p._sabitMaas;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(p._girisTarihi);
            
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

        public bool PersonelKontrol(string TCKN)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Personel where TCKN = @TCKN", conn);
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = TCKN;
            
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }

        public bool PersonelKontrol(string ID, string TCKN )
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Personel where PersonelID != @ID and TCKN=@TCKN", conn);
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = TCKN;
            
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }

        public void PersonelleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID,TCKN, PersonelAd, PersonelSoyad, Telefon, Adres, Departman, Durum from Personel where Silindi=0", conn);
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public void PersonelleriGetirForIzin(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, PersonelAd, PersonelSoyad, Telefon, Adres, ToplamRaporlu, ToplamUcretli, ToplamUcretsiz from Personel where Silindi=0", conn);
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public void PersonelleriGetirForMesai(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, TCKN, PersonelAd, PersonelSoyad, Telefon, Adres, Departman, Durum from Personel where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
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

        public Personel PersonelleriGetir(int ID, Personel p)
        {
            
            
            SqlCommand comm = new SqlCommand("Select TCKN, PersonelAd, PersonelSoyad, Telefon, Adres, Departman, Durum, CikisTarihi, GirisTarihi, IBAN, SabitMaas,ToplamRaporlu, ToplamUcretli, ToplamUcretsiz from Personel where PersonelID=@ID and Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                p.TCKN = dr[0].ToString();
                p.PersonelAd= dr[1].ToString();
                p.PersonelSoyad = dr[2].ToString();
                p.Telefon = dr[3].ToString();
                p.Adres = dr[4].ToString();
                p.Departman = dr[5].ToString();
                p.Durum = dr[6].ToString();
                p.CikisTarihi=Convert.ToDateTime(dr[7].ToString()).ToShortDateString(); //tarih formatı GG.AA.YYYY olarak göz.
                p.GirisTarihi=Convert.ToDateTime(dr[8].ToString()).ToShortDateString();
                p.IBAN = dr[9].ToString();
                p.SabitMaas = Convert.ToDouble(dr[10]);
                p.ToplamRaporlu = Convert.ToInt32(dr[11]);
                p.ToplamUcretli = Convert.ToInt32(dr[12]);
                p.ToplamUcretsiz = Convert.ToInt32(dr[13]);
            }
            dr.Close();
            conn.Close();
            
            return p;
        }

        public void PersonelleriGetirByArama(string ID, string TCKN, string Adi, string Soyadi, string Telefon, string Adres, string Departman, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, TCKN, PersonelAd, PersonelSoyad, Telefon, Adres, Departman, Durum  from Personel where Silindi=0 and PersonelID like @ID + '%' and TCKN like @TCKN + '%' and PersonelAd like @Adi + '%' and PersonelSoyad like  @Soyadi + '%' and Telefon like  @Telefon + '%' and Adres like  @Adres + '%' and Departman like @Departman + '%'", conn);
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            comm.Parameters.Add("@TCKN", SqlDbType.VarChar).Value = TCKN;
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = Adi;
            comm.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = Soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = Adres;
            comm.Parameters.Add("@Departman", SqlDbType.VarChar).Value = Departman;
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public void PersonelleriGetirByIzinArama(string Adi, string Soyadi, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, PersonelAd, PersonelSoyad, Telefon, Adres, ToplamRaporlu, ToplamUcretli, ToplamUcretsiz  from Personel where Silindi=0 and  PersonelAd like @Adi + '%' and PersonelSoyad like  @Soyadi + '%'", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = Adi;
            comm.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = Soyadi;
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public bool PersonelSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personel set Silindi=1  where PersonelID=@ID", conn);
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

        public bool IzinGunSayisiEkle(int ID, string IzinTipi, int Gun)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            if (IzinTipi == "Raporlu")
            {
                comm.CommandText = "Update Personel set ToplamRaporlu+=@Gun where PersonelID=@ID";
                
            }
            else if (IzinTipi == "Ücretli")
            {
                comm.CommandText = "Update Personel set ToplamUcretli+=@Gun where PersonelID=@ID";
                
            }
            else
            {
                comm.CommandText="Update Personel set ToplamUcretsiz+=@Gun where PersonelID=@ID";   
            }
            comm.Connection = conn;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@Gun", SqlDbType.Int).Value = Gun;

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

        public bool IzinGunSayisiEkleByDegistir(int ID, string EskiIzinTipi,string YeniIzinTipi,int EskiGun, int YeniGun)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            if (EskiIzinTipi == "Raporlu"&&YeniIzinTipi=="Ücretli")  
            {
                comm.CommandText = "Update Personel set ToplamRaporlu-=@EskiGun , ToplamUcretli+=@YeniGun where PersonelID=@ID";

            }
            else if (EskiIzinTipi == "Raporlu" && YeniIzinTipi == "Ücretsiz")
            {
                comm.CommandText = "Update Personel set ToplamRaporlu-=@EskiGun , ToplamUcretsiz+=@YeniGun where PersonelID=@ID";

            }
            else if (EskiIzinTipi == "Ücretli" && YeniIzinTipi == "Raporlu")
            {
                comm.CommandText = "Update Personel set ToplamUcretli-=@EskiGun , ToplamRaporlu+=@YeniGun where PersonelID=@ID";

            }
            else if (EskiIzinTipi == "Ücretli" && YeniIzinTipi == "Ücretsiz")
            {
                comm.CommandText = "Update Personel set ToplamUcretli-=@EskiGun , ToplamUcretsiz+=@YeniGun where PersonelID=@ID";

            }
            else if (EskiIzinTipi == "Ücretsiz" && YeniIzinTipi == "Raporlu")
            {
                comm.CommandText = "Update Personel set ToplamUcretsiz-=@EskiGun , ToplamRaporlu+=@YeniGun where PersonelID=@ID";

            }
            else  // ücretsiz ==> ücretli
            {
                comm.CommandText = "Update Personel set ToplamUcretsiz-=@EskiGun , ToplamUcretli+=@YeniGun where PersonelID=@ID";
            }
            comm.Connection = conn;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@EskiGun", SqlDbType.Int).Value = EskiGun;
            comm.Parameters.Add("@YeniGun", SqlDbType.Int).Value = YeniGun;

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

        public bool IzinleriSifirla()
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personel set ToplamRaporlu=0, ToplamUcretli=0, ToplamUcretsiz=0", conn);

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

        public int GunlukMesaiGetir(int ID)
        {
            int sure = 8;
            SqlCommand comm = new SqlCommand("Select GunlukMesai from Personel where PersonelID= @ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sure =Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
             
            
            
            conn.Close(); 
            return sure;
        }
    }
}
