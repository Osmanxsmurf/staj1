using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//C# üzerinden sql komutlarını yazabilmemiz için bu kütüphaneyi içe aktarmamız gerekiyor.

namespace UrunSatis
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        Komutlar Komutlar = new Komutlar();
        //Bazı komutları kullanabilmek için Komutlar sınıfımızdan nesne türettik.

        void KategoriBul()
        {
            for (int i = 0; i < Komutlar.KategoriBul().Length; i++)
            {
                cmbUrunKategori.Items.Add(Komutlar.KategoriBul()[i]);
            }
            /* Komutlar sınıfımızın içerisindeki KategoriBul() metodunu çağırıyoruz. Dikkat ederseniz bu metod bize bir dizi döndürüyor.
             * Yani bir değişken ataması gibi düşünün. Siz 'int a = 1' yaparsanız, a değişkenine '1' değeri gider. Bu metodda benzer şekilde,
             * 'Komutlar.KategoriBul() = Dizi[]' şeklinde yapmış olduğumuz bir atama söz konusu. Böyle düşünebiliriz. Burada yaptığımız işlemse,
             * KategoriBul() metodumuzun dizisinin içerisindeki bütün elemanları tek tek Combobox'ta yazdırmak. Bunu bir metod halinde yazmak daha
             * iyi olur diye düşündüm. */
        }
        void HerseyiTemizle()
        {
            txtUrunAd.Clear();
            txtUrunMarka.Clear();
            nmrUrunMiktar.Value = 0;
            cmbUrunKategori.Text = "";
            txtUrunAciklama.Clear();
            nmrUrunFiyat.Value = 0;
            /*Daha mobil bir uygulama olması için belirli işlemlerden sonra, (örneğin: silme, temizleme, güncelleme gibi) araçlarımızın temizlenerek
             * iyi bir kullanım sunmasını istedim.*/
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string Ad = txtUrunAd.Text;
            string Marka = txtUrunMarka.Text;
            decimal Miktar = nmrUrunMiktar.Value;
            string Kategori = cmbUrunKategori.Text;
            string Aciklama = txtUrunAciklama.Text;
            decimal Fiyat = nmrUrunFiyat.Value;
            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.

            if(Ad == "" || Marka == "" || Miktar == 0 || Kategori == "" || Aciklama == "" || Fiyat == 0)
            {
                MessageBox.Show("Eksik ürün kaydı.");
            }
            else
            {
                Connection Baglanti = new Connection();
                //Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.


                Baglanti.Baglan.Open();
                //Bağlantımızı açıyoruz.


                SqlCommand komut = new SqlCommand("INSERT INTO Urunler(UrunAd,UrunMarka,UrunMiktar,UrunKategori,UrunAciklama,UrunTarih,UrunFiyat) VALUES" +
                    "(@ad,@marka,@miktar,@kategori,@aciklama,@tarih,@fiyat)", Baglanti.Baglan);
                /*
                 * Bu sorguda ise Urunler tablosuna eklemek istediğimiz değerleri yazıyoruz ve eklemek istediğimiz değerlerin
                 * karşısına, "@" işaretiyle başlayan parametreler yazıyoruz. Bu parametreler değişken gibi düşünülebilir.
                 * Birazdan o parametrelere değerler atayacağız.
                 * Id özelliğini burada belirtmedik çünkü bu değerler kullanıcı tarafından girilmeyecek.
                 * Çünkü veritabanındaki kaçıncı ürünü girdiğini kullanıcıdan niye zahmet edip isteyelim?
                 * Yazmış olduğumuz sorguyu ve bağlantımızı SqlCommand'ın parametrelerine ekliyoruz ve bu şekilde sql
                 * yavaş yavaş sorgumuzu tanımaya başlıyor.
                */


                komut.Parameters.AddWithValue("@ad", Ad);
                //@ad parametresini, Ad değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@marka", Marka);
                //@marka parametresini, Marka değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@miktar", Miktar);
                //@miktar parametresini, Miktar değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@kategori", Kategori);
                //@kategori parametresini, Kategori değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@aciklama", Aciklama);
                //@aciklama parametresini, Aciklama değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                //@tarih parametresini, bugün, bu saat, bu dakika ve bu saniyenin verisiyle doldur. Yani şimdiyle!
                komut.Parameters.AddWithValue("@fiyat", Fiyat);
                //@aciklama parametresini, Aciklama değişkenimdeki değerle doldur.

                //Bu parametre olayını tıpkı Replace() metodu gibi düşünebilirsiniz. Hatta neredeyse tamamen aynı.
                //Örneğin '@ad' olan bir ifadeyi, 'Esma' olarak değiştiriliyor sadece.


                komut.ExecuteNonQuery();
                //Burada ise yazmış olduğumuz komudu Sql'de "Execute" ediyoruz yani yürütüyoruz. Tıpkı Visual Studio'da "Başlat" tuşuna basışımız gibi.


                Baglanti.Baglan.Close();
                //Bağlantımızı kapatıyoruz.

                HerseyiTemizle();
                //Herşeyi temizliyoruz.

                MessageBox.Show("Ürün ekleme işlemi başarılı!");
            }
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = Komutlar.IDBul("Urunler");
            //Sınıfımızdaki IDBUL() metodunu çağırıp, o metodun ifade ettiği değeri ürünümüzün id'si için oluşturduğumuz textbox'a yöneltiyoruz.
            //Bu metodun ne olduğunu, kendi sınıfında açıkladım.

            KategoriBul();
            //KategoriBul() metodumuzu çağırıyoruz.
        }
    }
}
