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
    class Mesai
    {
        private int _mesaiID;
        private int _personelID;
        private string _mesaiTarihi;
        private string _girisSaat;
        private string _cikisSaat;
        private int _gunlukMesai;
        private int _normalMesai;
        private int _fazlaMesai;
        private int _eksikMesai;
        private string _donem;

        #region Properties
        public int MesaiID
        {
            get
            {
                return _mesaiID;
            }

            set
            {
                _mesaiID = value;
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

        public string MesaiTarihi
        {
            get
            {
                return _mesaiTarihi;
            }

            set
            {
                _mesaiTarihi = value;
            }
        }

        public string GirisSaat
        {
            get
            {
                return _girisSaat;
            }

            set
            {
                _girisSaat = value;
            }
        }

        public string CikisSaat
        {
            get
            {
                return _cikisSaat;
            }

            set
            {
                _cikisSaat = value;
            }
        }

        public int GunlukMesai
        {
            get
            {
                return _gunlukMesai;
            }

            set
            {
                _gunlukMesai = value;
            }
        }

        public int NormalMesai
        {
            get
            {
                return _normalMesai;
            }

            set
            {
                _normalMesai = value;
            }
        }

        public int FazlaMesai
        {
            get
            {
                return _fazlaMesai;
            }

            set
            {
                _fazlaMesai = value;
            }
        }

        public int EksikMesai
        {
            get
            {
                return _eksikMesai;
            }

            set
            {
                _eksikMesai = value;
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
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void MesaileriGetir(int PersonelID,string Donem,string Tarih, ListView liste)  //mesai ekranında herhangi arama esnasında getirir.
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MesaiID,MesaiTarihi,PersonelAd,PersonelSoyad, GirisSaat, CikisSaat, Donem from MesaiHareketleri mh inner join Personel p on mh.PersonelID=p.PersonelID where mh.PersonelID=@ID and Donem like '%' + @Donem + '%' and MesaiTarihi like '%'+ @Tarih + '%' and mh.Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = PersonelID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = Donem;
            comm.Parameters.Add("@Tarih", SqlDbType.VarChar).Value = Tarih;
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

        public Mesai MesaiGetir(int MesaiID, Mesai m)   //lvmesai den çift tıklanıp seçilirse getirir.
        {


            SqlCommand comm = new SqlCommand("Select PersonelID,MesaiTarihi, GirisSaat, CikisSaat, Donem from MesaiHareketleri where MesaiID=@MesaiID and Silindi=0", conn);
            comm.Parameters.Add("@MesaiID", SqlDbType.Int).Value = MesaiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                m.PersonelID = Convert.ToInt32(dr[0]);
                m.MesaiTarihi = dr[1].ToString();
                m.GirisSaat = dr[2].ToString();
                m.CikisSaat = dr[3].ToString();
                m.Donem = dr[4].ToString();

            }
            dr.Close();
            conn.Close();

            return m;
        }

        public bool MesaiGuncelle(Mesai m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update MesaiHareketleri set MesaiTarihi=@Tarih, GirisSaat=@Giris, CikisSaat=@Cikis, Donem=@Donem where MesaiID=@MesaiID", conn);
            comm.Parameters.Add("@MesaiID", SqlDbType.Int).Value =m._mesaiID;
            comm.Parameters.Add("@Tarih", SqlDbType.VarChar).Value = m._mesaiTarihi;
            comm.Parameters.Add("@Giris", SqlDbType.VarChar).Value = m._girisSaat;
            comm.Parameters.Add("@Cikis", SqlDbType.VarChar).Value = m._cikisSaat;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m._donem ;
            
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

        public bool MesaiSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update MesaiHareketleri set Silindi=1 where MesaiID=@ID", conn);
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

        

        public bool MesaiEkle(Mesai m)  //O gün olan mesaisinde eksik fazlaları da hesaplayıp sql'e kayıt eder
        {
            int fazla = 0;
            int eksik = 0;
            int normalMesai = 0;
            bool Sonuc = false;
            DateTime GirdigiSaat  = Convert.ToDateTime(m.MesaiTarihi+" "+m.GirisSaat+":00");
            DateTime CiktigiSaat = Convert.ToDateTime(m.MesaiTarihi+" "+m.CikisSaat+":00");
            //int sure = (CiktigiSaat - GirdigiSaat).TotalHours;
            int sure = Convert.ToInt32(Math.Ceiling((CiktigiSaat - GirdigiSaat).TotalHours));
            Personel p = new Personel();
            int mesaisuresi = p.GunlukMesaiGetir(m.PersonelID);
            if (sure>mesaisuresi)
            {
                fazla = sure-mesaisuresi;
                normalMesai = mesaisuresi;
            }
            else if(sure<mesaisuresi)
            {
                eksik = mesaisuresi-sure;
                normalMesai = sure;
            }
            if(sure == mesaisuresi)
            {
                normalMesai = sure;
            }

         
            SqlCommand comm = new SqlCommand("Insert into MesaiHareketleri (PersonelID, MesaiTarihi, GirisSaat, CikisSaat,GunlukMesai,NormalMesai,EksikMesai,FazlaMesai, Donem) values(@ID, @Tarih, @Giris, @Cikis,@GunlukMesai,@NormalMesai,@EksikMesai,@FazlaMesai,@Donem)", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = m._personelID;
            comm.Parameters.Add("@Tarih", SqlDbType.VarChar).Value = m._mesaiTarihi;
            comm.Parameters.Add("@Giris", SqlDbType.VarChar).Value = m._girisSaat;
            comm.Parameters.Add("@Cikis", SqlDbType.VarChar).Value = m._cikisSaat;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m._donem;
            comm.Parameters.Add("@EksikMesai", SqlDbType.Int).Value = eksik;
            comm.Parameters.Add("@FazlaMesai", SqlDbType.Int).Value = fazla;
            comm.Parameters.Add("@GunlukMesai", SqlDbType.Int).Value = mesaisuresi;
            comm.Parameters.Add("@NormalMesai", SqlDbType.Int).Value = normalMesai;

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
        public bool MesaiKontrol(int MesaiID, int PersonelID, string Tarih)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from MesaiHareketleri where PersonelID = @PersonelID and MesaiTarihi=@Tarih and MesaiID!=@MesaiID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = PersonelID;
            comm.Parameters.Add("@Tarih", SqlDbType.VarChar).Value = Tarih;
            comm.Parameters.Add("@MesaiID", SqlDbType.Int).Value = MesaiID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool MesaiKontrol(int PersonelID, string Tarih)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from MesaiHareketleri where PersonelID = @PersonelID and MesaiTarihi=@Tarih", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = PersonelID;
            comm.Parameters.Add("@Tarih", SqlDbType.VarChar).Value = Tarih;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }
    }
}
