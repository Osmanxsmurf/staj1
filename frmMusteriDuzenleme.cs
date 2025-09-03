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

namespace UrunSatis
{
    public partial class frmMusteriDuzenleme : Form
    {
        public frmMusteriDuzenleme()
        {
            InitializeComponent();
        }
        void HerseyiTemizle()
        {
            txtAd.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtId.Clear();
        }
        void HerseyiListele()
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            string Sorgu = "SELECT * FROM Musteriler";

            SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);

            SqlDataAdapter Bilgi = new SqlDataAdapter(Komut);

            DataTable BilgininTabloHali = new DataTable();

            Bilgi.Fill(BilgininTabloHali);

            dtMusteri.DataSource = BilgininTabloHali;

            dtMusteri.ReadOnly = true;

            Baglanti.Baglan.Close();
        }
        private void frmMusteriDuzenleme_Load(object sender, EventArgs e)
        {
            HerseyiListele();

            dtMusteri.Columns[0].HeaderText = "ID";
            dtMusteri.Columns[1].HeaderText = "Ad";
            dtMusteri.Columns[2].HeaderText = "Telefon";
            dtMusteri.Columns[3].HeaderText = "Adres";
            dtMusteri.Columns[4].HeaderText = "Email";
            dtMusteri.Columns[5].HeaderText = "Kayıt Tarih";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtMusteri.CurrentRow.Cells["MusteriId"].Value.ToString();
        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            Connection Baglanti = new Connection();

            try
            {
                Baglanti.Baglan.Open();

                SqlCommand Komut = new SqlCommand("SELECT * FROM Musteriler WHERE MusteriId LIKE @id", Baglanti.Baglan);

                Komut.Parameters.AddWithValue("@id", txtId.Text + "%");

                SqlDataReader Okuyucu = Komut.ExecuteReader();

                while (Okuyucu.Read())
                {
                    txtAd.Text = Okuyucu["MusteriAd"].ToString();

                    txtTelefon.Text = Okuyucu["MusteriTelefon"].ToString();

                    txtAdres.Text = Okuyucu["MusteriAdres"].ToString();

                    txtEmail.Text = Okuyucu["MusteriEmail"].ToString();
                }

                Okuyucu.Close();

                Baglanti.Baglan.Close();
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (txtId.Text == "")
                HerseyiTemizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HerseyiTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string Adres = txtAdres.Text;
            string Telefon = txtTelefon.Text;
            string Email = txtEmail.Text;

            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("UPDATE Musteriler SET MusteriAd=@ad,MusteriTelefon=@telefon,MusteriAdres=@adres,MusteriEmail=@email WHERE MusteriId=@id", Baglanti.Baglan);

            Komut.Parameters.AddWithValue("@ad", Ad);
            Komut.Parameters.AddWithValue("@telefon", Telefon);
            Komut.Parameters.AddWithValue("@adres", Adres);
            Komut.Parameters.AddWithValue("@email", Email);

            Komut.Parameters.AddWithValue("@id", dtMusteri.CurrentRow.Cells["MusteriId"].Value.ToString());

            Komut.ExecuteNonQuery();

            Baglanti.Baglan.Close();

            MessageBox.Show("Müşteri güncelleme işlemi başarıyla tamamlandı !!");

            HerseyiListele();

            HerseyiTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("DELETE FROM Musteriler WHERE MusteriId=@id", Baglanti.Baglan);

            Komut.Parameters.AddWithValue("@id", dtMusteri.CurrentRow.Cells["MusteriId"].Value.ToString());

            Komut.ExecuteNonQuery();

            Baglanti.Baglan.Close();

            MessageBox.Show("Müşteri silme işlemi başarıyla tamamlandı !!");

            HerseyiListele();

            HerseyiTemizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Connection Baglanti = new Connection();

            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("SELECT * FROM Musteriler WHERE MusteriId LIKE @id", Baglanti.Baglan);

            Komut.Parameters.AddWithValue("@id", txtArama.Text + "%");

            SqlDataAdapter Bilgi = new SqlDataAdapter(Komut);

            DataTable BilgininTabloHali = new DataTable();

            Bilgi.Fill(BilgininTabloHali);

            dtMusteri.DataSource = BilgininTabloHali;

            Baglanti.Baglan.Close();
        }
    }
}
