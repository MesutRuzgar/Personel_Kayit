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
            this.tbl_PersonelsTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_Personels);
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
            if (radioButton1.Checked == true)
            {
                label1.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "False";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid de tıkladığımız sütundaki satır indexini secilen değerine atamış olduk
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            //seçilen hücre değeri sql datasındaki sıralamadan geliyor
            //datagrid in satırları içerisinde secilen satır hücreleri içerisinde 0. değerini string olarak yazdır komutu

            tbxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbxSehirler.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtbxMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            //label eventinden textChanged yani yazı değiştiğinde ne olacak'a çift tıklayıp kodlarımızı doldurduk
            if (label1.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label1.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete From tbl_Personels Where PerId=@k1", baglanti);
            komutSil.Parameters.AddWithValue("@k1", tbxId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update tbl_Personels Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where PerId=@a7" , baglanti);

            komutGuncelle.Parameters.AddWithValue("@a1", tbxAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", tbxSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", cbxSehirler.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", mtbxMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", label1.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", tbxMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@a7", tbxId.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Başarıyla Güncellendi");
        }
    }
}
