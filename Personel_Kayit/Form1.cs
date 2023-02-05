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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //sql datamıza bağlantı yolu oluşturuyoruz
        SqlConnection baglanti = new SqlConnection("Data Source = RUZGAR\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        void temizle()
        {
            tbxId.Text = "";
            tbxAd.Text = "";
            tbxSoyad.Text = "";
            tbxMeslek.Text = "";
            mtbxMaas.Text = "";
            cbxSehirler.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tbxAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxAd.Focus();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.tbl_Personels' table. You can move, or remove it, as needed.
            this.tbl_PersonelsTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_Personels);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_Personels(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", tbxAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cbxSehirler.Text);
            komut.Parameters.AddWithValue("@p4", mtbxMaas.Text);
            komut.Parameters.AddWithValue("@p5", tbxMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);

            //executeNonQuery sorguyu çalıştırmaya yarıyor.Ekle sil güncellede kullanılıyor
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text= "False";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
