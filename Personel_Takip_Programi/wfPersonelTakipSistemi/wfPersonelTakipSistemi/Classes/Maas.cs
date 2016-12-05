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
    class Maas
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public double FazlaMesaiSaati;
        public double FazlaMesaiUcreti;
        public double CezaSaati;
        public double CezaUcreti;
        public double TabanMaas;

        private int _maasID;
        private int _personelID;
        private string _donem;
        private double _calistigiGun;
        private double _hakedis;
        private double _alacak;
        private double _borc;

        #region Properties
        public int MaasID
        {
            get
            {
                return _maasID;
            }

            set
            {
                _maasID = value;
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

        public double CalistigiGun
        {
            get
            {
                return _calistigiGun;
            }

            set
            {
                _calistigiGun = value;
            }
        }

        public double Hakedis
        {
            get
            {
                return _hakedis;
            }

            set
            {
                _hakedis = value;
            }
        }

        public double Alacak
        {
            get
            {
                return _alacak;
            }

            set
            {
                _alacak = value;
            }
        }

        public double Borc
        {
            get
            {
                return _borc;
            }

            set
            {
                _borc = value;
            }
        }

        #endregion

        public void MaaslariGetir(ListView liste, ComboBox SeciliDonem, string ID)
        {
            liste.Items.Clear();
            Maas m = new Maas();
            m._personelID = Convert.ToInt32(ID);
            m._donem = SeciliDonem.SelectedItem.ToString();
            string calistigiGun = CalistigiGunHesapla(m).ToString();
            string hakedilen = HakedisHesapla(m).ToString();
            List<int> list = EksikFazlaMesaiToplamGetir(SeciliDonem, ID);
            SqlCommand comm = new SqlCommand("Select p.PersonelID, PersonelAd, PersonelSoyad, mh.Donem, SabitMaas from Personel p inner join MesaiHareketleri mh on p.PersonelID = mh.PersonelID where p.silindi = 0 and Donem=@Donem and p.PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = SeciliDonem.SelectedItem.ToString();
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Convert.ToInt32(ID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {


                dr.Read();

                liste.Items.Add(dr[0].ToString());
                liste.Items[0].SubItems.Add(dr[1].ToString());
                liste.Items[0].SubItems.Add(dr[2].ToString());
                liste.Items[0].SubItems.Add(dr[3].ToString());
                liste.Items[0].SubItems.Add(dr[4].ToString());
                liste.Items[0].SubItems.Add(list[0].ToString());
                liste.Items[0].SubItems.Add(list[1].ToString());
                liste.Items[0].SubItems.Add(hakedilen);
                liste.Items[0].SubItems.Add(calistigiGun);

            }
            dr.Close();
            conn.Close();
        }
        public List<int> EksikFazlaMesaiToplamGetir(ComboBox SeciliDonem, string ID)
        {
            List<int> list = new List<int>();
            SqlCommand comm = new SqlCommand("Select sum(FazlaMesai), sum(EksikMesai) from MesaiHareketleri where PersonelID=@PersonelID and Donem like +'%'+@Donem+'%'", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Convert.ToInt32(ID);
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = SeciliDonem.SelectedItem.ToString();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (dr[0].ToString() == "")
                    {
                        list.Add(0);
                    }
                    if (dr[1].ToString() == "")
                    {
                        list.Add(0);
                    }
                    if (dr[0].ToString() != "" && dr[1].ToString() != "")
                    {
                        list.Add(Convert.ToInt32(dr[0]));
                        list.Add(Convert.ToInt32(dr[1]));
                    }
                }
            }
            dr.Close();
            conn.Close();
            return list;
        }
        public double CalistigiGunHesapla(Maas m)
        {
            SqlCommand comm = new SqlCommand("Select Count(Donem) from MesaiHareketleri where PersonelID=@PersonelID and Donem=@Donem", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = m._personelID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m._donem;
            if (conn.State == ConnectionState.Closed) conn.Open();
            CalistigiGun = Convert.ToDouble(comm.ExecuteScalar());
            conn.Close();
            return CalistigiGun;

        }

        public double SabitMaasGetir(Maas m)
        {
            SqlCommand comm = new SqlCommand("Select SabitMaas from Personel where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = m._personelID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            Personel p = new Personel();
            p.SabitMaas = Convert.ToDouble(dr["SabitMaas"]);
            dr.Close();
            conn.Close();
            return p.SabitMaas;
        }

        public double HakedisHesapla(Maas m)
        {
            TabanMaas = (SabitMaasGetir(m) / 22) * CalistigiGunHesapla(m);
            SqlCommand comm = new SqlCommand("Select sum(FazlaMesai), sum(EksikMesai) from MesaiHareketleri where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = m._personelID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m._donem;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            FazlaMesaiSaati = Convert.ToDouble(dr[0]);
            FazlaMesaiUcreti = FazlaMesaiSaati * 20;
            CezaSaati = Convert.ToDouble(dr[1]);
            CezaUcreti = CezaSaati * 10;
            Hakedis = TabanMaas + FazlaMesaiUcreti - CezaUcreti;
            dr.Close();
            conn.Close();
            return Hakedis;

        }

        private DataSet MaasHesapla(Maas m)
        {
            SqlCommand comm = new SqlCommand("Insert into MaasHareketleri(PersonelID,Donem,CalistigiGun,Hakedis,Alacak,Borc) values(@PersonelID,@Donem,@CalistigiGun,@Hakedis,@Alacak,@Borc)", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = m._personelID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m._donem;
            comm.Parameters.Add("@CalistigiGun", SqlDbType.Float).Value = m._calistigiGun;
            comm.Parameters.Add("@Hakedis", SqlDbType.Money).Value = m._hakedis;

            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = m._alacak;
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = m._borc;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public void PersonelleriMaaslaGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, IBAN, PersonelAd, PersonelSoyad, Telefon, Adres from Personel where Silindi=0", conn);
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
                    i++;
                }
            }
            dr.Close();
            conn.Close();
            liste.Items[0].Selected = true;
            liste.Select();
        }

        public void MaasOde(Maas m)
        {
            SqlCommand comm = new SqlCommand("Insert into MaasHareketleri(PersonelID, Donem, CalistigiGun, Hakedis, Alacak, Borc) values(@PersonelID, @Donem, @CalistigiGun, @Hakedis, @Alacak, @Borc)", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = m.PersonelID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = m.Donem;
            comm.Parameters.Add("@CalistigiGun", SqlDbType.Float).Value = m.CalistigiGun;
            comm.Parameters.Add("@Hakedis", SqlDbType.Float).Value = m.Hakedis;
            comm.Parameters.Add("@Alacak", SqlDbType.Float).Value = m.Alacak;
            comm.Parameters.Add("@Borc", SqlDbType.Float).Value = m.Borc;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                if (Convert.ToBoolean(comm.ExecuteNonQuery()))
                {
                    MessageBox.Show("Seçilen personelin maaşı ödendi.");
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }


        }

        public void PersonelleriGetirByArama(string ID, string Adi, string Soyadi, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select PersonelID, IBAN, PersonelAd, PersonelSoyad, Telefon, Adres from Personel where Silindi=0 and PersonelID like @ID + '%' and PersonelAd like @Adi + '%' and PersonelSoyad like  @Soyadi + '%'", conn);
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
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
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public void OdenenMaaslariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MaasID, PersonelID, Donem, CalistigiGun, Hakedis, Alacak, Borc from MaasHareketleri where Silindi=0", conn);
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
        public void MaaslariGetirByArama(string ID, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MaasID, PersonelID, Donem, CalistigiGun, Hakedis, Alacak, Borc from MaasHareketleri where Silindi=0 and PersonelID like @ID + '%'", conn);
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
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
        public bool MaasSil(ListView liste)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update MaasHareketleri set Silindi=1 where MaasID=@MaasID", conn);
            comm.Parameters.Add("@MaasID", SqlDbType.Int).Value = liste.SelectedItems[0].SubItems[0].Text;
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
        public List<double> ToplamAlacakBorcGetir(string ID)
        {
            List<double> list = new List<double>();
            SqlCommand comm = new SqlCommand("Select sum(ToplamAlacak), sum(ToplamBorc) from Personel where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                dr.Read();
                list.Add(Convert.ToDouble(dr[0]));
                list.Add(Convert.ToDouble(dr[1]));
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return list;
        }
        public void ToplamAlacakBorcGuncelle(string ID, double Alacak, double Borc)
        {
            List<double> list = ToplamAlacakBorcGetir(ID);
            list[0] += Alacak;
            list[1] += Borc;
            SqlCommand comm = new SqlCommand("Update Personel set ToplamAlacak=@ToplamAlacak, ToplamBorc=@ToplamBorc where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@ToplamAlacak", SqlDbType.Float).Value = list[0];
            comm.Parameters.Add("@ToplamBorc", SqlDbType.Float).Value = list[1];
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);

            }
            finally
            {
                conn.Close();
                AlacakBorcHesapla(ID, list);
            }
        }
        public void AlacakBorcHesapla(string ID, List<double> list)
        {
            if (list[0] > list[1])
            {
                list[0] = list[0] - list[1];
                list[1] = 0;
            }
            else if (list[0] <= list[1])
            {
                list[1] = list[1] - list[0];
                list[0] = 0;
            }
            SqlCommand comm = new SqlCommand("Update Personel set ToplamAlacak=@ToplamAlacak, ToplamBorc=@ToplamBorc where PersonelID=@PersonelID", conn);
            comm.Parameters.Add("@ToplamAlacak", SqlDbType.Float).Value = list[0];
            comm.Parameters.Add("@ToplamBorc", SqlDbType.Float).Value = list[1];
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
        public bool MaasKontrol(string ID, string Donem)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select PersonelID, Donem from MaasHareketleri where PersonelID=@PersonelID and Donem=@Donem and Silindi=0", conn);
            comm.Parameters.Add("@PersonelID", SqlDbType.Int).Value = ID;
            comm.Parameters.Add("@Donem", SqlDbType.VarChar).Value = Donem;
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
