namespace E_Kutuphane
{
    partial class OkuyucuL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkuyucuL));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.KitapNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ONumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapNum,
            this.KitapAdi,
            this.KitapTarih,
            this.KitapDurumu,
            this.OAdı,
            this.OSoyadi,
            this.OSinifi,
            this.ONumarasi,
            this.OBolum});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Okuyucu Sayısı :";
            // 
            // lblSayac
            // 
            this.lblSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayac.Location = new System.Drawing.Point(151, 398);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(47, 22);
            this.lblSayac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(792, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KitapNum
            // 
            this.KitapNum.DataPropertyName = "KitapNum";
            this.KitapNum.HeaderText = "Kitap Numarası";
            this.KitapNum.Name = "KitapNum";
            this.KitapNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // KitapTarih
            // 
            this.KitapTarih.DataPropertyName = "KitapTarih";
            this.KitapTarih.HeaderText = "Kitap Tarihi";
            this.KitapTarih.Name = "KitapTarih";
            // 
            // KitapDurumu
            // 
            this.KitapDurumu.DataPropertyName = "KitapDurumu";
            this.KitapDurumu.HeaderText = "Kitap Durumu";
            this.KitapDurumu.Name = "KitapDurumu";
            // 
            // OAdı
            // 
            this.OAdı.DataPropertyName = "OAdı";
            this.OAdı.HeaderText = "Öğrenci Adı";
            this.OAdı.Name = "OAdı";
            // 
            // OSoyadi
            // 
            this.OSoyadi.DataPropertyName = "OSoyadi";
            this.OSoyadi.HeaderText = "Öğrenci Soyadı";
            this.OSoyadi.Name = "OSoyadi";
            // 
            // OSinifi
            // 
            this.OSinifi.DataPropertyName = "OSinifi";
            this.OSinifi.HeaderText = "Öğrenci Sınıfı";
            this.OSinifi.Name = "OSinifi";
            // 
            // ONumarasi
            // 
            this.ONumarasi.DataPropertyName = "ONumarasi";
            this.ONumarasi.HeaderText = "Öğrenci Numarası";
            this.ONumarasi.Name = "ONumarasi";
            // 
            // OBolum
            // 
            this.OBolum.DataPropertyName = "OBolum";
            this.OBolum.HeaderText = "Öğrenci Bölüm";
            this.OBolum.Name = "OBolum";
            // 
            // OkuyucuL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OkuyucuL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OKUYUCU LİSTESİ";
            this.Load += new System.EventHandler(this.OkuyucuL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn OAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSinifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ONumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBolum;
    }
}