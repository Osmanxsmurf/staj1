using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//SqlConnection komutunu kullanabilmek için bu kütüphaneyi içe aktarmamız gerekiyor.

namespace UrunSatis
{
    internal class Connection
    {
        /*Programımızın farklı yerlerinde sql sunucumuzun bağlantı dizesine ve "SqlConnection" komutunu kullanmaya ihtiyaç duyacağımız için,
        * Her ihtiyaç duyduğumuzda bunları tekrar tanımlayıp zaman kaybetmemek için oluşturduğumuz bu sınıfta, bağlantı dizemizi programımıza
        * tanıtacak ve ihtiyaç duyduğumuzda programımızın herhangi bir yerinden kullanabileceğiz.
        */

        private static string BaglantiDizesi = "Server=.;Database=SatısProgrami;Trusted_Connection=True;";

        public SqlConnection Baglan = new SqlConnection(BaglantiDizesi);
    }
}
