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
    public partial class OkuyucuL : Form
    {
        public OkuyucuL()
        {
            InitializeComponent();
        }
        KisiselBilgiler frm = new KisiselBilgiler();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        private void Listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select KitapNum,KitapAdi,KitapTarih,KitapDurumu,OAdı,OSoyadi,OSinifi,ONumarasi,OBolum From Okuyucu", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        int kayitsayisi;
        private void OkuyucuL_Load(object sender, EventArgs e)
        {
            Listele();
            timer1.Start();
            kayitsayisi = dataGridView1.RowCount;
            lblSayac.Text = kayitsayisi.ToString();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label2.Text = now.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm.lblOgrenciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.lblSoyadi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.lblSinifi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.lblNumarasi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.lblBolum.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.ShowDialog();
        }
    }
}
