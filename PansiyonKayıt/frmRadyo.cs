﻿using System;
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
    public partial class frmRadyo : Form
    {
        public frmRadyo()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaform frmAnaform = new frmAnaform();
            frmAnaform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://46.20.3.201:80 ";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://77.223.136.16:9920 ";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://cast1.taksim.fm:8014 ";
        }
    }
}
