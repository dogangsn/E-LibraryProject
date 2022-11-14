using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace E_Kutuphane
{
    public partial class KitapTeslim : Form
    {
        public KitapTeslim()
        {
            InitializeComponent();
        }
        KisiselBilgiler frm = new KisiselBilgiler();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter da;
        DataSet ds;
        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select KitapNum,OAdı,OSoyadi,OSinifi,ONumarasi,OBolum From Okuyucu", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void KitapTeslim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText="DELETE FROM Okuyucu WHERE ONumarasi='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele();
              
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from Okuyucu where OAdı=" + txtOgrAdi.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele();
                */
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
                da = new OleDbDataAdapter("delete from Okuyucu where ONumarasi= " + txtOgrNumaara.Text +"'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Okuyucu");
                dataGridView1.DataSource = ds.Tables["Okuyucu"];
                baglanti.Close();

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //arama(textBox1.Text);
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            da = new OleDbDataAdapter("SElect KitapNum,OAdı,OSoyadi,OSinifi,ONumarasi,OBolum from Okuyucu where ONumarasi like '" + txtOgrNumaara.Text + "%'", baglanti);        
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Okuyucu");
            dataGridView1.DataSource = ds.Tables["Okuyucu"];
            baglanti.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //secilensatir = Convert.ToInt16(ds.Tables["Okuyucu"].Rows[e.RowIndex]["ONumarasi"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm.lblOgrenciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.lblSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.lblSinifi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.lblNumarasi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.lblBolum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.ShowDialog();
        }
    }
}