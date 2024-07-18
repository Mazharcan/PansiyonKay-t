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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pansiyon;Integrated Security=True");  // çift slash adres haline getirmek demek
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaform frmAnaform = new frmAnaform(); 
            frmAnaform.Show();
        }

        private void verilerigoster()
        {
            listView1.Items.Clear(); 
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from AdminHesap", sqlConnection); 
            SqlDataReader oku = komut.ExecuteReader();
           
            while (oku.Read())   //oku komutum çalıştığı müddetçe 
            {
                ListViewItem ekle = new ListViewItem(); //ListViewItem bir nesne ürettim
                ekle.Text = oku["AdminID"].ToString();
                ekle.SubItems.Add(oku["Kullanici"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());
                listView1.Items.Add(ekle);
            }
            sqlConnection.Close();
        }
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("update AdminHesap set Kullanici ='" + txtKullanıcıadı.Text + "',Sifre = '" + txtSifre.Text + "' where AdminID = '" + id + "'", sqlConnection);
            komut.ExecuteNonQuery(); //BUNU YAZMAYI UNUTMA YOKSA ÇALIŞMAZ DÜZGÜN :: ExecuteNonQuery: PARAMETRELER ÜZERİNDE DEĞİŞİKLİK YAP    //üsteki kod bloğunda dtpcGiris.Value.ToString("yyyy-MM-dd") datetime ları bu şekil yazmayı UNTUMA !!! ÇÜNKÜ SQL DEKİ ŞEKLİNDE YAZMAN GEREK
            sqlConnection.Close();
            MessageBox.Show("Müşteri kaydı Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into AdminHesap (Kullanici,sifre) values ('" + txtKullanıcıadı.Text + "','" + txtSifre.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Admin kaydı gerçekleştirildi","Kayıt Yapıldı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            sqlConnection.Close();
            verilerigoster();
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKullanıcıadı.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSifre.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("delete from AdminHesap where AdminID = '" +id+ "'",sqlConnection);
            sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Admin kaydı silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            verilerigoster();
        }
    }
}
