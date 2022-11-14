namespace E_Kutuphane
{
    partial class KitapEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleme));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitpNumarası = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.cbbBasimYili = new System.Windows.Forms.ComboBox();
            this.cbbKitapturu = new System.Windows.Forms.ComboBox();
            this.cbbEdinim = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnResimSil = new System.Windows.Forms.Button();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(207, 396);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 56);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitabın Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kitap Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yayın Evi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Edinim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kitap Basım Yılı:";
            // 
            // txtKitpNumarası
            // 
            this.txtKitpNumarası.Location = new System.Drawing.Point(112, 18);
            this.txtKitpNumarası.Name = "txtKitpNumarası";
            this.txtKitpNumarası.Size = new System.Drawing.Size(71, 23);
            this.txtKitpNumarası.TabIndex = 0;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(112, 54);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(135, 23);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(112, 90);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(135, 23);
            this.txtKitapYazari.TabIndex = 2;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(112, 126);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(135, 23);
            this.txtYayinEvi.TabIndex = 3;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(112, 306);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(135, 23);
            this.txtSayfaSayisi.TabIndex = 7;
            // 
            // cbbBasimYili
            // 
            this.cbbBasimYili.FormattingEnabled = true;
            this.cbbBasimYili.Items.AddRange(new object[] {
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cbbBasimYili.Location = new System.Drawing.Point(112, 198);
            this.cbbBasimYili.Name = "cbbBasimYili";
            this.cbbBasimYili.Size = new System.Drawing.Size(133, 23);
            this.cbbBasimYili.TabIndex = 4;
            // 
            // cbbKitapturu
            // 
            this.cbbKitapturu.FormattingEnabled = true;
            this.cbbKitapturu.Items.AddRange(new object[] {
            "Aforizmalar",
            "Ahlak",
            "Aile Bilgileri",
            "Aile/İnsan",
            "Aile/İnsan - Kadın",
            "Aksiyon ve Macera",
            "Anı",
            "Anı ve İnceleme",
            "Anı ve Seyahatname",
            "Anı, Mektup, Müzik",
            "Anı-Günlük-Mektup",
            "Anı/Gezi",
            "Anılar ve Biyografiler",
            "Anlatı",
            "Ansiklopedi",
            "Antoloji",
            "Antropoloji",
            "Araştırma",
            "Aritmetik,Cebir,Geometri",
            "Arkeoloji",
            "Arkeoloji ve Eski Çağ",
            "",
            "Askerlik Bilimi",
            "Askerlik ve Ordu",
            "Astroloji",
            "Astronomi ve YerBilimleri",
            "Aşk / Roman",
            "Aşk Şiirleri",
            "Aşk ve Romantizm",
            "Atatürk",
            "Atatürkçülük / Kemalizm",
            "Atlaslar, Planlar, Rehber",
            "Avcılık / Balıkçılık / Sp",
            "Avrupa Tarihi",
            "Azınlıklar ve Etnik Grup",
            "Balkanlar Tarihi",
            "Bankacılık",
            "Basın Yayın Tarihi",
            "Başvuru Eserleri",
            "Batı Resim Sanatı",
            "Belge/İnceleme",
            "Belgesel",
            "Belirtilmemiş",
            "Bilgi Kuramı/Epistemoloji",
            "Bilgisayar",
            "Bilim",
            "Bilim - Astronomi",
            "Bilim - Jeoloji - Deprem",
            "Bilim - Popüler bilim",
            "Bilim - Teknoloji",
            "Bilim Kurgu",
            "Bilim Tarihi",
            "Bilim-Biyoloji ve Genetik",
            "Bilim-Teknik",
            "Bilim/Ekoloji",
            "Bitkiler Alemi",
            "Biyografi",
            "Biyografi ve Anı",
            "Biyografi/Otobiyografi",
            "Büro ve Yönetimi",
            "Büyü,Gizem ve Kehanet",
            "Ceza Hukuku",
            "Cinsellik",
            "Cinsellik ve Üreme Etiği",
            "Coğrafya ve Seyahat",
            "Cumhuriyet Dönemi Öykü",
            "Cumhuriyet Tarihi",
            "Çağdaş Klasikler",
            "Çeviri Şiirler",
            "Çevre ve Ekoloji",
            "Çizgi Roman",
            "Çocuk Edebiyatı",
            "Çocuk Eğitimi",
            "Çocuk Eğitimi/Okul Öncesi",
            "Çocuk Eğitimi/Okul Sonras",
            "Çocuk Gelişimi",
            "Çocuk Kitapları",
            "Çocuk Psikolojisi",
            "Çocuk ve Ergen Gelişimi",
            "Demokrasi",
            "Deneme",
            "Derleme",
            "Devlet/Ordu",
            "Devrim/İhtilal",
            "Dış Politika/Uluslararası",
            "Diğer",
            "Diğer Dillerin Edebiyatı",
            "Dil",
            "Dil / Kurs Kitapları",
            "Dil Bilgisi",
            "Dil/Etimoloji",
            "Dilbilim",
            "Din",
            "Din / Araştırma",
            "Din / Budizm",
            "Din / Hırıstiyanlık",
            "Din / İslam",
            "Din-İslamiyet",
            "Din-Metafizik-Ruhbilim",
            "Din: İslam Araştırmaları",
            "Din: İslam Fıkıh (Hukuk)",
            "Din: İslam Mezhepleri",
            "Din: İslam Tarihi",
            "Din: İslam-Tasavvuf",
            "Din: Kuran ve Hadis",
            "Divan Edebiyatı",
            "Doğa Bilimleri",
            "Doğaüstü-Gizem",
            "Duygu Bozuklukları",
            "Dünya Dinleri",
            "Dünya Edebiyatı-Toplumsal",
            "Dünya Klasikleri",
            "Dünya Siyaseti",
            "Düşünce",
            "Düşünürler",
            "Edebiyat",
            "Edebiyat (Öykü - Roman)",
            "Edebiyat İncelemesi",
            "Edebiyat: Osmanlı Divan Ş",
            "Edebiyat: Türk Şiiri",
            "Efsaneler/Destanlar",
            "Eğitim",
            "Eğitim - Eğitim Bilim",
            "Eğitim - KPDS-ÜDS",
            "Eğitim > Dil Eğitimi",
            "Eğitim ve Ders Kitapları",
            "Eğlence",
            "Eğlence ve Gülmece",
            "Eğlence-Mizah",
            "Ekoloji",
            "Ekonomi",
            "Ekonomi Politikaları",
            "Ekonomi ve Finans",
            "Ekonomi-Emek-İş Dünyası",
            "Eleştiri",
            "Emperyalizm",
            "Ermeni Sorunu",
            "Estetik ve SanatFelsefesi",
            "Etik (Ahlak Felsefesi)",
            "Etnik Gruplar",
            "Fal / Rüya / Astroloji",
            "Fal-Burç-Büyü",
            "Fantastik",
            "Fantastik Roman",
            "Felsefe",
            "Felsefe ve Psikoloji",
            "Felsefe-Düşünce",
            "Fıkra",
            "Fizik, Kimya Bilimleri",
            "Folklor ve Gelenekler",
            "Fotoğraf",
            "Gazeteci Kitapları-Makale",
            "Gazeteci Yazarlar",
            "Gazetecilik, Yayıncılık",
            "Gençlik Edebiyatı",
            "Gençlik Kitapları",
            "Gençlik-Macera",
            "Genel Hukuk",
            "Genel Konular",
            "Gerilim ve Korku",
            "Gezi-Yorum",
            "Gizli Cemiyetler",
            "Gösteri Sanatları",
            "Günlük-Günce",
            "Güzel Sanatlar",
            "Güzel-Özlü Sözler",
            "Haber, Medya",
            "Halı, Kilim ve Dokuma",
            "Halk Edebiyatı",
            "Halkla İlişkiler",
            "Hatıra",
            "Hayvanlar Alemi",
            "Hiciv ve Mizah",
            "Hikaye",
            "Hobi",
            "Hobi - Briç-Satranç",
            "Hobi - El Sanatları",
            "Hobi - Fotoğrafçılık",
            "Hobi - Yemek kitapları",
            "Hobi / Bakım",
            "Hobi / Bakım-Güzellik",
            "Hobi ve Eğlence",
            "Hobi,Eğlence-SofraKültürü",
            "Hobi:Moda ve Giyim",
            "Hukuk",
            "Hukuk Felsefesi",
            "İç Politika",
            "İktisadi Düşünceler",
            "İktisadi Teoriler",
            "İletişim",
            "İnceleme-Araştırma",
            "İncelemeler, Tenkidler",
            "İnsan Kaynakları",
            "İnsan ve Toplum",
            "İslam",
            "İslâmiyet/Dua-İbadet",
            "İslâmiyet/Kuran-Hadisler",
            "İslâmiyet/Mezhep-Tarikat",
            "İstanbul Kitapları",
            "İstihbarat ve Casusluk",
            "İş Dünyası",
            "İş Dünyası-Kariyer",
            "İş İdaresi, Yöneticilik",
            "Kadın",
            "Kadın-Erkek İlişkileri",
            "Karikatür",
            "Kariyer ve Liderlik",
            "Katalog-Bibliyografya",
            "Kent /Çevre / Turizm",
            "Kent, Yerel Yönetim",
            "Keşif ve İcatlar",
            "Kişisel Gelişim",
            "Klasik Polisiye Romanlar",
            "Klasik Türk Edebiyatı",
            "Klavuz Kitaplar",
            "Kolektif",
            "Korku",
            "Korku-Gerilim",
            "Kuşkuculuk",
            "Kültür",
            "Kültür Sanat - Albüm",
            "Kültür Sanat-Mimari",
            "Kültür Tarihi",
            "Kültür-Sanat",
            "Küreselleşme",
            "Laiklik-Şeriat",
            "Macera",
            "Macera / Korku",
            "Makale",
            "Mantık",
            "Marksizm / Sol",
            "Masal",
            "Masal ve Fıkra",
            "Meditasyon/Yoga",
            "Medya ve İletişim",
            "Mektup",
            "Mesleki-Referans",
            "Metafizik-Ufo ve Uzay",
            "Meyvecilik ve Bahçecilik",
            "Mitoloji",
            "Mitolojik Masallar",
            "Mizah",
            "Modern Türkiye Tarihi",
            "Modern Türkiye ve Atatürk",
            "Müze - Sergi - Bienal",
            "Müzik",
            "Okkültizm (Gizlicilik)",
            "Okul Öncesi Eğitim",
            "Ordu-Polis-İstihbarat Örg",
            "Orta Asya Türk Tarihi",
            "Osmanlı Divan Şiiri",
            "Osmanlı Tarihi",
            "Otobiyografi",
            "Oyun",
            "Öykü",
            "Özdeyişler",
            "Parapsikoloji",
            "Periyodik Yayınlar",
            "PEYZAJ MİMARLIĞI",
            "Polisiye",
            "Polisiye - Macera",
            "Polisiye / Roman",
            "Polisiye Gerilim",
            "Polisiye-Casusluk",
            "Politika",
            "Politika - Devlet Yönetim",
            "Politika - Siyasi Tarih",
            "Politika - Siyasi Yazılar",
            "Politika-Devlet Yönetimi",
            "Politika-Devrim-İhtilal",
            "Politika-İç Politika",
            "Politika-Laiklik-Şeriat",
            "Politika-Siyaset",
            "Politika-Siyasi İdeoloji",
            "Politika-Siyasi Partiler",
            "Politika-Sosyal Politika",
            "Popüler Bilim",
            "Popüler Kültür",
            "Postmodernizm",
            "Psikanaliz",
            "Psikoloji",
            "Psikoloji - Davranışbilim",
            "Psikoloji - İletişim",
            "Psikoloji - Motivasyon",
            "Psikoloji - Psikanaliz",
            "Psikoloji - Psikiyatri",
            "Psikoloji > İnceleme",
            "Psikoloji Kuramları",
            "Psikoloji ve Pedagoji",
            "Psikoloji-Düşünce",
            "Psikoloji-Kişilik ve Zeka",
            "Psikoloji-Yaklaşımlar",
            "Reklamcılık",
            "Resimli Tarih",
            "Roman",
            "Röportaj",
            "Röportaj-Söyleşi",
            "Rus ve Slav Dilleri Edb.",
            "Sağlık",
            "Sağlık/Tıp",
            "Sahhaf",
            "Sanat",
            "Sanat - Fotoğraf",
            "Sanat - Resim",
            "Sanat - Sinema",
            "Sanat - Tarih",
            "Sanat - Tiyatro",
            "Sanat Tarihi",
            "Sanat ve Mimari",
            "Sanat ve Mimari: Hat",
            "Sanat ve Mimari:Ebru",
            "Sanat ve Mimari:Minyatür",
            "Sanat ve Mimari:Tezhib",
            "Sanat ve Mimarlık üzerine",
            "Sanat-Resim-Ressamlar",
            "Satranç, Briç, Oyun",
            "Senaryo-Sinema",
            "Senaryo/Oyun",
            "Serbest",
            "Seyahatname",
            "Sinema / Belgesel",
            "Sinema / Televizyon",
            "Sinema/Tiyatro",
            "Siyasal Akımlar",
            "Siyasal Bilimler",
            "Siyaset",
            "Siyaset Bilimi",
            "Siyaset-Doğu-Güneydoğu",
            "Siyasi İdeolojiler",
            "Siyasi Partiler",
            "Siyasi Tarih",
            "Sosyal Bilimler",
            "Sosyal Psikoloji",
            "Sosyoloji",
            "Söyleşi-Röportaj",
            "Söylev ve Mektuplar",
            "Sözlük",
            "Spor - Bireysel Sporlar",
            "Spor - Futbol",
            "Spor - Takım Sporları",
            "Şehir Tarihi",
            "Şiir",
            "Tarih",
            "Tarih - I. Dünya Savaşı",
            "Tarih - İlkçağ ve Öncesi",
            "Tarih - İnceleme",
            "Tarih - İslam Tarihi",
            "Tarih - Kurtuluş Savaşı",
            "Tarih - Medeniyetler",
            "Tarih - Mitoloji",
            "Tarih - Ortaçağ Tarihi",
            "Tarih - Ortadoğu",
            "Tarih - Osmanlı ve Öncesi",
            "Tarih - Popüler Tarih",
            "Tarih - Savaşlar/İsyanlar",
            "Tarih - Toplumsal Tarih",
            "Tarih - Türk Tarihi",
            "Tarih - Uygarlık Tarihi",
            "Tarih - Yakın Tarih",
            "Tarih / Anadolu Uygarlık l",
            "Tarih / Anı",
            "Tarih / Araştırma",
            "Tarih / Cumhuriyet Tarihi",
            "Tarih ve Politika",
            "Tarih-Türkiye Cumhuriyeti",
            "Tarih: Antik Çağ",
            "Tarih: Askeri Tarih",
            "Tarih: Asya Tarihi",
            "Tarih: Bilim Tarihi",
            "Tarih: Dünya Tarihi",
            "Tarih: Osmanlı Tarihi",
            "Tarih: Şehir Tarihleri",
            "Tarihi roman",
            "Tarihi Seyahatnameler",
            "Tasavvuf",
            "Tasavvuf Edebiyatı",
            "Tasavvuf ve Tarikatlar",
            "Tenkidler",
            "Terör ve Suç Örgütleri",
            "Tiyatro",
            "Tiyatro / Oyun",
            "Tiyatro Oyunu-Piyes",
            "Toplumbilim (Sosyoloji)",
            "Toplumsal Değişimler",
            "Toplumsal Sorunlar",
            "Turizm",
            "Türk Dili Grameri,Lehçe",
            "Türk Edebiyatı",
            "Türk Resim Sanatı",
            "Türkiye Cumhuriyeti Tarih",
            "Türkiye Ekonomisi",
            "Türkiye Tarihi",
            "Türkiye Üzerine",
            "Türkiye Üzerine Araştırma",
            "Uluslararası İlişkiler",
            "Ussalcılık (Rasyonalizm)",
            "Uygarlık Tarihi",
            "Uygulamalı Bilimler",
            "Varoluşçuluk",
            "Yabancı Dil Öğrenim",
            "Yasa- Mevzuat",
            "Yaşam ve Psikoloji",
            "Yaşamöykü/Anı/Mektup",
            "Yaşamöyküsü",
            "Yeme, İçme ve Gurme",
            "Yemek",
            "Yeni Dünya Düzeni",
            "Yönetim",
            "Zooloji"});
            this.cbbKitapturu.Location = new System.Drawing.Point(112, 234);
            this.cbbKitapturu.Name = "cbbKitapturu";
            this.cbbKitapturu.Size = new System.Drawing.Size(135, 23);
            this.cbbKitapturu.TabIndex = 5;
            // 
            // cbbEdinim
            // 
            this.cbbEdinim.FormattingEnabled = true;
            this.cbbEdinim.Items.AddRange(new object[] {
            "Bağış",
            "Satın Alındı",
            "Bulundu"});
            this.cbbEdinim.Location = new System.Drawing.Point(112, 270);
            this.cbbEdinim.Name = "cbbEdinim";
            this.cbbEdinim.Size = new System.Drawing.Size(135, 23);
            this.cbbEdinim.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(332, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResimEkle.Location = new System.Drawing.Point(336, 211);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(117, 24);
            this.btnResimEkle.TabIndex = 5;
            this.btnResimEkle.Text = "RESİM EKLE";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnResimSil
            // 
            this.btnResimSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResimSil.Location = new System.Drawing.Point(355, 241);
            this.btnResimSil.Name = "btnResimSil";
            this.btnResimSil.Size = new System.Drawing.Size(84, 25);
            this.btnResimSil.TabIndex = 6;
            this.btnResimSil.Text = "RESİM SİL";
            this.btnResimSil.UseVisualStyleBackColor = true;
            this.btnResimSil.Click += new System.EventHandler(this.btnResimSil_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btnİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnİptal.Image = ((System.Drawing.Image)(resources.GetObject("Btnİptal.Image")));
            this.Btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnİptal.Location = new System.Drawing.Point(339, 396);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(128, 56);
            this.Btnİptal.TabIndex = 7;
            this.Btnİptal.Text = "İPTAL";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbEdinim);
            this.groupBox1.Controls.Add(this.cbbBasimYili);
            this.groupBox1.Controls.Add(this.txtSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.txtKitapYazari);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.txtKitpNumarası);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbKitapturu);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(112, 162);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(53, 23);
            this.txtAdet.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adeti :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // KitapEkleme
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 464);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.btnResimSil);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP EKLEME";
            this.Load += new System.EventHandler(this.KitapEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitpNumarası;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cbbBasimYili;
        private System.Windows.Forms.ComboBox cbbKitapturu;
        private System.Windows.Forms.ComboBox cbbEdinim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnResimSil;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
    }
}