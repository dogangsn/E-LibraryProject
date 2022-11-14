using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace E_Kutuphane
{
    public partial class KitapListele : Form
    {
     
        public KitapListele()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter da;
        DataSet ds;

        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From KitapListesi", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo; 
        }
        
        public void arama(string aranan)
        {
            string bastan_Arama = "select * from KitapListesi where KatapAdı like'" + aranan + "'%";
            OleDbDataAdapter adaptor = new OleDbDataAdapter(bastan_Arama, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
           

        }
        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        int kactane, kacadet;
        private void KitapListele_Load(object sender, EventArgs e)
        {
            Listele();
            kactane = dataGridView1.RowCount;
            lblSayac.Text = kactane.ToString();
            timer1.Start();

            string islem = "select sum(Adeti) as toplam from KitapListesi";
            baglanti.Open(); // Bağlantıyı açıyoruz // Sorguyu komuta atıyoruz
            OleDbCommand komut = new OleDbCommand(islem, baglanti);
            lblSayac2.Text = komut.ExecuteScalar().ToString();
            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz
            baglanti.Close(); // Bağlantıyı mutlaka kapatıyoruz

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //arama(textBox1.Text);
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            da = new OleDbDataAdapter("SElect *from KitapListesi where KatapAdı like '" + textBox1.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "KitapListesi");
            dataGridView1.DataSource = ds.Tables["KitapListesi"];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label4.Text = now.ToString();
        }
    }
}
