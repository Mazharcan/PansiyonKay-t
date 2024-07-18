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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();                                                     //sqlConnection bağlamayı UNUTMA!!
            SqlCommand sqlCommand = new SqlCommand("Select sum (Ucret) as toplam from Musteri",sqlConnection);   //SQL SORGUDU SUM(UCRET) SÜTUNUNDAKİ DEĞERLERİ TOPLA, AS TOPLAM BU SONUCA TOPLAM İSMİNİ VER
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();       
            while (sqlDataReader.Read())
            {
                lblToplamTutar.Text = sqlDataReader["toplam"].ToString();
            }
            sqlDataReader.Close();
            int personelMaas,personelSayisi;
            personelMaas = Convert.ToInt16(txtPersonelMaas.Text);
            personelSayisi = Convert.ToInt16(txtPersonelSayısı.Text);
            lblToplamPersonelMaas.Text = (personelMaas*personelSayisi).ToString();

            SqlCommand cmd = new SqlCommand("SELECT SUM(gida) + SUM(icecek) + SUM(cerez) as urunToplam FROM StokTutarı", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAlınanUrunTutarı.Text = reader["urunToplam"].ToString();
            }
            sqlConnection.Close();
            reader.Close();

            sqlConnection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(elektrik) + SUM(su) + SUM(internet) as faturaToplam FROM faturalar", sqlConnection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                lblFatura.Text = reader2["faturaToplam"].ToString();
            }
            sqlConnection.Close();

            int gider;
            gider = (Convert.ToInt32(lblFatura.Text) + Convert.ToInt32(lblAlınanUrunTutarı.Text) + Convert.ToInt32(lblToplamPersonelMaas.Text));
            lblGider.Text = gider.ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblToplamTutar.Text) - Convert.ToInt32(lblGider.Text);
            lblSonuc.Text = sonuc.ToString();

            if (sonuc > 0)
            {
                lblNetSonuc.Text = "NET KAR : " + sonuc.ToString() + "TL";
            }
            else 
            {
                lblNetSonuc.Text = "NET ZARAR : " + sonuc.ToString() + "TL";
            }
        }

       
    }
}
