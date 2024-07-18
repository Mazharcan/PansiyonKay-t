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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pansiyon;Integrated Security=True");  // çift slash adres haline getirmek demek
        //VERİLERİ LİSTELEMEK İÇİN METOT OLUŞTUR
        private void verilerGoster()
        {
            listView1.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from StokTutarı",sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem listıtem = new ListViewItem();
                listıtem.Text = reader["Gida"].ToString();
                listıtem.SubItems.Add(reader["Icecek"].ToString());
                listıtem.SubItems.Add(reader["Cerez"].ToString());
                listView1.Items.Add(listıtem);
            }
            sqlConnection.Close();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into stoktutarı (gida,icecek,cerez) values ('" +txtGıda.Text+ "','"+txtIcecek.Text+ "','"+txtCerez.Text+"')",sqlConnection);
            cmd.ExecuteNonQuery();  //girilen parametreler üzerinde değişiklikleri yapıcak
            sqlConnection.Close();
            verilerGoster();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            frmAnaform frmAnaform = new frmAnaform();
            this.Hide();
            frmAnaform.Show();
        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            verilerGoster();
        }
        private void verileriGoster()
        {
            listView2.Items.Clear();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Faturalar", sqlConnection);
            SqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                ListViewItem listıtem2 = new ListViewItem();
                listıtem2.Text = datareader["Elektrik"].ToString();
                listıtem2.SubItems.Add(datareader["Su"].ToString());
                listıtem2.SubItems.Add(datareader["Internet"].ToString());
                listView2.Items.Add(listıtem2);
            }
            sqlConnection.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();   
            SqlCommand cmd2 = new SqlCommand("insert into faturalar (elektrik,su,internet) values ('" +txtElektrik.Text+ "','" +txtSu.Text+ "','" +txtInternet.Text+ "')",sqlConnection);
            cmd2.ExecuteNonQuery();
            sqlConnection.Close();
            verileriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtGıda.Clear();
            txtIcecek.Clear();
            txtCerez.Clear();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtElektrik.Clear();
            txtSu.Clear(); 
            txtInternet.Clear();    
        }
    }
}
