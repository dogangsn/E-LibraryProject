using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//DoğanGüneş
using System.Data.OleDb;

namespace E_Kutuphane
{
    public partial class AnaSayfacs : Form
    {
        public AnaSayfacs()
        {
            InitializeComponent();
        }
        
    
        private void AnaSayfacs_Load(object sender, EventArgs e)
        {
           // timer1.Start();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.BalloonTipText = "Uygulama Hala Çalışıyor...";
            notifyIcon1.BalloonTipTitle = "Örnek Uygulama";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblOkulİsmi.Text = this.lblOkulİsmi.Text.Substring(1) + this.lblOkulİsmi.Text.Substring(0, 1);
            DateTime now = DateTime.Now;
            toolStripStatusLabel2.Text = now.ToString();
        }

        private void bntCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmaktan Emin misin ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleme frm = new KitapEkleme();
            frm.ShowDialog();
        }

        private void btnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            OkuyucuEkle frm = new OkuyucuEkle();
            frm.ShowDialog();
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            KitapTeslim frm = new KitapTeslim();
            frm.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListele frm = new KitapListele();
            frm.ShowDialog();
        }

        private void btnOkuyucuListele_Click(object sender, EventArgs e)
        {
            OkuyucuL frm = new OkuyucuL();
            frm.ShowDialog();
        }

        private void btnTarihiGecenler_Click(object sender, EventArgs e)
        {
            YapımAsamasında frm = new YapımAsamasında();
            frm.ShowDialog();
        }

        private void btnListeyiSifirla_Click(object sender, EventArgs e)
        {
            ListeyiSıfrla frm = new ListeyiSıfrla();
            frm.ShowDialog();
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void AnaSayfacs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);

            }
        }

        private void AnaSayfacs_Resize(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);

            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void önecekiBoyutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
