using System;
//DoğanGüneş
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
    public partial class ListeyiSıfrla : Form
    {
        public ListeyiSıfrla()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int x, y;
        //DoğanGüneş
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
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Yonetici where KullaniciAdi='" + txtKullaniciAdi.Text + "' AND Sifre='" + txtSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (MessageBox.Show("Listeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    komut = new OleDbCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete * from Okuyucu";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Visible = false;
                    baglanti.Close();//DoğanGÜneş
                    Listele();
                }
            }
            else
            {
                if (txtKullaniciAdi.Text==""&&txtSifre.Text=="")
                {
                    int c = 0;
                    Point l = this.Location;
                    while (c < 30)
                    {
                        int x = r.Next(1, 10);
                        int y = r.Next(1, 10);
                        this.Location = new Point(l.X + x, l.Y + y);
                        Thread.Sleep(20);
                        c++;

                    }
                    this.Location = l;
                    label3.Text="Lütfen Boşlukları Doldurunuz...";
                    label3.ForeColor = Color.Red;
                
                }
                else
                {
                    int cc = 0;
                    label3.Text = "Kullanıcı adı ya da şifre yanlış";
                    label3.ForeColor = Color.Red;
                    Point ll = this.Location;
                    while (cc < 30)
                    {
                        int x = r.Next(1, 10);
                        int y = r.Next(1, 10);
                        this.Location = new Point(ll.X + x, ll.Y + y);
                        Thread.Sleep(20);
                        cc++;

                    }
                    this.Location = ll;
                }
               
            }

            baglanti.Close();

        }

        private void ListeyiSıfrla_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
