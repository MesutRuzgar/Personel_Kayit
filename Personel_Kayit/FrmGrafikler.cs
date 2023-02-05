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

namespace Personel_Kayit
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = RUZGAR\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutG1 = new SqlCommand("Select PerSehir,Count(*) From tbl_Personels Group By PerSehir", baglanti);
            SqlDataReader dr1 = komutG1.ExecuteReader();
            while (dr1.Read())
            {
                //grafiğin seri adı sonra points dediğimiz kordinat diyebiliriz x yani yatay; count y değeridir yani dikey.
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            //hangi meslek ort ne maaş alıyor
            baglanti.Open();
            SqlCommand komutG2 = new SqlCommand("Select PerMeslek,AVG(PerMaas) From tbl_Personels Group By PerMeslek", baglanti);
            SqlDataReader dr2 = komutG2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            
            baglanti.Close();
        }
    }
}
