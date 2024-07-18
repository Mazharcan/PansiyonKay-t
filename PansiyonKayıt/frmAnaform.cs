using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayıt
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();   
            frmAdminGiris frmAdminGiris = new frmAdminGiris(); 
            frmAdminGiris.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();   
            frmYeniMusteri.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOdalar frmOdalar = new frmOdalar();
            frmOdalar.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteriler frmmusteriler = new frmMusteriler();
            frmmusteriler.Show();
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHakkımızda frmHakkımızda = new frmHakkımızda();
            frmHakkımızda.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.LightSkyBlue;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnYeniMusteri_MouseHover(object sender, EventArgs e)
        {
            btnYeniMusteri.BackColor = Color.LightSkyBlue;
        }

        private void btnYeniMusteri_MouseLeave(object sender, EventArgs e)
        {
            btnYeniMusteri.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnOdalar_MouseHover(object sender, EventArgs e)
        {
            btnOdalar.BackColor = Color.LightSkyBlue;
        }

        private void btnOdalar_MouseLeave(object sender, EventArgs e)
        {
            btnOdalar.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnMusteriMesajları_MouseHover(object sender, EventArgs e)
        {
            btnMusteriMesajları.BackColor = Color.LightSkyBlue;
        }

        private void btnMusteriMesajları_MouseLeave(object sender, EventArgs e)
        {
            btnMusteriMesajları.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnMusteri_MouseHover(object sender, EventArgs e)
        {
            btnMusteri.BackColor = Color.LightSkyBlue;
        }

        private void btnMusteri_MouseLeave(object sender, EventArgs e)
        {
            btnMusteri.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnPersonelMaas_MouseHover(object sender, EventArgs e)
        {
            btnGelirGider.BackColor = Color.LightSkyBlue;
        }

        private void btnPersonelMaas_MouseLeave(object sender, EventArgs e)
        {
            btnGelirGider.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnStok_MouseHover(object sender, EventArgs e)
        {
            btnStok.BackColor = Color.LightSkyBlue;
        }

        private void btnStok_MouseLeave(object sender, EventArgs e)
        {
            btnStok.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnRadyo_MouseHover(object sender, EventArgs e)
        {
            btnRadyo.BackColor = Color.LightSkyBlue;
        }

        private void btnRadyo_MouseLeave(object sender, EventArgs e)
        {
            btnRadyo.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnCıkıs_MouseHover(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = Color.Red;
        }

        private void btnCıkıs_MouseLeave(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = SystemColors.ControlDarkDark;
        }

        private void frmAnaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TIMER ekleyerek formda görünen tarih ve saati akış haline getirdik sabit kalmıyor program çalıştığı müddetçe zamanve tarih akmaya devam ediyor
            label1.Text = DateTime.Now.ToLongDateString();  //O GÜNÜN TARİHİ YAZAR
            label2.Text = DateTime.Now.ToLongTimeString();  //O ANIN SAATİNİ YAZAR
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGelirGider frmGelirGider = new frmGelirGider();
            frmGelirGider.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmStoklar frmStoklar = new frmStoklar();
            this.Hide();
            frmStoklar.Show();  
        }

        private void btnRadyo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRadyo frmRadyo = new frmRadyo();
            frmRadyo.Show();
        }

        private void btnMusteriMesajları_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteriMesajları frmMusteriMesajları = new frmMusteriMesajları();
            frmMusteriMesajları.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGazeteler frmGazeteler = new frmGazeteler();
            frmGazeteler.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnGazete.BackColor = Color.LightSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnGazete.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnHakkımızda_MouseHover(object sender, EventArgs e)
        {
            btnHakkımızda.BackColor = Color.LightSkyBlue;
        }

        private void btnHakkımızda_MouseLeave(object sender, EventArgs e)
        {
            btnHakkımızda.BackColor = SystemColors.ControlDarkDark;
        }
    }
}
