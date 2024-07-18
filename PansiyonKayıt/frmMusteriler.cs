using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace PansiyonKayıt
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pansiyon;Integrated Security=True");  // çift slash adres haline getirmek demek
        //ERİŞİM BELİRLEYİCİ
        private void verilerigoster()
        {
            listView1.Items.Clear(); //tekrar tekrar alt alta listelememesi için her tıkladığında prayı silip listelesin
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from Musteri",sqlConnection); //komut yazıp (.sqlconnection) ile komutu sql connection bağlantısı ile ilişkilendirdim
            SqlDataReader oku = komut.ExecuteReader();
            /*SqlDataReader: Data verilerini oku
             * okuduktan sonra while döngüsü ile oku komutu çalıştığı müddetçe --- olsun
            */
            while (oku.Read())   //oku komutum çalıştığı müddetçe 
            {
                ListViewItem ekle = new ListViewItem(); //ListViewItem bir nesne ürettim
            
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["TCKimlik"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CıkısTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtEmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            mskTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpcGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcCıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtOda.Text == "101")
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 ", sqlConnection); //Burada sadece oda101 tablosundan siliyoruz yani data genel listede kalıyor !!! 
                komut.ExecuteNonQuery();
                sqlConnection.Close();
                verilerigoster();  // silme işlemleri tamamlandıktan sonra tekrar listele tıklamak yerine verilerigoster() bu metodu tekrar yaz kendi listeledikten sonra silsin
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtOda.Text == "102")
            {
                sqlConnection.Open();
                SqlCommand cmd2 = new SqlCommand("delete from oda102 ", sqlConnection);
                cmd2.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "103")
            {
                sqlConnection.Open();
                SqlCommand cmd3 = new SqlCommand("delete from oda103 ", sqlConnection);
                cmd3.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "104")
            {
                sqlConnection.Open();
                SqlCommand cmd4 = new SqlCommand("delete from oda104 ", sqlConnection);
                cmd4.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "105")
            {
                sqlConnection.Open();
                SqlCommand cmd5 = new SqlCommand("delete from oda105 ", sqlConnection);
                cmd5.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "106")
            {
                sqlConnection.Open();
                SqlCommand cmd6 = new SqlCommand("delete from oda106 ", sqlConnection);
                cmd6.ExecuteNonQuery();
                sqlConnection.Close();
                verilerigoster();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "107")
            {
                sqlConnection.Open();
                SqlCommand cmd7 = new SqlCommand("delete from oda107 ", sqlConnection);
                cmd7.ExecuteNonQuery();
                sqlConnection.Close();
                verilerigoster();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "108")
            {
                sqlConnection.Open();
                SqlCommand cmd8 = new SqlCommand("delete from oda108 ", sqlConnection);
                cmd8.ExecuteNonQuery();
                sqlConnection.Close();
                verilerigoster();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
            if(txtOda.Text == "109")
            {
                sqlConnection.Open();
                SqlCommand cmd9 = new SqlCommand("delete from oda109 ", sqlConnection);
                cmd9.ExecuteNonQuery();
                sqlConnection.Close();
                verilerigoster();
                MessageBox.Show("Müşteri kaydı silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verilerigoster();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbCinsiyet.Text = "";
            mskTelefon.Text = "";
            txtEmail.Text = "";
            mskTC.Text = "";
            txtOda.Text = "";
            txtUcret.Text = "";
            dtpcGiris.Text = "";
            dtpcCıkıs.Text = "";
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("update Musteri set " +
            "Ad ='"+txtAd.Text+"',Soyad = '"+txtSoyad.Text+"',Cinsiyet = '"+cmbCinsiyet.Text+"',Telefon = '"+mskTelefon.Text+"',Email = '"+txtEmail.Text+"',TCKimlik = '"+ mskTC.Text+"',OdaNo = '"+txtOda.Text+"',Ucret = '"+txtUcret.Text+"',GirisTarih = '"+ dtpcGiris.Value.ToString("yyyy-MM-dd") + "',CıkısTarih = '"+ dtpcCıkıs.Value.ToString("yyyy-MM-dd") + "' where MusteriID = '"+id+"'",sqlConnection);
            komut.ExecuteNonQuery(); //BUNU YAZMAYI UNUTMA YOKSA ÇALIŞMAZ DÜZGÜN :: ExecuteNonQuery: PARAMETRELER ÜZERİNDE DEĞİŞİKLİK YAP    //üsteki kod bloğunda dtpcGiris.Value.ToString("yyyy-MM-dd") datetime ları bu şekil yazmayı UNTUMA !!! ÇÜNKÜ SQL DEKİ ŞEKLİNDE YAZMAN GEREK
            sqlConnection.Close();
            MessageBox.Show("Müşteri kaydı Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verilerigoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //VerileriGöster() METODUNDA Kİ KODU BURAYA YAPIŞTIRIYORUZ ONA SADECE BİR KOD EKLİCEK KOŞUL EKLİCEZ!!!
            listView1.Items.Clear(); 
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Musteri WHERE Ad LIKE '%' + @AramaCubugu + '%'", sqlConnection);
            komut.Parameters.AddWithValue("@AramaCubugu", txtAramaCubugu.Text); 
            SqlDataReader oku = komut.ExecuteReader();
           
            while (oku.Read())   //oku komutum çalıştığı müddetçe 
            {
                ListViewItem ekle = new ListViewItem(); //ListViewItem bir nesne ürettim
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["TCKimlik"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CıkısTarih"].ToString());

                listView1.Items.Add(ekle);
            }
            sqlConnection.Close();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaform frmAnaform = new frmAnaform();
            frmAnaform.Show();
        }
        private void btnCıkıs_MouseHover(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = Color.Red;
        }

        private void btnCıkıs_MouseLeave(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = SystemColors.ControlDarkDark;
        }

        // SqlCommand komut = new SqlCommand("delete from Musteri where MusteriId=(" + id + ")", sqlConnection); //MusteriId : tablodaki id alanı / id: bizim yaptığımız global değişken

    }
}
