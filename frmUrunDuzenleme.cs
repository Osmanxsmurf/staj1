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
    public partial class frmUrunDuzenleme : Form
    {
        public frmUrunDuzenleme()
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
            txtUrunId.Clear();
            txtUrunAd.Clear();
            txtUrunMarka.Clear();
            cmbUrunKategori.Text = "";
            txtUrunAciklama.Clear();
            nmrUrunMiktar.Value = 0;
            nmrUrunFiyat.Value = 0;
            /*Daha mobil bir uygulama olması için belirli işlemlerden sonra, (örneğin: silme, temizleme, güncelleme gibi) araçlarımızın temizlenerek
            * iyi bir kullanım sunmasını istedim.*/
        }
        void HerseyiListele()
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("SELECT * FROM Urunler", Baglanti.Baglan);

            SqlDataAdapter Bilgi = new SqlDataAdapter(Komut);

            DataTable BilgininTabloHali = new DataTable();

            Bilgi.Fill(BilgininTabloHali);

            dtUrun.DataSource = BilgininTabloHali;

            dtUrun.ReadOnly = true;

            Baglanti.Baglan.Close();
            /* Formumuz yüklendiğinde veya herhangi bir kaydı sildiğimizde veya güncellediğimizde, güncel olan kayıtların listelenmesi için
             * kullanacağımız metod. Tam şu an, evet evet! Tam şuan geçerli olan kayıtları listeler. Örneğin A sütununu değiştirdikten sonra
             * hemen değişmiş sütun karşınıza çıkacak bu metod sayesinde!*/
        }
        private void frmUrunDuzenleme_Load(object sender, EventArgs e)
        {
            HerseyiListele();

            KategoriBul();

            dtUrun.Columns[0].HeaderText = "ID";
            dtUrun.Columns[1].HeaderText = "Ad";
            dtUrun.Columns[2].HeaderText = "Marka";
            dtUrun.Columns[3].HeaderText = "Miktar";
            dtUrun.Columns[4].HeaderText = "Kategori";
            dtUrun.Columns[5].HeaderText = "Açıklama";
            dtUrun.Columns[6].HeaderText = "Kayıt Tarih";
            dtUrun.Columns[7].HeaderText = "Fiyat";

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("SELECT * FROM Urunler WHERE UrunId LIKE @id", Baglanti.Baglan);

            Komut.Parameters.AddWithValue("@id", txtArama.Text + "%");
            //Arama textbox'ına yazdığımız değere sahip kaydı listeledik.

            SqlDataAdapter Bilgi = new SqlDataAdapter(Komut);
            //Bu kaydı SqlDataAdapter'e attık çünkü bilgimizi datagridview'de görüntülemek için DataTable'a çevirmeye ihtiyacımız var.
            //DataTable'a çevirmek içinse SqlDataAdapter'e ihtiyacımız var. Komuttan görüntülenen veriler Bilgi isimli SqlDataAdapter'imize
            //yönlendirildi.

            DataTable BilgininTabloHali = new DataTable();
            //Boş bir tablo oluşturuyoruz. Bundan sonraki adımda dolduracağız.

            Bilgi.Fill(BilgininTabloHali);
            //Boş tablomuzu Bilgi'deki bilgilerle dolduruyoruz.

            dtUrun.DataSource = BilgininTabloHali;
            //Nihayet tablomuz oluşturulduğunda, bu tabloyu datagridview'de görüntüleyebiliriz.

            Baglanti.Baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dtUrun.CurrentRow.Cells["UrunId"].Value.ToString();
            //Datagridview'de bir satıra çift tıkladığımızda o satırın UrunId değeri, txtUrunId textboxımıza gönderilecek.
            //Peki neden yaptık bunu?
            //Bunu yaparak txtUrunId textboxının yazısını değiştirdik değil mi?
            //Ve txtUrunId textboxının yazısı değişirse diye bir olay ekleyeceğiz ve o olayda da, bu textbox'a gelen id'ye sahip
            //kaydın bütün verilerini tek tek diğer textboxlarda göstereceğiz.
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HerseyiTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Burada ise datagridview'de bir kere tıklamamız yeterli olacak şekilde seçtiğimiz satırın silme işlemini gerçekleştiriyoruz.

            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();
            //Bağlantımızı açtık.

            SqlCommand Komut = new SqlCommand("DELETE FROM Urunler WHERE UrunId=@id", Baglanti.Baglan);
            //Sorgumuzu yazdık.

            Komut.Parameters.AddWithValue("@id", dtUrun.CurrentRow.Cells["UrunId"].Value.ToString());
            //Sorgumuzun içindeki @id değerini, datagridview'de seçilmiş olan satırla dolduracağımızı belirttik.

            Komut.ExecuteNonQuery();
            //Komudumuzu yürüttük.

            Baglanti.Baglan.Close();
            //Ve bağlantımızı kapattık.

            MessageBox.Show("Ürün silme işlemi başarıyla tamamlandı !!");

            HerseyiListele();

            HerseyiTemizle();

            KategoriBul();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.
            string Ad = txtUrunAd.Text;
            string Marka = txtUrunMarka.Text;
            decimal Miktar = nmrUrunMiktar.Value;
            string Kategori = cmbUrunKategori.Text;
            string Aciklama = txtUrunAciklama.Text;
            decimal Fiyat = nmrUrunFiyat.Value;

            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();
            //Bağlantımızı açtık.

            SqlCommand Komut = new SqlCommand("UPDATE Urunler SET UrunAd=@ad,UrunMarka=@marka,UrunMiktar=@miktar,UrunKategori=@kategori,UrunAciklama=@aciklama,UrunFiyat=@fiyat WHERE UrunId=@id", Baglanti.Baglan);
            //Güncelleme işlemi için yazmamız gereken sql sorgusunu yazdık.

            Komut.Parameters.AddWithValue("@ad", Ad);
            //@ad parametresini, Ad değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@marka", Marka);
            //@marka parametresini, Marka değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@miktar", Miktar);
            //@miktar parametresini, Miktar değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@kategori", Kategori);
            //@kategori parametresini, Kategori değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@aciklama", Aciklama);
            //@aciklama parametresini, Aciklama değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@fiyat", Fiyat);
            //@fiyat parametresini, Fiyat değişkenimdeki değerle doldur.

            Komut.Parameters.AddWithValue("@id", dtUrun.CurrentRow.Cells["UrunId"].Value.ToString());
            //Sorgumuzun içindeki @id değerini, datagridview'de seçilmiş olan satırla dolduracağımızı belirttik.

            Komut.ExecuteNonQuery();
            //Sorgumuzu yürüttük.

            Baglanti.Baglan.Close();
            //Bağlantımızı kapattık.

            MessageBox.Show("Ürün güncelleme işlemi başarıyla tamamlandı !!");

            HerseyiListele();

            HerseyiTemizle();

            KategoriBul();
        }

        private void txtUrunId_TextChanged(object sender, EventArgs e)
        {
            //Eğer txtUrunId isimli, ürünümüzün id değeri için özel olarak ayırdığımız textbox herhangi bir sebepten ötürü değişirse,
            //aşağıdaki kodlar çalışacaktır. Bu textbox, üstte belirttiğim datagridview'in bir satırına bir kere tıklayarak da değişebilir.

            Connection Baglanti = new Connection();
            //Connection sınıfımızdan Baglanti nesnesini türeterek bağlantımızla bir nevi tanışıyoruz.

            try
            {
                Baglanti.Baglan.Open();
                //Bağlantımızı açıyoruz.

                SqlCommand Komut = new SqlCommand("SELECT * FROM Urunler WHERE UrunId LIKE @id", Baglanti.Baglan);

                Komut.Parameters.AddWithValue("@id", txtUrunId.Text + "%");
                //Id textboxımızdaki id değeriyle başlayan tüm kayıtları listeliyoruz.

                SqlDataReader Okuyucu = Komut.ExecuteReader();
                //Listelenen bilgiyi ayrıntılı olarak kullanabilmek için Okuyucu ismini verdiğimiz SqlDataReader'a atıyoruz.

                while (Okuyucu.Read())
                //Okuyucumuzun okuduğu sürece, istediğimiz kaydı bulduğu sürece,
                {
                    txtUrunAd.Text = Okuyucu["UrunAd"].ToString();

                    txtUrunMarka.Text = Okuyucu["UrunMarka"].ToString();

                    nmrUrunMiktar.Value = decimal.Parse(Okuyucu["UrunMiktar"].ToString());

                    cmbUrunKategori.Text = Okuyucu["UrunKategori"].ToString();

                    txtUrunAciklama.Text = Okuyucu["UrunAciklama"].ToString();

                    nmrUrunFiyat.Value = decimal.Parse(Okuyucu["UrunFiyat"].ToString());

                    //Bulduğu verileri teker teker araçlarımıza gönderdik ve başarıyla görüntüledik.
                }

                Okuyucu.Close();
                //Okuyucumuzu kapattık. Kapatmazsak hata verebilir.

                Baglanti.Baglan.Close();
                //Bağlantımızı kapattık.
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //Eğer bir hata alırsak, bu komut zinciri yardımıyla program patlamadan hata mesajını MessageBox yardımıyla alacağız.

            if (txtUrunId.Text == "")
                HerseyiTemizle();
        }
    }
}
