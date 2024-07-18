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
    public partial class frmMusteriMesajları : Form
    {
        public frmMusteriMesajları()
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
            SqlCommand komut = new SqlCommand("select * from Mesajlar", sqlConnection); 
            SqlDataReader oku = komut.ExecuteReader();
           
            while (oku.Read())   //oku komutum çalıştığı müddetçe 
            {
                ListViewItem ekle = new ListViewItem(); //ListViewItem bir nesne ürettim
                ekle.Text = oku["MesajID"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into mesajlar (adsoyad,mesaj) values ('" +txtadsoyad.Text+ "','" +rctxtMesaj.Text+ "')",sqlConnection);
            sqlCommand.ExecuteNonQuery(); //parametrede değişiklik yapması için 
            sqlConnection.Close();
            MessageBox.Show("Mesajınız sisteme kaydedilmiştir","Kaydedildi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int Id = 0;
            Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadsoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            rctxtMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
