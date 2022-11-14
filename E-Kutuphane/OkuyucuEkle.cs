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
    public partial class OkuyucuEkle : Form
    {
        public OkuyucuEkle()
        {
            InitializeComponent();
        }
      
   
        
        
       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Okuyucu", baglanti);
           // adtr.Fill(tablo);
            //dataGridView1.DataSource = tablo;
        }
        //OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=Database1.accdb");
        //OleDbCommand kmt = new OleDbCommand();
        //DataTable tablo = new DataTable();
        Random r = new Random();
        int x, y;
        private void OkuyucuEkle_Load(object sender, EventArgs e)
        {
        
            Listele();

        }
        
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKitapNumarası.Text==""||txtKitapAdi.Text==""||txtKitpDrm.Text==""||txtOgrAdi.Text==""||txtOgrNumaara.Text==""||txtOgrSinifi.Text==""||txtOgrSoyadi.Text=="")
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
                MessageBox.Show("Lütfen Boş Bırakmayınız.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Okuyucu (KitapNum,KitapAdi,KitapTarih,KitapDurumu,OAdı,OSoyadi,OSinifi,ONumarasi,OBolum) values ('" + txtKitapNumarası.Text + "','" + txtKitapAdi.Text + "','" + dateTimePicker1.Text + "','" + txtKitpDrm.Text + "','" + txtOgrAdi.Text + "','" + txtOgrSoyadi.Text + "','" + txtOgrSinifi.Text + "','" + txtOgrNumaara.Text + "','" + cbbBolum.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kayıt Edilmiştir...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Visible = false;
                baglanti.Close();
                Listele();
            }
        }

        private void btnResimCek_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
