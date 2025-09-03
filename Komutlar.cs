using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace UrunSatis
{
    internal class Komutlar
    {
        Connection Baglanti = new Connection();

        public string IDBul(string Tablo)
        {
            Baglanti.Baglan.Open();

            SqlCommand IDKomut = new SqlCommand();

            if (Tablo == "Urunler")
            {
                IDKomut = new SqlCommand("SELECT TOP 1 * FROM " + Tablo + " ORDER BY UrunId DESC", Baglanti.Baglan);
            }

            if(Tablo == "Musteriler")
            {
                IDKomut = new SqlCommand("SELECT TOP 1 * FROM " + Tablo + " ORDER BY MusteriId DESC", Baglanti.Baglan);
            }


            SqlDataReader IDOkuyucu = IDKomut.ExecuteReader();

            int SonKayit = 0;

            if (IDOkuyucu.Read())
            {
                if(Tablo == "Urunler")
                    SonKayit = int.Parse(IDOkuyucu["UrunId"].ToString());

                if (Tablo == "Musteriler")
                    SonKayit = int.Parse(IDOkuyucu["MusteriId"].ToString());


                IDOkuyucu.Close();


                Baglanti.Baglan.Close();


                return (SonKayit + 1).ToString();



            }

            IDOkuyucu.Close();

            Baglanti.Baglan.Close();

            return "1";
        }

        public string[] KategoriBul()
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand KategoriKomut = new SqlCommand("SELECT UrunKategori FROM Urunler", Baglanti.Baglan);

            SqlDataReader KategoriOkuyucu = KategoriKomut.ExecuteReader();

            ArrayList list = new ArrayList();

            while (KategoriOkuyucu.Read())
            {

                string Kategori = KategoriOkuyucu["UrunKategori"].ToString();


                list.Add(Kategori);

            }


            KategoriOkuyucu.Close();


            Baglanti.Baglan.Close();
            //Bağlantımızı kapatıyoruz.

            string[] Kategoriler = new string[list.Count];
            Kategoriler = (string[])list.ToArray(typeof(string));

            return Kategoriler;

        }

    }
}
