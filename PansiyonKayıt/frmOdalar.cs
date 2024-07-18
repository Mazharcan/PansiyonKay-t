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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pansiyon;Integrated Security=True");  // çift slash adres haline getirmek demek

        private void frmOdalar_Load(object sender, EventArgs e)
        {
            //ODA101
            sqlConnection.Open();
            SqlCommand cmd1 = new SqlCommand("select * from oda101",sqlConnection);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                btn101.Text = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
            }
            sqlConnection.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
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
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaform frmAnaform = new frmAnaform();
            frmAnaform.Show();
        }
       
    }
}
