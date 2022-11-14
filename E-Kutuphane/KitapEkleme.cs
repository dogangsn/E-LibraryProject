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
//DoğanGüneş
namespace E_Kutuphane
{
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }
        #region Listele
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From KitapListesi", baglanti);
            adtr.Fill(tablo);
            //dataGridView1.DataSource = tablo;
        }
        #endregion
        Random r = new Random();
        int x, y;
        private void Btnİptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İptal Etmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question,0,0,true) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKitpNumarası.Text == "" && txtKitapAdi.Text == "" && txtKitapYazari.Text == "" && txtYayinEvi.Text == "" && txtSayfaSayisi.Text == "" && cbbBasimYili.Text == "" && cbbEdinim.Text == "" && cbbKitapturu.Text == "")
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
                    MessageBox.Show("Lütfen Boş Bırakmayınız.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning,0,0,true);
                }

                else
                {
                    komut = new OleDbCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "insert into KitapListesi (KitapNum,KatapAdı,KitapYaz,YayinEvi,Adeti,KitapBasimYili,KitapTuru,Edinim,SayfaSayisi,Resim) values ('" + txtKitpNumarası.Text + "','" + txtKitapAdi.Text + "','" + txtKitapYazari.Text + "','" + txtYayinEvi.Text + "','" + txtAdet.Text + "','" + cbbBasimYili.Text + "','" + cbbKitapturu.Text + "','" + cbbEdinim.Text + "','" + txtSayfaSayisi.Text + "','" + label10.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Kayıt Edilmiştir...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Visible = false;
                    baglanti.Close();
                    Listele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Eklemek İsdeğiniz Kitap Zaten Bulunmaktadır","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        
        }

        private void KitapEkleme_Load(object sender, EventArgs e)
        {

        }

       

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "FPEG Files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label10.Text = openFileDialog1.FileName.ToString();
            }
        }
    }
}
