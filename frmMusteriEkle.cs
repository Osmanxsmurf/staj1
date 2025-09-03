using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Tekrar kütüphanemizi tanımladık.

namespace UrunSatis
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        Komutlar Komutlar = new Komutlar();
        //Bazı komutları kullanabilmek için Komutlar sınıfımızdan nesne türettik.

        void HerseyiTemizle()
        {
            txtAd.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtId.Clear();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            txtId.Text = Komutlar.IDBul("Musteriler");
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.
            string Ad = txtAd.Text;
            string Telefon = txtTelefon.Text;
            string Adres = txtAdres.Text;
            string Email = txtEmail.Text;

            if (Ad == "" || Adres == "" || Telefon == "" || Email == "")
            {
                MessageBox.Show("Eksik müşteri kaydı.");
            }
            else
            {
                Connection Baglanti = new Connection();
                //Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.


                Baglanti.Baglan.Open();
                //Bağlantımızı açıyoruz.

                SqlCommand komut = new SqlCommand("INSERT INTO Musteriler(MusteriAd,MusteriTelefon,MusteriAdres,MusteriEmail,MusteriTarih) VALUES" +
                "(@ad,@telefon,@adres,@email,@tarih)", Baglanti.Baglan);
                /*Yazmış olduğumuz sorguyu ve bağlantımızı SqlCommand'ın parametrelerine ekliyoruz ve bu şekilde sql
                 * yavaş yavaş sorgumuzu tanımaya başlıyor.
                 */


                komut.Parameters.AddWithValue("@ad", Ad);
                //@ad parametresini, Ad değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@telefon", Telefon);
                //@marka parametresini, Telefon değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@adres", Adres);
                //@miktar parametresini, Adres değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@email", Email);
                //@kategori parametresini, Email değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                //@tarih parametresini, bugün, bu saat, bu dakika ve bu saniyenin verisiyle doldur. Yani şimdiyle!


                komut.ExecuteNonQuery();
                //Burada ise yazmış olduğumuz komudu Sql'de "Execute" ediyoruz yani yürütüyoruz. Tıpkı Visual Studio'da "Başlat" tuşuna basışımız gibi.


                Baglanti.Baglan.Close();
                //Bağlantımızı kapatıyoruz.

                MessageBox.Show("Müşteri kaydı başarılı!");

                HerseyiTemizle();
            }
        }
    }
}
