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
using System.Collections;
//ArrayList sınıfını kullanmak için içe aktardığımız kütüphane.

namespace UrunSatis
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        public string SeciliSatır(string Tablo, string Satır)
        {
            if (Tablo == "Musteriler")
                return dtMusteri.CurrentRow.Cells[Satır].Value.ToString();
            else if (Tablo == "Urunler")
                return dtUrun.CurrentRow.Cells[Satır].Value.ToString();
            else
                return "";

            //Datagridview'de seçtiğimiz satırı kontrol etmek için CurrentRow.Cells komudunu kullanıyoruz fakat ben daha iyi bir program yazmak
            //için bunu bir metod şeklinde yaptım ve formumuzda 2 datagridview olduğu için de parametreleriyle bunları farklı koşullara sokarak
            //tablosuna göre farklı satırları kontrol etmesini istedim.
        }
        
        void HerseyiListele(string Tablo)
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("SELECT * FROM "+Tablo, Baglanti.Baglan);

            SqlDataAdapter Bilgi = new SqlDataAdapter(Komut);

            DataTable BilgininTabloHali = new DataTable();

            Bilgi.Fill(BilgininTabloHali);

            if(Tablo == "Musteriler")
            {
                dtMusteri.DataSource = BilgininTabloHali;

                dtMusteri.ReadOnly = true;
            }

            if(Tablo == "Urunler")
            {
                dtUrun.DataSource = BilgininTabloHali;

                dtUrun.ReadOnly = true;
            }

            Baglanti.Baglan.Close();
            /* Formumuz yüklendiğinde veya herhangi bir kaydı sildiğimizde veya güncellediğimizde, güncel olan kayıtların listelenmesi için
             * kullanacağımız metod. Tam şu an, evet evet! Tam şuan geçerli olan kayıtları listeler. Örneğin A sütununu değiştirdikten sonra
             * hemen değişmiş sütun karşınıza çıkacak bu metod sayesinde! 2 adet datagridview'imiz olduğu için parametreye yazılacak tabloya
             göre listeleme yapacak.*/
        }
        
        void HerseyiTemizle()
        {
            lstFatura.Items.Clear();
            lblTutar.Text = "0";
            lblMusteri.Text = "Müşteri";

            //

            txtUrunId.Clear();
            txtUrunAd.Clear();
            txtUrunMarka.Clear();
            cmbUrunKategori.Text = "";
            txtUrunAciklama.Clear();
            nmrUrunMiktar.Value = 0;
            nmrUrunFiyat.Value = 0;

            //

            txtAd.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtId.Clear();
        }

        private void cmbUrunKategori_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //Combobox'a dışarıdan metin girişi yapılmasını engelliyoruz.
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //Eğer Id isimli, müşeterimizin id değeri için özel olarak ayırdığımız textbox herhangi bir sebepten ötürü değişirse,
            //aşağıdaki kodlar çalışacaktır. Bu textbox, belirttiğim datagridview'in bir satırına bir kere tıklayarak da değişebilir.

            Connection Baglanti = new Connection();
            //Connection sınıfımızdan Baglanti nesnesini türeterek bağlantımızla bir nevi tanışıyoruz.

            try
            {
                Baglanti.Baglan.Open();
                //Bağlantımızı açıyoruz.

                SqlCommand Komut = new SqlCommand("SELECT * FROM Musteriler WHERE MusteriId LIKE @id", Baglanti.Baglan);

                Komut.Parameters.AddWithValue("@id", txtId.Text + "%");
                //Id textboxımızdaki id değeriyle başlayan tüm kayıtları listeliyoruz.

                SqlDataReader Okuyucu = Komut.ExecuteReader();
                //Listelenen bilgiyi ayrıntılı olarak kullanabilmek için Okuyucu ismini verdiğimiz SqlDataReader'a atıyoruz.

                while (Okuyucu.Read())
                //Okuyucumuzun okuduğu sürece, istediğimiz kaydı bulduğu sürece,
                {
                    txtAd.Text = Okuyucu["MusteriAd"].ToString();

                    txtTelefon.Text = Okuyucu["MusteriTelefon"].ToString();

                    txtAdres.Text = Okuyucu["MusteriAdres"].ToString();

                    txtEmail.Text = Okuyucu["MusteriEmail"].ToString();
                    //Bulduğu verileri teker teker araçlarımıza gönderdik ve başarıyla görüntüledik.
                }

                Okuyucu.Close();
                //Okuyucumuzu kapattık. Kapatmazsak hata verebilir.

                Baglanti.Baglan.Close();
                //Bağlantımızı kapattık.
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //Eğer bir hata alırsak, bu komut zinciri yardımıyla program patlamadan hata mesajını MessageBox yardımıyla alacağız.

            if (txtId.Text == "")
                HerseyiTemizle();
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
        }

        private void dtMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(SeciliSatır("Musteriler", "MusteriId") != "")
            {
                txtId.Text = SeciliSatır("Musteriler", "MusteriId");
                //Datagridview'de bir satıra çift tıkladığımızda o satırın UrunId değeri, txtUrunId textboxımıza gönderilecek.
                //Peki neden yaptık bunu?
                //Bunu yaparak txtUrunId textboxının yazısını değiştirdik değil mi?
                //Ve txtUrunId textboxının yazısı değişirse diye bir olay ekleyeceğiz ve o olayda da, bu textbox'a gelen id'ye sahip
                //kaydın bütün verilerini tek tek diğer textboxlarda göstereceğiz.

                lblMusteri.Text = SeciliSatır("Musteriler", "MusteriAd");
            }
            else
                MessageBox.Show("Eksik müşteri girişi.");
        }

        ArrayList list = new ArrayList();
        //Bu listemiz, faturamıza eklediğimiz ürünlerin id numaralarını bulmak için. Faturaya eklenen ürünlerin id'leri teker teker
        //Bu listeye atılacak. Bunun sebebini kodun ilerleyen bölümlerinde daha detaylıca anlatacağım! Okumaya devam edin!!

        private void dtUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtUrun.CurrentRow.Cells["UrunId"].Value.ToString() != "")
            {
                txtUrunId.Text = dtUrun.CurrentRow.Cells["UrunId"].Value.ToString();
                //Datagridview'de bir satıra çift tıkladığımızda o satırın UrunId değeri, txtUrunId textboxımıza gönderilecek.
                //Peki neden yaptık bunu?
                //Bunu yaparak txtUrunId textboxının yazısını değiştirdik değil mi?
                //Ve txtUrunId textboxının yazısı değişirse diye bir olay ekleyeceğiz ve o olayda da, bu textbox'a gelen id'ye sahip
                //kaydın bütün verilerini tek tek diğer textboxlarda göstereceğiz.

                lstFatura.Items.Add(
                "1 tn. | " + SeciliSatır("Urunler", "UrunAd") + " | " + SeciliSatır("Urunler", "UrunFiyat") + "₺"
                );//2 kere tıklanan ürünü Listbox'da bu mesajla görüntülüyoruz.

                list.Add(SeciliSatır("Urunler", "UrunId"));
                //Seçilmiş ürünün Id'sini ArrayList'imize ekliyoruz.

                decimal Tutar = decimal.Parse(lblTutar.Text);

                Tutar += decimal.Parse(SeciliSatır("Urunler", "UrunFiyat"));

                lblTutar.Text = Tutar.ToString();
                //Şimdi ise Tutarı görüntülemek içni özel olarak oluşturduğumuz label'in tutarını güncelliyoruz.
                //Datagridview'e çift tıklandığında ürün ekleniyorsa, faturamızdaki tutar da artıyor. Ve tutarımız, bu labelimizde güncel kalacak.
            }
            else
                MessageBox.Show("Eksik ürün girişi.");
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            HerseyiListele("Urunler");//Urunler tablosunu ürünler için özel olarak oluşturduğum datagridview'e at.
            HerseyiListele("Musteriler");//Musteriler tablosunu müşteriler için özel olarak oluşturduğum datagridview'e at.

            dtMusteri.Columns[0].HeaderText = "ID";
            dtMusteri.Columns[1].HeaderText = "Ad";
            dtMusteri.Columns[2].HeaderText = "Telefon";
            dtMusteri.Columns[3].HeaderText = "Adres";
            dtMusteri.Columns[4].HeaderText = "Email";
            dtMusteri.Columns[5].HeaderText = "Kayıt Tarih";

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

            SqlCommand Komut = new SqlCommand("SELECT * FROM Musteriler WHERE MusteriId LIKE @id", Baglanti.Baglan);

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

            dtMusteri.DataSource = BilgininTabloHali;
            //Nihayet tablomuz oluşturulduğunda, bu tabloyu datagridview'de görüntüleyebiliriz.

            Baglanti.Baglan.Close();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("SELECT * FROM Urunler WHERE UrunId LIKE @id", Baglanti.Baglan);

            Komut.Parameters.AddWithValue("@id", txtUrunArama.Text + "%");
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HerseyiTemizle();
        }

        bool Hata = false;
        //Yazacağımız bazı şartlarla birlikte eğer bir hata bulursak başlangıçta değeri False olan bool değişkenimizin değeri True olacak.
        //Eğer zaten hiçbir sorun yoksa hata analizi için yaptığımız koşulların hiçbiri sağlanmayacak ve bu değişkenimizin değeri hiç değişmeyeceği
        //için, hiçbir şey ona dokunmayacak ve şimdi olduğu gibi false kalacak.

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if(lblMusteri.Text == "Müşteri" || lblTutar.Text == "0")//Müşteri ve ürün girilip girilmediğini kontrol ediyoruz.
            {
                MessageBox.Show("Eksik sipariş girişi.");
            }
            else//Eğer bir sorun yoksa,
            {
                Connection Baglanti = new Connection();
                //Connection sınıfımızdan nesne türettik.

                Baglanti.Baglan.Open();
                //Bağlantımızı açtık.

                string[] IDs = new string[list.Count];
                IDs = (string[])list.ToArray(typeof(string));
                //Ürün id'lerini attığımız ArrayList'i int[] dizeye çevirdik. Böyle yapmak daha kolayıma geldi açıkçası.
                //Şimdi,
                //Neden idleri bir dizeye attık?
                //Çünkü biz, Sipariş vermek için özel olarak oluşturduğumuz butonumuza tıklayınca sipariş işlemleri başlasın istiyoruz.
                //Yani buraya kadar olan herşey faturanın taslağını oluşturmak içindi.
                //Eğer faturamız hazırsa, bu butona tıklandığında bütün güncelleme işlemlerini yürütmeye başlayacağız.
                //Peki ne güncellemesi?
                //Sipariş vererek ürünlerimizin stoklarını azaltırız değil mi? 2 muzdan 1 muz alırsan aldığın yerin stoğunda 1 muz kalır.
                //Ve biz ürünlerimiz alındığında veritabanımızdaki alınan ürünün adetini -1 düşeriz. Bu gayet basit.
                //Peki faturamızda alınan ürünlere nasıl ulaşacağız? Çok kolay!
                //Listbox'ımıza id değerlerini eklemiştik hatırlarsanız, ve yukarıda oluşturduğumuz ArrayList'e bunları teker teker atmıştık.
                //ArrayList'imizin içindeki ürün id'lerinin teker teker miktar değerlerini bulup -1 azaltacağız! Bu kadar!
                //Hadi yapalım;


                for (int j = 0; j < IDs.Length; j++)
                    //Önce siparişi verilmek istenen üründen yeteri kadar var mı onu kontrol edelim. Eğer yeteri kadar yoksa,
                    //Hatayı kontrol etmesi için özel olarak oluşturduğumuz değişkenimiz bize hatanın olup olmadığını söyleyecek.
                {
                    decimal Miktar = 0;

                    SqlCommand KomutSelect = new SqlCommand("SELECT * FROM Urunler WHERE UrunId=@id", Baglanti.Baglan);

                    KomutSelect.Parameters.AddWithValue("@id", IDs[j]);

                    SqlDataReader Okuyucu = KomutSelect.ExecuteReader();

                    if (Okuyucu.Read())
                    {
                        Miktar = int.Parse(Okuyucu["UrunMiktar"].ToString());
                    }

                    Okuyucu.Close();

                    if (Miktar == 0)
                    {
                        Hata = true;
                        //Hata varsa, Hata değişkenimiz True olarak bize hatanın olduğunu söylüyor.
                    }
                }

                for (int i = 0; i < IDs.Length; i++)
                {
                    if (Hata == false)//Eğer Hata değişkenimiz False'sa yani hata yoksa;
                    {
                        decimal Miktar = 0;

                        SqlCommand KomutSelect = new SqlCommand("SELECT * FROM Urunler WHERE UrunId=@id", Baglanti.Baglan);

                        KomutSelect.Parameters.AddWithValue("@id", IDs[i]);

                        SqlDataReader Okuyucu = KomutSelect.ExecuteReader();

                        if (Okuyucu.Read())
                        {
                            Miktar = int.Parse(Okuyucu["UrunMiktar"].ToString());
                        }

                        Okuyucu.Close();

                        SqlCommand Komut = new SqlCommand("UPDATE Urunler SET UrunMiktar=@miktar WHERE UrunId=@id", Baglanti.Baglan);
                        //Güncelleme işlemi için yazmamız gereken sql sorgusunu yazdık.

                        Komut.Parameters.AddWithValue("@miktar", Miktar - 1);
                        //@miktar parametresini, Miktar değişkenimdeki değerle doldur.
                        Komut.Parameters.AddWithValue("@id", IDs[i]);
                        //Sorgumuzun içindeki @id değerini, listemizin 'i.' değeriyle doldurduk.

                        Komut.ExecuteNonQuery();
                        //Sorgumuzu yürüttük.

                        HerseyiListele("Urunler");
                        //Urunler tablomuz güncellendiği için Urunler tablomuzu gosteren datagridview'i de yeniledik.

                        list.Clear();
                        //Eğer ArrayList'imizi temizlemezsek, kodumuzda karışıklığa yol açacak ve daha önceki kayıtlarla kafası karışacaktı.
                    }
                }

                if (Hata == true)
                    MessageBox.Show("Siparişi verilmek istenen ürünlerden bir veya bir kaçının stokları tükenmiş.");
                else
                {
                    MessageBox.Show("Sipariş başarılı.");

                    //Ve şimdi oluşturduğumuz faturayı yazdırma vakti !!!

                    printDialog1.Document = printDocument1;

                    if(printDialog1.ShowDialog()==DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    HerseyiTemizle();
                }
                    

                Baglanti.Baglan.Close();
                //Bağlantımızı kapattık.

                Hata = false;
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush s = new SolidBrush(Color.Black);
                //Font ve fırça tanımlıyoruz.

                e.Graphics.DrawString("Tarih : " + DateTime.Now.ToString(),
                    font,s,50,25);
                //Tarihi yazıyoruz.

                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("Müşteri : " + lblMusteri.Text, font, s, 350, 75);
                e.Graphics.DrawString("***************", font, s, 320, 115);
                //Müşteri bilgisini yazıyoruz.

                font = new Font("Arial",15, FontStyle.Italic);
                int Loc = 100;
                //Fontu güncelliyoruz ve Loc isimli bir değişken oluşturuyoruz. Bunun ne olduğu aşağıda!

                for (int i = 0; i < lstFatura.Items.Count; i++)
                    //Her bir ürün siparişimizi tek tek yazdırmak için for döngüsü kullanıyoruz.
                {
                    Loc += 50;
                    //Bu Loc mantığı ise şu,
                    //Boş bir sayfaya bir yazı yazdırmak için önce yazı yazacağımız yerin lokasyonunu yani "X" ve "Y"
                    //değerlerini bilmemiz gerekiyor. Sürekli aynı "X" ve "Y" değerlerine yazsaydık hiçbir şey okunamazdı çünkü üst üste yazılırdı.
                    //Bizde tıpkı defterlerimizde yaptığımız gibi bir satır alta geçmeliyiz.
                    //Ama burada satır yok, bomboş bir kağıt var. O zaman metre hesabı gibi düşünelim.
                    //Bu Loc değişkenimiz faturamızdaki her bir ürünü kağıdımıza yazdırdıktan sonra 50 cm aşağı iniyor gibi düşünebiliriz.

                    e.Graphics.DrawString(lstFatura.Items[i].ToString(), font, s, 60, Loc);
                    //Siparişi verilen sıradaki ürünü yazdırdık.

                }

                e.Graphics.DrawString("Tutar : " + lblTutar.Text, font, s, 250, Loc+100);
                //Tutarı yazıyoruz.

            }
            catch (Exception)
            {

            }
        }
    }
}
