using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace E_Kutuphane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        void Listele()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            da = new OleDbDataAdapter("SElect *from Okuyucu", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Okuyucu");
            dataGridView1.DataSource = ds.Tables["Okuyucu"];
            con.Close();
        }

        void Listele2()
        {

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            da = new OleDbDataAdapter("SElect *from KitapListesi", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "KitapListesi");
            dataGridView2.DataSource = ds.Tables["KitapListesi"];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region Liste1
            ApplicationClass excel = new ApplicationClass();
            excel.Visible = true;

            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                    catch
                    {
                        ;
                    }
                }
            }
            #endregion
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
            Listele2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Listele2
            ApplicationClass excel = new ApplicationClass();
            excel.Visible = true;

            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView2.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    try
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value;
                        myRange.Select();
                    }
                    catch
                    {
                        ;
                    }
                }
            }
            #endregion
        }
    }
}
