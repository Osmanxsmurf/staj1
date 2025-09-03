using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunSatis
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle UrunEkleme = new frmUrunEkle();

            UrunEkleme.Show();
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            frmUrunDuzenleme UrunDuzenleme = new frmUrunDuzenleme();

            UrunDuzenleme.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle MusteriEkle = new frmMusteriEkle();

            MusteriEkle.Show();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            frmMusteriDuzenleme MusteriDuzenle = new frmMusteriDuzenleme();

            MusteriDuzenle.Show();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmSiparis SiparisEkranı = new frmSiparis();

            SiparisEkranı.Show();
        }
    }
}
