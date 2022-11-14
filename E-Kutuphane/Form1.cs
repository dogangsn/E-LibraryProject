using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace E_Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataReader dr;

        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Okuyucu", baglanti);
            adtr.Fill(tablo);
            //dataGridView1.DataSource = tablo;
        }
        int sayac = 3;
        Random r = new Random();
        int x, y;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            
                string ad = txt_KullniciAdi.Text;
                string sifre = txtSifre.Text;
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM Ogrenci where KullaniciAdi='" + txt_KullniciAdi.Text + "' AND Sifre='" + txtSifre.Text + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AnaSayfacs frm = new AnaSayfacs();
                    frm.Show();
                    this.Visible = false;
                }
                else
                {
                    if (txt_KullniciAdi.Text == "" || txtSifre.Text == "")
                    {
                    int c = 0;
                    Point l = this.Location;
                    while (c < 40)
                    {
                        int x = r.Next(1, 10);
                        int y = r.Next(1, 10);
                        this.Location = new Point(l.X + x, l.Y + y);
                        Thread.Sleep(20);
                        c++;

                    }
                    this.Location = l;
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    int c = 0;
                    Point l = this.Location;
                    while (c < 40)
                    {
                        int x = r.Next(1, 10);
                        int y = r.Next(1, 10);
                        this.Location = new Point(l.X + x, l.Y + y);
                        Thread.Sleep(20);
                        c++;

                    }
                    this.Location = l;
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void chbBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBeniHatirla.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
