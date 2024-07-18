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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
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
    

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //PARAMETRE İLE YAPICAZ & TRY-CATCHBLOĞU (try isteidğin koşul doğruysa gerçekleştirir değilse catch bloğu hata ile yakalıyor)
            //try
            //{
                sqlConnection.Open();
                string sql = "select * from AdminHesap where Kullanici = @Kullanici and Sifre = @Sifre";
                SqlParameter prm1 = new SqlParameter("Kullanici",txtKullanıcıAdı.Text.Trim());
                //SqlCommand komut = new SqlCommand("select * from admingiris where Kullanici = @Kullanici and Sifre = @Sifre");
                //komut.Parameters.AddWithValue("@Param1", "Değer1");  AYNI ANLAMA GELİYOR
                //TRIM() : Trim() metodu, bir dizedeki baştaki ve sondaki boşluk karakterlerini kaldırmak için kullanılır. Boşluk karakterleri, normal boşluk, sekme (tab), yeni satır ve diğer benzer karakterleri içerir.
                SqlParameter prm2 = new SqlParameter("Sifre", txtSifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql,sqlConnection); //sql string i ile sqlconnection ı biribirne bağlıyoruz!!!
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                //SANAL TABLO OLUŞTURUYORUZ
                DataTable dt = new DataTable();
                //OLUŞTURDUĞUMUZ BU SANAL TABLO İÇİN BİR SQL DATAADAPTER OLUŞTURCAZ
                //SONRA BU DATAADAPTER İLE BU SANAL TABLONUN İÇİNİ DOLDURUCAZ
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);  //dataadapter ile dt tablonun içini dolduruyoruz
                sqlConnection.Close();
                //dt.Rows.Count > 0 : DataTable içinde en az bir satır varsa(veritabanından en az bir kayıt alındıysa), belirtilen işlemleri gerçekleştirir.
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya parola", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKullanıcıAdı.Clear();
                    txtSifre.Clear();
                }
                

            //}
            ////BURADA BİR EKSİKLİK VAR DİKKAT ET!!!!
            //catch (Exception)
            //{
            //    MessageBox.Show("Hatalı kullanıcı adı veya parola", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtKullanıcıAdı.Clear();
            //    txtSifre.Clear();
            //}
        }
    }
}
