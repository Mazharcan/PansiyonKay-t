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

namespace PansiyonKayıt
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pansiyon;Integrated Security=True");  // çift slash adres haline getirmek demek
        private void btn101_Click(object sender, EventArgs e)
        {
            txtOda.Text = "101";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda101 (Ad,Soyad) values ('"+txtAd.Text+"','"+txtSoyad.Text+"')",sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOda.Text = "102";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda102 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOda.Text = "103";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda103 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOda.Text = "104";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda104 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOda.Text = "105";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda105 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOda.Text = "106";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda106 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOda.Text = "107";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda107 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOda.Text = "108";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda108 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOda.Text = "109";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into oda109 (Ad,Soyad) values ('" + txtAd.Text + "','" + txtSoyad.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }



        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odalardır.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odalardır.");
        }

        private void dtpcCıkıs_ValueChanged(object sender, EventArgs e)
        {
            //ikinci tarih girildiğinde 2 gün aralğında ki fiyatı hesaplasın
            int ucret;
            DateTime giristarih = Convert.ToDateTime(dtpcGiris.Text);
            DateTime cıkıstarih = Convert.ToDateTime(dtpcCıkıs.Text);
            TimeSpan sonuc = cıkıstarih - giristarih;  //Tarihleri birbirnden çıkarmak için kullanılır

            label11.Text = sonuc.TotalDays.ToString(); //lbl a toplam gün olarak yazdır (totaldays)
            ucret = Convert.ToInt32(label11.Text); //label11 deki değer tarih zaman cinsinden sayı değeri old onu int olarak kulanmak için convert ettin

            txtUcret.Text = (ucret*3500).ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Bu örnekte, string.IsNullOrWhiteSpace fonksiyonu kullanılarak alanların boş veya yalnızca boşluk karakterleri içerip içermediği kontrol edilmektedir.
            //Eğer bir alan boşsa veya yalnızca boşluk içeriyorsa, bir uyarı gösterilir ve kayıt işlemi devam ettirilmez.
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(cmbCinsiyet.Text) || string.IsNullOrWhiteSpace(mskTelefon.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(mskTC.Text) || string.IsNullOrWhiteSpace(txtOda.Text) || string.IsNullOrWhiteSpace(txtUcret.Text) || string.IsNullOrWhiteSpace(dtpcGiris.Text) || string.IsNullOrWhiteSpace(dtpcCıkıs.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kayıt işlemi iptal ediliyor
            }
            else
            {
                sqlConnection.Open();   //sqlconnection ı aç 
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Musteri (Ad,Soyad,Cinsiyet,Telefon,Email,TCKimlik,OdaNo,Ucret,GirisTarih,CıkısTarih)values (" +
                    "'" + txtAd.Text + "'" +
                    ",'" + txtSoyad.Text + "'" +
                    ",'" + cmbCinsiyet.Text + "'" +
                    ",'" + mskTelefon.Text + "'" +
                    ",'" + txtEmail.Text + "'" +
                    ",'" + mskTC.Text + "'" +
                    ",'" + txtOda.Text + "'" +
                    ",'" + txtUcret.Text + "'" +
                    ",'" + dtpcGiris.Value.ToString("yyyy-MM-dd") + "'" + // dtpcGiris.Text şeklinde yazarsan hata alırsın dtpcGiris.Value.ToString("yyyy-MM-dd") dtpcGiris.value (ordaki değeri al) .toString(yyyy-MM-dd) stringe çevir ama sqldeki yyyy-MM-dd bu formatta "MM" olması gerekir !!!!!!   
                    ",'" + dtpcCıkıs.Value.ToString("yyyy-MM-dd") + "')", sqlConnection); //komut adında nesne oluşturdun buda bir komut oluşturcak ve ,sqlconnection ile bunu sqlconnection nesnesi ile ilişkilendirdin
                sqlCommand.ExecuteNonQuery();  // gönderilen parametreler üzerinde değişiklik yapar update insert delete..
                MessageBox.Show("Müşteri kaydı yapıldı.", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
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
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            cmbCinsiyet.Text = "";
            mskTelefon.Text = "";
            txtEmail.Clear();
            mskTC.Text = "";
            txtOda.Clear();
            txtUcret.Clear();
            dtpcGiris.Text = "";
            dtpcCıkıs.Text = "";
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //ODA101
            sqlConnection.Open();
            SqlCommand cmd1 = new SqlCommand("select * from oda101", sqlConnection);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                btn101.Text = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;    //btn101 eğer 101 e şit değilse kırmızı yap be enabled özelliği pasif olsun
            }
            //ODA102
            sqlConnection.Open();
            SqlCommand cmd2 = new SqlCommand("select * from oda102", sqlConnection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                btn102.Text = reader2["Ad"].ToString() + " " + reader2["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }
            //ODA103
            sqlConnection.Open();
            SqlCommand cmd3 = new SqlCommand("select * from oda103", sqlConnection);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                btn103.Text = reader3["Ad"].ToString() + " " + reader3["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }
            //ODA104
            sqlConnection.Open();
            SqlCommand cmd4 = new SqlCommand("select * from oda104", sqlConnection);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                btn104.Text = reader4["Ad"].ToString() + " " + reader4["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }
            //ODA105
            sqlConnection.Open();
            SqlCommand cmd5 = new SqlCommand("select * from oda105", sqlConnection);
            SqlDataReader reader5 = cmd4.ExecuteReader();
            while (reader5.Read())
            {
                btn105.Text = reader5["Ad"].ToString() + " " + reader5["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }
            //ODA106
            sqlConnection.Open();
            SqlCommand cmd6 = new SqlCommand("select * from oda106", sqlConnection);
            SqlDataReader reader6 = cmd6.ExecuteReader();
            while (reader6.Read())
            {
                btn106.Text = reader6["Ad"].ToString() + " " + reader6["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }
            //ODA107
            sqlConnection.Open();
            SqlCommand cmd7 = new SqlCommand("select * from oda107", sqlConnection);
            SqlDataReader reader7 = cmd7.ExecuteReader();
            while (reader7.Read())
            {
                btn107.Text = reader7["Ad"].ToString() + " " + reader7["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }
            //ODA108
            sqlConnection.Open();
            SqlCommand cmd8 = new SqlCommand("select * from oda108", sqlConnection);
            SqlDataReader reader8 = cmd8.ExecuteReader();
            while (reader8.Read())
            {
                btn108.Text = reader8["Ad"].ToString() + " " + reader8["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }
            //ODA109
            sqlConnection.Open();
            SqlCommand cmd9 = new SqlCommand("select * from oda109", sqlConnection);
            SqlDataReader reader9 = cmd9.ExecuteReader();
            while (reader9.Read())
            {
                btn109.Text = reader9["Ad"].ToString() + " " + reader9["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false; 
            }
        }

      
    }
}
