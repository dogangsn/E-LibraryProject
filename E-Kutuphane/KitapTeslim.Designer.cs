namespace E_Kutuphane
{
    partial class KitapTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapTeslim));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBolum = new System.Windows.Forms.ComboBox();
            this.txtOgrNumaara = new System.Windows.Forms.TextBox();
            this.txtOgrSinifi = new System.Windows.Forms.TextBox();
            this.txtOgrSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgrAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ONumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "TESLİM EDİLDİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbBolum);
            this.groupBox1.Controls.Add(this.txtOgrNumaara);
            this.groupBox1.Controls.Add(this.txtOgrSinifi);
            this.groupBox1.Controls.Add(this.txtOgrSoyadi);
            this.groupBox1.Controls.Add(this.txtOgrAdi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin";
            // 
            // cbbBolum
            // 
            this.cbbBolum.FormattingEnabled = true;
            this.cbbBolum.Items.AddRange(new object[] {
            "Bilişim Teknolojileri",
            "Elektrik-Elektronik Teknolojisi",
            "Mobilya ve İç Mekan Tasarımı",
            "Metal Teknolojisi",
            "Tesisat Teknolojisi ve İklimlendirme"});
            this.cbbBolum.Location = new System.Drawing.Point(79, 135);
            this.cbbBolum.Name = "cbbBolum";
            this.cbbBolum.Size = new System.Drawing.Size(138, 23);
            this.cbbBolum.TabIndex = 7;
            this.cbbBolum.Text = "Yok";
            // 
            // txtOgrNumaara
            // 
            this.txtOgrNumaara.Location = new System.Drawing.Point(79, 106);
            this.txtOgrNumaara.Name = "txtOgrNumaara";
            this.txtOgrNumaara.Size = new System.Drawing.Size(72, 23);
            this.txtOgrNumaara.TabIndex = 6;
            // 
            // txtOgrSinifi
            // 
            this.txtOgrSinifi.Location = new System.Drawing.Point(79, 77);
            this.txtOgrSinifi.Name = "txtOgrSinifi";
            this.txtOgrSinifi.Size = new System.Drawing.Size(72, 23);
            this.txtOgrSinifi.TabIndex = 6;
            // 
            // txtOgrSoyadi
            // 
            this.txtOgrSoyadi.Location = new System.Drawing.Point(79, 50);
            this.txtOgrSoyadi.Name = "txtOgrSoyadi";
            this.txtOgrSoyadi.Size = new System.Drawing.Size(122, 23);
            this.txtOgrSoyadi.TabIndex = 6;
            // 
            // txtOgrAdi
            // 
            this.txtOgrAdi.Location = new System.Drawing.Point(79, 21);
            this.txtOgrAdi.Name = "txtOgrAdi";
            this.txtOgrAdi.Size = new System.Drawing.Size(122, 23);
            this.txtOgrAdi.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bölümü:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Numarası:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sınıfı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Soyadı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapNum,
            this.OAdı,
            this.OSoyadi,
            this.OSinifi,
            this.ONumarasi,
            this.OBolum});
            this.dataGridView1.Location = new System.Drawing.Point(306, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 172);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // KitapNum
            // 
            this.KitapNum.DataPropertyName = "KitapNum";
            this.KitapNum.HeaderText = "Kitap Numarası";
            this.KitapNum.Name = "KitapNum";
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
            this.ONumarasi.HeaderText = "Öğrenci Numrası";
            this.ONumarasi.Name = "ONumarasi";
            // 
            // OBolum
            // 
            this.OBolum.DataPropertyName = "OBolum";
            this.OBolum.HeaderText = "Öğrenci Bölümü";
            this.OBolum.Name = "OBolum";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KitapTeslim
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapTeslim";
            this.Load += new System.EventHandler(this.KitapTeslim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbBolum;
        private System.Windows.Forms.TextBox txtOgrNumaara;
        private System.Windows.Forms.TextBox txtOgrSinifi;
        private System.Windows.Forms.TextBox txtOgrSoyadi;
        private System.Windows.Forms.TextBox txtOgrAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSinifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ONumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBolum;
        private System.Windows.Forms.Button button2;
    }
}